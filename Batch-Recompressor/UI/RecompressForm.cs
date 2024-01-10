using Batch_Recompressor.Core;

namespace Batch_Recompressor
{
    public partial class RecompressForm : Form
    {
        private readonly JobsManager _jobsManager;

        public RecompressForm()
        {
            _jobsManager = new();

            InitializeComponent();
            SetupAdditionalComponents();
        }

        private void SetupAdditionalComponents()
        {
            // Doing it via the designer causes it to auto-generate columns,
            // even with auto generate columns set to false..
            queueDataGrid.AutoGenerateColumns = false;
            jobsBindingSource.DataSource = _jobsManager;
            jobsBindingSource.DataMember = "Jobs";

            pathDataGridViewTextBoxColumn.DefaultCellStyle = new()
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };
        }

        #region Create FFmpeg Jobs

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _jobsManager.CreateTasks(openFileDialog.FileNames);
                jobsBindingSource.ResetBindings(false);
            }
        }

        private void HandleDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data is not null)
            {
                e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)
                    ? DragDropEffects.All
                    : DragDropEffects.Copy;
            }

        }

        private void HandleDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is not null)
            {
                _jobsManager.CreateTasks((string[])e.Data.GetData(DataFormats.FileDrop, false));
                jobsBindingSource.ResetBindings(false);
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

            // TO DO

            //foreach (DataGridViewRow row in queueDataGrid.SelectedRows)
            //{
            //    RecompressTask job = (RecompressTask)row.DataBoundItem;
            //    //if (result == DialogResult.Yes)
            //    //    job.Delete();

            //    jobsBindingSource.Remove(job);
            //}
        }

        #endregion

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                JobSettings settings = settingsPanel.GetCurrentSettings();
                settings.Validate();

                _jobsManager.Start(settings, new Progress<JobManagerStatus>((s) => jobsBindingSource.ResetBindings(false)
                ));
            }
            catch (InvalidJobSettings exception)
            {
                MessageBox.Show(
                    exception.Message,
                    "Invalid Settings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
            }
        }
    }
}