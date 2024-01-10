using Batch_Recompressor.UI;

namespace Batch_Recompressor
{
    partial class RecompressForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            queueDataGrid = new DataGridView();
            queueContextMenu = new ContextMenuStrip(components);
            removeToolStripMenuItem = new ToolStripMenuItem();
            jobsBindingSource = new BindingSource(components);
            addFileButton = new Button();
            openFileDialog = new OpenFileDialog();
            settingsPanel = new SettingsPanel();
            startButton = new Button();
            pathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            progressBarColumn = new UI.DataGridColumns.ProgressBarColumn();
            inputFileSizeColumn = new UI.DataGridColumns.FileSizeColumn();
            ouputFileSizeColumn = new UI.DataGridColumns.FileSizeColumn();
            ((System.ComponentModel.ISupportInitialize)queueDataGrid).BeginInit();
            queueContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)jobsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // queueDataGrid
            // 
            queueDataGrid.AllowDrop = true;
            queueDataGrid.AllowUserToAddRows = false;
            queueDataGrid.AllowUserToDeleteRows = false;
            queueDataGrid.AllowUserToOrderColumns = true;
            queueDataGrid.AllowUserToResizeRows = false;
            queueDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            queueDataGrid.AutoGenerateColumns = false;
            queueDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            queueDataGrid.BackgroundColor = SystemColors.ControlLight;
            queueDataGrid.BorderStyle = BorderStyle.Fixed3D;
            queueDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            queueDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            queueDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            queueDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            queueDataGrid.Columns.AddRange(new DataGridViewColumn[] { pathDataGridViewTextBoxColumn, progressBarColumn, inputFileSizeColumn, ouputFileSizeColumn });
            queueDataGrid.DataSource = jobsBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            queueDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            queueDataGrid.EnableHeadersVisualStyles = false;
            queueDataGrid.Location = new Point(12, 12);
            queueDataGrid.Name = "queueDataGrid";
            queueDataGrid.ReadOnly = true;
            queueDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            queueDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            queueDataGrid.RowHeadersVisible = false;
            queueDataGrid.RowHeadersWidth = 62;
            queueDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            queueDataGrid.RowTemplate.Height = 33;
            queueDataGrid.ScrollBars = ScrollBars.Vertical;
            queueDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            queueDataGrid.ShowCellErrors = false;
            queueDataGrid.ShowCellToolTips = false;
            queueDataGrid.ShowEditingIcon = false;
            queueDataGrid.ShowRowErrors = false;
            queueDataGrid.Size = new Size(670, 402);
            queueDataGrid.TabIndex = 0;
            queueDataGrid.DragDrop += HandleDragDrop;
            queueDataGrid.DragEnter += HandleDragEnter;
            // 
            // queueContextMenu
            // 
            queueContextMenu.ImageScalingSize = new Size(24, 24);
            queueContextMenu.Items.AddRange(new ToolStripItem[] { removeToolStripMenuItem });
            queueContextMenu.Name = "contextMenuStrip1";
            queueContextMenu.Size = new Size(149, 36);
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(148, 32);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += RemoveSelectedJobs;
            // 
            // addFileButton
            // 
            addFileButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addFileButton.Location = new Point(12, 420);
            addFileButton.Name = "addFileButton";
            addFileButton.Size = new Size(112, 34);
            addFileButton.TabIndex = 1;
            addFileButton.Text = "Add File";
            addFileButton.UseVisualStyleBackColor = true;
            addFileButton.Click += AddFileButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Video Files|*.3gp;*.adts;*.flac;*.mkv;*.mpeg;*.mp4;*.ogg;*.mov;*.webm";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Select all the video files you want to recompress.";
            // 
            // settingsPanel
            // 
            settingsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            settingsPanel.Location = new Point(12, 460);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(670, 543);
            settingsPanel.TabIndex = 4;
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            startButton.Location = new Point(12, 1018);
            startButton.Name = "startButton";
            startButton.Size = new Size(112, 34);
            startButton.TabIndex = 16;
            startButton.Text = "Start Batch";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            pathDataGridViewTextBoxColumn.ContextMenuStrip = queueContextMenu;
            pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            pathDataGridViewTextBoxColumn.FillWeight = 30F;
            pathDataGridViewTextBoxColumn.HeaderText = "Path";
            pathDataGridViewTextBoxColumn.MinimumWidth = 8;
            pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            pathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // progressBarColumn
            // 
            progressBarColumn.ContextMenuStrip = queueContextMenu;
            progressBarColumn.DataPropertyName = "Status";
            progressBarColumn.FillWeight = 30F;
            progressBarColumn.HeaderText = "Progress";
            progressBarColumn.MinimumWidth = 8;
            progressBarColumn.Name = "progressBarColumn";
            progressBarColumn.ReadOnly = true;
            // 
            // inputFileSizeColumn
            // 
            inputFileSizeColumn.ContextMenuStrip = queueContextMenu;
            inputFileSizeColumn.DataPropertyName = "InputFileSize";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Padding = new Padding(0, 0, 2, 0);
            inputFileSizeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            inputFileSizeColumn.FillWeight = 20F;
            inputFileSizeColumn.HeaderText = "Input Size";
            inputFileSizeColumn.MinimumWidth = 8;
            inputFileSizeColumn.Name = "inputFileSizeColumn";
            inputFileSizeColumn.ReadOnly = true;
            inputFileSizeColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ouputFileSizeColumn
            // 
            ouputFileSizeColumn.ContextMenuStrip = queueContextMenu;
            ouputFileSizeColumn.DataPropertyName = "OutputFileSize";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Padding = new Padding(0, 0, 2, 0);
            ouputFileSizeColumn.DefaultCellStyle = dataGridViewCellStyle3;
            ouputFileSizeColumn.FillWeight = 20F;
            ouputFileSizeColumn.HeaderText = "Output Size";
            ouputFileSizeColumn.MinimumWidth = 8;
            ouputFileSizeColumn.Name = "ouputFileSizeColumn";
            ouputFileSizeColumn.ReadOnly = true;
            ouputFileSizeColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // RecompressForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 1064);
            Controls.Add(startButton);
            Controls.Add(settingsPanel);
            Controls.Add(addFileButton);
            Controls.Add(queueDataGrid);
            Name = "RecompressForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Batch-Recompressor";
            DragDrop += HandleDragDrop;
            DragEnter += HandleDragEnter;
            ((System.ComponentModel.ISupportInitialize)queueDataGrid).EndInit();
            queueContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)jobsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView queueDataGrid;
        private BindingSource jobsBindingSource;
        private Button addFileButton;
        private OpenFileDialog openFileDialog;
        private ContextMenuStrip queueContextMenu;
        private ToolStripMenuItem removeToolStripMenuItem;
        private UI.SettingsPanel settingsPanel;
        private Button startButton;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private UI.DataGridColumns.ProgressBarColumn progressBarColumn;
        private UI.DataGridColumns.FileSizeColumn inputFileSizeColumn;
        private UI.DataGridColumns.FileSizeColumn ouputFileSizeColumn;
    }
}