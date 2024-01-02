using Batch_Recompressor.Core;

namespace Batch_Recompressor.UI
{
    public partial class SettingsPanel : UserControl
    {
        public SettingsPanel()
        {
            InitializeComponent();
            SetupDefaultValues();
        }

        private void SetupDefaultValues()
        {
            videoCodecSelection.SelectedIndex       = 0;
            videoContainerSelection.SelectedIndex   = 0;
            videoBitrateModeSelection.SelectedIndex = 0;
            audioCodecSelection.SelectedIndex       = 0;
            outputOverwriteSelection.SelectedIndex  = 0;
            outputFolderInput.SelectedText = JobSettings.DefaultOutputFolder;
        }

        public JobSettings GetCurrentSettings()
        {
            static string? ConvertToNullIfEmptyOrWhiteSpace(string input) =>
                string.IsNullOrWhiteSpace(input) ? null : input;

            return new JobSettings()
            {
                // Preprocess
                PreprocessCommand = ConvertToNullIfEmptyOrWhiteSpace(preprocessInput.Text),

                // Video Codec Settings
                VideoCodec            = (VideoCodec) videoCodecSelection.SelectedIndex,
                UseTwoPassEncode      = twoPassEncodeCheckBox.Checked,
                Container             = (Container) videoContainerSelection.SelectedIndex,
                UseConstantRateFactor = videoBitrateModeSelection.SelectedIndex != 0,
                ShrinkFactor          = (float) shrinkFactorInput.Value,

                // Audio Codec Settings
                AudioCodec   = (AudioCodec) audioCodecSelection.SelectedIndex,
                AudioBitrate = (uint) audioBitrateInput.Value,

                // Custom Arguments
                CustomArgument = customArgumentsCheckBox.Checked
                    ? ConvertToNullIfEmptyOrWhiteSpace(customArgumentsInput.Text) : null,

                // Output
                OutputFolder = outputFolderInput.Text,

                // Postprocess
                PostprocessCommand = ConvertToNullIfEmptyOrWhiteSpace(postprocessInput.Text),
            };
        }

        private void AudioCodec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            audioBitrateInput.Enabled = audioCodecSelection.SelectedIndex != 0;
        }

        private void CustomArgumentsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            customArgumentsInput.Enabled = customArgumentsCheckBox.Checked;
        }

        private void OutputFolderButton_Click(object sender, EventArgs e)
        {
            if (outputFolderDialog.ShowDialog() == DialogResult.OK)
                outputFolderInput.Text = outputFolderDialog.SelectedPath;
        }
    }
}
