using Batch_Recompressor.Core;
using Batch_Recompressor.UI;
using System.Diagnostics;

namespace Batch_Recompressor
{
    public partial class RecompressForm : Form
    {
        public static List<string> AllowedFileExtensions { get; }

        static RecompressForm()
        {
            AllowedFileExtensions = new() {
                ".3gp", ".adts", ".flac",
                ".mkv", ".mpeg", ".mp4",
                ".ogg", ".mov",  ".webm"
            };
        }


        public RecompressForm()
        {
            InitializeComponent();
            SetupSpecificColumnStyles();
        }

        private void SetupSpecificColumnStyles()
        {
            DataGridViewCellStyle leftAligned = new()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };

            DataGridViewCellStyle rightAligned = new()
            {
                Alignment = DataGridViewContentAlignment.MiddleRight,
                Padding = new Padding(0, 0, 2, 0)
            };

            pathDataGridViewTextBoxColumn.DefaultCellStyle = leftAligned;
            inputSizeDataGridViewTextBoxColumn.DefaultCellStyle = rightAligned;
            outputSizeDataGridViewTextBoxColumn.DefaultCellStyle = rightAligned;
        }

        #region Create FFmpeg Jobs

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                foreach (string filePath in openFileDialog.FileNames)
                {
                    ffmpegJobBindingSource.Add(
                        new RecompressTask(filePath, SettingsPanel.GlobalJobSettings.Clone()));
                }
        }

        private void HandleDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data is null) 
                return;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void HandleDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is null) 
                return;

            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string path in paths)
            {
                string extension = Path.GetExtension(path);
                Debug.WriteLine(extension);

                if (string.IsNullOrEmpty(extension) ||
                    !AllowedFileExtensions.Contains(extension))
                    continue;

                ffmpegJobBindingSource.Add(
                    new RecompressTask(path, SettingsPanel.GlobalJobSettings.Clone()));
            }
        }

        #endregion
        #region Edit FFmpeg Jobs

        private void RemoveSelectedJobs(object sender, EventArgs e)
        {
            if (queueDataGrid.SelectedRows.Count < 1) 
                return;

            DialogResult result = MessageBox.Show(
                "Do you want to also delete the files associated with those Jobs?",
                "Confirmation",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Cancel)
                return;

            foreach (DataGridViewRow row in queueDataGrid.SelectedRows)
            {
                RecompressTask job = (RecompressTask)row.DataBoundItem;
                //if (result == DialogResult.Yes)
                //    job.Delete();

                ffmpegJobBindingSource.Remove(job);
            }
        }

        #endregion
    }
}