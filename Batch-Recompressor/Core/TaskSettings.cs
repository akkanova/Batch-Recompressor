namespace Batch_Recompressor.Core
{
    public enum VideoCodec
    {
        AV1, // SVT-AV1
        VP9,
        HEVC, // H.265
        AVC // H.264
    }

    public enum AudioCodec
    {
        Passthrough,
        Opus,
        AAC
    }

    public enum Container
    {
        MP4,
        WebM,
        MKV
    }

    public class TaskSettings
    {
        public static string DefaultOutputFolder { get; } 

        static TaskSettings() {
            DefaultOutputFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
        }

        public string? PreprocessCommand { get; set; }
        public VideoCodec VideoCodec { get; set; }
        public bool ShouldTwoPassEncode { get; set; }
        public bool UseConstantRateFactor { get; set; }
        public double ShrinkFactor { get; set; }
        public Container Container { get; set; }
        public AudioCodec AudioCodec { get; set; }
        public uint AudioBitrate { get; set; }
        public string? CustomArgument { get; set; }
        public string? PostprocessCommand { get; set; }
        public string OutputFolder { get; set; }

        public TaskSettings()
        {
            OutputFolder = DefaultOutputFolder;
            ShrinkFactor = 1.0;
        }

        public TaskSettings Clone()
        {
            return (TaskSettings)MemberwiseClone();
        }
    }
}
