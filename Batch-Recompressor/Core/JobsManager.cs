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
        private readonly object _lock;

        public JobsManager()
        {
            _cancellationTokenSource = new();
            _lock  = new();
            Status = new();
            Jobs   = new();
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
            lock (_lock)
            {
                if (!IsRunning)
                {
                    IsRunning = true;
                    CurrentJobSettings = settings.Clone();
                    Task.Run(
                        () => RunExecutionLoop(managerProgress), 
                        _cancellationTokenSource.Token);
                }
            }
        }

        private async Task RunExecutionLoop(IProgress<JobManagerStatus>? managerProgress = null) 
        {
            Progress<JobStatus> jobProgress = new((jobStatus) => {
                Status.CurrentJobStatus = jobStatus;
                managerProgress?.Report(Status);
            });

            while (!_cancellationTokenSource.IsCancellationRequested)
            {
                var queuedJob = Jobs
                    .Where(job => job.Status.State == JobState.Queued)
                    .First();

                if (queuedJob is null)
                    break;

                await queuedJob.Run(
                    CurrentJobSettings!,
                    _cancellationTokenSource.Token,
                    jobProgress);

                Status.TotalJobs = Jobs.Count;
                Status.JobsCompleted++;
            }

            CurrentJobSettings = null;
            IsRunning = false;
        }

        public void Stop()
        {
            lock (_lock)
            {
                if (IsRunning)
                    _cancellationTokenSource.Cancel();
            }
        }
    }
}
