using System.Text.RegularExpressions;

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
        public bool UseTwoPassEncode { get; set; }
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

        public void Validate()
        {
            if (!IsValidPreOrPostProcessCommand(PreprocessCommand))
                throw new InvalidOperationException("Postprocess command missing input or output placeholder");

            if (!IsValidPreOrPostProcessCommand(PostprocessCommand))
                throw new InvalidOperationException("Preporcess command missing input or output placeholder");
        }

        private static bool IsValidPreOrPostProcessCommand(string? command)
        {
            return command is null ||
                Regex.IsMatch(command, "{input}.*{output}",
                    RegexOptions.IgnoreCase | RegexOptions.Multiline
                );
        }
    }
}
