namespace Batch_Recompressor.UI
{
    partial class ExecutablesSelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ffmpegPathSelectionGroup = new GroupBox();
            ffmpegPathSelectionButton = new Button();
            ffmpegPathSelectionTextBox = new TextBox();
            ffprobePathSelectionButton = new Button();
            ffprobePathSelectionTextBox = new TextBox();
            ffprobePathSelectionGroup = new GroupBox();
            openFileDialog = new OpenFileDialog();
            ffmpegPathSelectionGroup.SuspendLayout();
            ffprobePathSelectionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // ffmpegPathSelectionGroup
            // 
            ffmpegPathSelectionGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ffmpegPathSelectionGroup.Controls.Add(ffmpegPathSelectionButton);
            ffmpegPathSelectionGroup.Controls.Add(ffmpegPathSelectionTextBox);
            ffmpegPathSelectionGroup.Location = new Point(12, 12);
            ffmpegPathSelectionGroup.Name = "ffmpegPathSelectionGroup";
            ffmpegPathSelectionGroup.Size = new Size(614, 79);
            ffmpegPathSelectionGroup.TabIndex = 0;
            ffmpegPathSelectionGroup.TabStop = false;
            ffmpegPathSelectionGroup.Text = "FFMpeg Executable Path";
            // 
            // ffmpegPathSelectionButton
            // 
            ffmpegPathSelectionButton.Location = new Point(496, 30);
            ffmpegPathSelectionButton.Name = "ffmpegPathSelectionButton";
            ffmpegPathSelectionButton.Size = new Size(112, 31);
            ffmpegPathSelectionButton.TabIndex = 1;
            ffmpegPathSelectionButton.Text = "Select";
            ffmpegPathSelectionButton.UseVisualStyleBackColor = true;
            ffmpegPathSelectionButton.Click += FFMpegPathSelectionButton_Click;
            // 
            // ffmpegPathSelectionTextBox
            // 
            ffmpegPathSelectionTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ffmpegPathSelectionTextBox.AutoCompleteSource = AutoCompleteSource.FileSystem;
            ffmpegPathSelectionTextBox.Location = new Point(6, 30);
            ffmpegPathSelectionTextBox.Name = "ffmpegPathSelectionTextBox";
            ffmpegPathSelectionTextBox.Size = new Size(484, 31);
            ffmpegPathSelectionTextBox.TabIndex = 0;
            // 
            // ffprobePathSelectionButton
            // 
            ffprobePathSelectionButton.Location = new Point(496, 30);
            ffprobePathSelectionButton.Name = "ffprobePathSelectionButton";
            ffprobePathSelectionButton.Size = new Size(112, 31);
            ffprobePathSelectionButton.TabIndex = 1;
            ffprobePathSelectionButton.Text = "Select";
            ffprobePathSelectionButton.UseVisualStyleBackColor = true;
            ffprobePathSelectionButton.Click += FFProbePathSelectionButton_Click;
            // 
            // ffprobePathSelectionTextBox
            // 
            ffprobePathSelectionTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ffprobePathSelectionTextBox.AutoCompleteSource = AutoCompleteSource.FileSystem;
            ffprobePathSelectionTextBox.Location = new Point(6, 30);
            ffprobePathSelectionTextBox.Name = "ffprobePathSelectionTextBox";
            ffprobePathSelectionTextBox.Size = new Size(484, 31);
            ffprobePathSelectionTextBox.TabIndex = 0;
            // 
            // ffprobePathSelectionGroup
            // 
            ffprobePathSelectionGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ffprobePathSelectionGroup.Controls.Add(ffprobePathSelectionButton);
            ffprobePathSelectionGroup.Controls.Add(ffprobePathSelectionTextBox);
            ffprobePathSelectionGroup.Location = new Point(12, 97);
            ffprobePathSelectionGroup.Name = "ffprobePathSelectionGroup";
            ffprobePathSelectionGroup.Size = new Size(614, 79);
            ffprobePathSelectionGroup.TabIndex = 3;
            ffprobePathSelectionGroup.TabStop = false;
            ffprobePathSelectionGroup.Text = "FFProbe Executable Path";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.Filter = "Executable (*.exe)|*.exe";
            // 
            // ExecutablesSelectionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 186);
            Controls.Add(ffprobePathSelectionGroup);
            Controls.Add(ffmpegPathSelectionGroup);
            Name = "ExecutablesSelectionForm";
            Text = "Set Paths for Required Executables";
            ffmpegPathSelectionGroup.ResumeLayout(false);
            ffmpegPathSelectionGroup.PerformLayout();
            ffprobePathSelectionGroup.ResumeLayout(false);
            ffprobePathSelectionGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ffmpegPathSelectionGroup;
        private TextBox ffmpegPathSelectionTextBox;
        private Button ffmpegPathSelectionButton;
        private Button button2;
        private Button ffprobePathSelectionButton;
        private TextBox ffprobePathSelectionTextBox;
        private GroupBox ffprobePathSelectionGroup;
        private Button button4;
        private OpenFileDialog openFileDialog;
    }
}