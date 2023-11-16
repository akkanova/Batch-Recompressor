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

    // Struct used by DataGridView progress column
    public struct TaskStatus
    {
        public int Progress { get; set; }
        public TaskState State { get; set; }
    }

    public class RecompressTask
    {
        private readonly ulong _inputFileSize;
        private readonly ulong _outputFileSize;
        
        public RecompressTask(string path, TaskSettings settings)
        {
            _inputFileSize = (ulong)new FileInfo(path).Length;
            Settings = settings;
            Status = new();
            Path = path;
        }

        public TaskSettings Settings { get; }
        public TaskStatus Status { get; }
        public string Path { get; }

        public string InputFileSize
        {
            get => Misc.ToHumanReadable(_inputFileSize);
        }

        public string OutputFileSize
        {
            get => _outputFileSize != 0
                ? Misc.ToHumanReadable(_outputFileSize)
                : string.Empty;
        }
    }
}
