namespace Batch_Recompressor.Core
{
    public enum JobState
    {
        Queued,
        Preprocess,
        Ongoing,
        FirstPass,
        SecondPass,
        Postprocess,
        Completed
    }
 
    public class JobStatus
    {
        public int Progress { get; set; }
        public JobState State { get; set; }
    }

    public class RecompressJob
    {
        private ulong _inputFileSize;
        private ulong _outputFileSize;
        private readonly object _lock;
        
        public RecompressJob(string path)
        {
            _inputFileSize = (ulong)new FileInfo(path).Length;
            _lock  = new();
            Status = new();
            Path = path;
        }

        public JobSettings? Settings { get; private set; }
        public JobStatus Status { get; }
        public string Path { get; }

        public ulong InputFileSize {
            get
            {
                lock (_lock)
                    return _inputFileSize;
            }

            private set
            {
                lock (_lock)
                    _inputFileSize = value;
            }
        }

        public ulong OutputFileSize
        {
            get
            {
                lock (_lock)
                    return _outputFileSize;
            }

            private set
            {
                lock (_lock)
                    _outputFileSize = value;
            }
        }

        public async Task Run(
            JobSettings settings,
            CancellationToken token = default, 
            IProgress<JobStatus>? progress = null
        ) {

        }
    }
}
