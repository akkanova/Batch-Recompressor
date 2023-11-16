using Batch_Recompressor.Core;

namespace Batch_Recompressor.UI
{
    public partial class SettingsPanel : UserControl
    {
        public static TaskSettings GlobalJobSettings { get; }

        static SettingsPanel()
        {
            GlobalJobSettings = new();
        }

        public SettingsPanel()
        {
            InitializeComponent();
            SetupDefaultValues();
        }

        public void SaveValuesToGlobalSettings()
        {
            static string? ConvertToNullIfEmpty(string input) =>
                string.IsNullOrEmpty(input) ? null : input;

            // Preprocess
            GlobalJobSettings.PreprocessCommand = ConvertToNullIfEmpty(preprocessInput.Text);

            // Video Codec Settings
            GlobalJobSettings.VideoCodec = (VideoCodec)videoCodecSelection.SelectedIndex;
            GlobalJobSettings.ShouldTwoPassEncode = twoPassEncodeCheckBox.Checked;
            GlobalJobSettings.Container = (Container)videoContainerSelection.SelectedIndex;
            GlobalJobSettings.UseConstantRateFactor = videoBitrateModeSelection.SelectedIndex != 0;
            GlobalJobSettings.ShrinkFactor = (float)shrinkFactorInput.Value;

            // Audio Codec Settings
            GlobalJobSettings.AudioBitrate = (uint)audioBitrateInput.Value;

            // Custom Arguments
            GlobalJobSettings.CustomArgument =
                customArgumentsCheckBox.Checked ? ConvertToNullIfEmpty(customArgumentsInput.Text) : null;

            // Output
            GlobalJobSettings.OutputFolder = outputFolderInput.Text;

            // Postprocess
            GlobalJobSettings.PostprocessCommand = ConvertToNullIfEmpty(postprocessInput.Text);
        }

        private void SetupDefaultValues()
        {
            videoCodecSelection.SelectedIndex = 0;
            videoContainerSelection.SelectedIndex = 0;
            videoBitrateModeSelection.SelectedIndex = 0;
            audioCodecSelection.SelectedIndex = 0;
            outputOverwriteSelection.SelectedIndex = 0;
            outputFolderInput.SelectedText = GlobalJobSettings.OutputFolder;
        }

        private void AudioCodec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            audioBitrateInput.Enabled = audioCodecSelection.SelectedIndex != 0;
            GlobalJobSettings.AudioCodec = (AudioCodec)audioCodecSelection.SelectedIndex;
        }

        private void AllowCustomArguments_CheckedChanged(object sender, EventArgs e)
        {
            customArgumentsInput.Enabled = customArgumentsCheckBox.Checked;
        }

        private void OutputFolderButton_Click(object sender, EventArgs e)
        {
            if (outputFolderDialog.ShowDialog() == DialogResult.OK)
            {
                outputFolderInput.Text = outputFolderDialog.SelectedPath;
                GlobalJobSettings.OutputFolder = outputFolderInput.Text;
            }
        }
    }
}
