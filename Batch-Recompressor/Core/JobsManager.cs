using Batch_Recompressor.Common;

namespace Batch_Recompressor.Core
{
    public class JobManagerStatus
    {
        public JobStatus? CurrentJobStatus { get; set; }
        public int JobsCompleted { get; set; }
        public int TotalJobs { get; set; }
    }

    public class JobsManager
    {
        public static List<string> AllowedFileExtensions { get; }

        static JobsManager() 
        {
            AllowedFileExtensions = new() 
            {
                ".3gp", ".adts", ".flac",
                ".mkv", ".mpeg", ".mp4",
                ".ogg", ".mov",  ".webm"
            };
        }

        public ConcurrentList<RecompressJob> Jobs { get; }
        public JobSettings? CurrentJobSettings    { get; private set; }
        public JobManagerStatus Status            { get; }
        public bool IsRunning                     { get; private set; }

        private readonly CancellationTokenSource _cancellationTokenSource;

        public JobsManager()
        {
            _cancellationTokenSource = new();
            Status = new();
            Jobs = new();
        }

        public void CreateTasks(string[] paths)
        {
            foreach (string path in paths)
            {
                string extension = Path.GetExtension(path);
                if (AllowedFileExtensions.Contains(extension))
                    Jobs.Add(new RecompressJob(path));
            }
        }

        public void Start(
            JobSettings settings, 
            IProgress<JobManagerStatus>? managerProgress = null
        ) {
            if (!IsRunning)
            {
                IsRunning = true;
                CurrentJobSettings = settings.Clone();
                Task.Run(RunExecutionLoop, _cancellationTokenSource.Token);
            }

            async Task RunExecutionLoop()
            {
                Progress<JobStatus> jobProgress = new((jobStatus) => {
                    Status.CurrentJobStatus = jobStatus;
                    managerProgress?.Report(Status);
                });

                while (!_cancellationTokenSource.IsCancellationRequested)
                {
                    var queuedTask = Jobs
                        .Where(job => job.Status.State == JobState.Queued)
                        .First();

                    if (queuedTask == null)
                        break;

                    await queuedTask.Run(
                        CurrentJobSettings, 
                        _cancellationTokenSource.Token,
                        jobProgress
                    );

                    Status.TotalJobs = Jobs.Count;
                    Status.JobsCompleted++;
                }

                CurrentJobSettings = null;
                IsRunning = false;
            }
        }

        public void Stop() 
        { 
            if (IsRunning)
                _cancellationTokenSource.Cancel();
        }
    }
}
