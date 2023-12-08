using Batch_Recompressor.AllPurpose;

namespace Batch_Recompressor.Core
{
    public enum TaskState
    {
        Queued,
        Preprocess,
        Ongoing,
        FirstPass,
        SecondPass,
        Postprocess,
        Completed
    }
 
    // Used by DataGridView progress column
    public class TaskStatus
    {
        public int Progress { get; set; }
        public TaskState State { get; set; }
    }

    public class RecompressTask
    {
        private readonly ulong _inputFileSize;
        private readonly ulong _outputFileSize;
        private readonly object _lock;
        
        public RecompressTask(string path)
        {
            _inputFileSize = (ulong) new FileInfo(path).Length;
            _lock = new object();
            Status = new();
            Path = path;
        }

        public TaskSettings? Settings { get; private set; }
        public TaskStatus Status { get; }
        public string Path { get; }


        public string InputFileSize
        {
            get 
            { 
                lock (_lock)
                {
                    return Misc.FileSizeToString(_inputFileSize); 
                }
            }
        }

        public string OutputFileSize
        {
            get
            {
                lock (_lock)
                {
                    return _outputFileSize != 0
                        ? Misc.FileSizeToString(_outputFileSize)
                        : string.Empty;
                }
            }
        }
    }
}
