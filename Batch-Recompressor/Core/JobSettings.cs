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

    public class JobSettings
    {
        public string? PreprocessCommand  { get; set; }
        public VideoCodec VideoCodec      { get; set; }
        public bool UseTwoPassEncode      { get; set; }
        public bool UseConstantRateFactor { get; set; }
        public double ShrinkFactor        { get; set; }
        public Container Container        { get; set; }
        public AudioCodec AudioCodec      { get; set; }
        public uint AudioBitrate          { get; set; }
        public string? CustomArgument     { get; set; }
        public string? PostprocessCommand { get; set; }
        public string OutputDirectory     { get; set; }

        public JobSettings()
        {
            OutputDirectory = GlobalSettings.Instance.DefaultOutputDirectory;
            ShrinkFactor = 1.0;
        }

        public JobSettings Clone()
        {
            return (JobSettings) MemberwiseClone();
        }

        public void Validate()
        {
            if (!IsValidPreOrPostProcessCommand(PreprocessCommand))
                throw new InvalidJobSettings("Preprocess command missing input or output placeholder");

            if (!IsValidPreOrPostProcessCommand(PostprocessCommand))
                throw new InvalidJobSettings("Postprocess command missing input or output placeholder");
        }

        private static bool IsValidPreOrPostProcessCommand(string? command)
        {
            return command is null ||
                Regex.IsMatch(command, "{input}.*{output}",
                    RegexOptions.IgnoreCase | RegexOptions.Multiline
                );
        }
    }

    public class InvalidJobSettings : Exception
    {
        public InvalidJobSettings() { }
        public InvalidJobSettings(string message) : base(message) { }
        public InvalidJobSettings(string message, Exception inner) : base(message, inner) { }
    }
}
