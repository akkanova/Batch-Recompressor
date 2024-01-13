using Batch_Recompressor.Core;

namespace Batch_Recompressor.UI
{
    public partial class ExecutablesSelectionForm : Form
    {
        #region Constructor

        public ExecutablesSelectionForm()
        {
            InitializeComponent();
            SetupTextBoxInitialValues();
        }

        private void SetupTextBoxInitialValues()
        {
            ffmpegPathSelectionTextBox.SelectedText = GlobalSettings.Instance.FFMpegExecutablePath;
            ffprobePathSelectionTextBox.SelectedText = GlobalSettings.Instance.FFProbeExecutablePath;
        }

        #endregion

        private void FFMpegPathSelectionButton_Click(object sender, EventArgs e)
        {
            PathFileSelectionCore(ffmpegPathSelectionTextBox);
        }

        private void FFProbePathSelectionButton_Click(object sender, EventArgs e)
        {
            PathFileSelectionCore(ffprobePathSelectionTextBox);
        }

        private void PathFileSelectionCore(TextBoxBase textBox)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.SelectedText = openFileDialog.FileName;
            }
        }
    }
}
