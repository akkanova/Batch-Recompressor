using Batch_Recompressor.Core;
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            queueDataGrid = new DataGridView();
            pathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            queueContextMenu = new ContextMenuStrip(components);
            removeToolStripMenuItem = new ToolStripMenuItem();
            progressBarGridViewColumn = new ProgressBarColumn();
            inputSizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            outputSizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jobsBindingSource = new BindingSource(components);
            addFileButton = new Button();
            openFileDialog = new OpenFileDialog();
            settingsPanel = new SettingsPanel();
            startButton = new Button();
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
            queueDataGrid.Columns.AddRange(new DataGridViewColumn[] { pathDataGridViewTextBoxColumn, progressBarGridViewColumn, inputSizeDataGridViewTextBoxColumn, outputSizeDataGridViewTextBoxColumn });
            queueDataGrid.DataSource = jobsBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            queueDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            queueDataGrid.EnableHeadersVisualStyles = false;
            queueDataGrid.Location = new Point(12, 12);
            queueDataGrid.Name = "queueDataGrid";
            queueDataGrid.ReadOnly = true;
            queueDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            queueDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            // progressBarGridViewColumn
            // 
            progressBarGridViewColumn.ContextMenuStrip = queueContextMenu;
            progressBarGridViewColumn.DataPropertyName = "Status";
            progressBarGridViewColumn.FillWeight = 30F;
            progressBarGridViewColumn.HeaderText = "Progress";
            progressBarGridViewColumn.MinimumWidth = 8;
            progressBarGridViewColumn.Name = "progressBarGridViewColumn";
            progressBarGridViewColumn.ReadOnly = true;
            // 
            // inputSizeDataGridViewTextBoxColumn
            // 
            inputSizeDataGridViewTextBoxColumn.ContextMenuStrip = queueContextMenu;
            inputSizeDataGridViewTextBoxColumn.DataPropertyName = "InputFileSize";
            inputSizeDataGridViewTextBoxColumn.FillWeight = 20F;
            inputSizeDataGridViewTextBoxColumn.HeaderText = "Input Size";
            inputSizeDataGridViewTextBoxColumn.MinimumWidth = 8;
            inputSizeDataGridViewTextBoxColumn.Name = "inputSizeDataGridViewTextBoxColumn";
            inputSizeDataGridViewTextBoxColumn.ReadOnly = true;
            inputSizeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // outputSizeDataGridViewTextBoxColumn
            // 
            outputSizeDataGridViewTextBoxColumn.ContextMenuStrip = queueContextMenu;
            outputSizeDataGridViewTextBoxColumn.DataPropertyName = "OutputFileSize";
            outputSizeDataGridViewTextBoxColumn.FillWeight = 20F;
            outputSizeDataGridViewTextBoxColumn.HeaderText = "Output Size";
            outputSizeDataGridViewTextBoxColumn.MinimumWidth = 8;
            outputSizeDataGridViewTextBoxColumn.Name = "outputSizeDataGridViewTextBoxColumn";
            outputSizeDataGridViewTextBoxColumn.ReadOnly = true;
            outputSizeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
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
        private ProgressBarColumn progressBarGridViewColumn;
        private DataGridViewTextBoxColumn inputSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn outputSizeDataGridViewTextBoxColumn;
    }
}