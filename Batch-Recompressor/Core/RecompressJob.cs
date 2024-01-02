using Batch_Recompressor.Common;
using Xabe.FFmpeg;

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
        private readonly ulong _inputFileSize;
        private readonly ulong _outputFileSize;
        private readonly object _lock;
        
        public RecompressJob(string path)
        {
            _inputFileSize = (ulong) new FileInfo(path).Length;
            _lock = new object();
            Status = new();
            Path = path;
        }

        public JobSettings? Settings { get; private set; }
        public JobStatus Status { get; }
        public string Path { get; }


        public string InputFileSize
        {
            get 
            { 
                lock (_lock)
                    return Misc.FileSizeToString(_inputFileSize);
            }
        }

        public string OutputFileSize
        {
            get
            {
                lock (_lock)
                    return _outputFileSize != 0
                        ? Misc.FileSizeToString(_outputFileSize)
                        : string.Empty;
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
