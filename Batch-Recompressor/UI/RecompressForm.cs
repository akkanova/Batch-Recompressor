using Batch_Recompressor.Core;
using Batch_Recompressor.UI;

namespace Batch_Recompressor
{
    public partial class RecompressForm : Form
    {
        #region Constructor

        private readonly Progress<JobManagerStatus> _jobsManagerProgress;
        private readonly JobsManager _jobsManager;

        public RecompressForm()
        {
            _jobsManager = new();
            _jobsManagerProgress = new(
                (s) => jobsBindingSource.ResetBindings(false)
            );

            InitializeComponent();
            SetupAdditionalComponents();

            var a = new ExecutablesSelectionForm();
            a.ShowDialog(this);
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

        #endregion
        #region Create Recompress Jobs

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
        #region Edit Existing Recompress Jobs

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

                _jobsManager.Start(settings, _jobsManagerProgress);
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