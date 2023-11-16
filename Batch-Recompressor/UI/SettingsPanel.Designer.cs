namespace Batch_Recompressor.UI
{
    partial class SettingsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GroupBox videoCodecGroupLabel;
            Label shrinkFactorLabel;
            Label bitrateModeLabel;
            Label containerLabel;
            GroupBox audioCodecGroupLabel;
            Label audioBitrateLabel;
            Label audioCodecSuffix;
            GroupBox preprocessLabel;
            GroupBox outputFolderGroup;
            shrinkFactorInput = new NumericUpDown();
            videoBitrateModeSelection = new ComboBox();
            twoPassEncodeCheckBox = new CheckBox();
            videoContainerSelection = new ComboBox();
            videoCodecSelection = new ComboBox();
            audioBitrateInput = new NumericUpDown();
            audioCodecSelection = new ComboBox();
            preprocessInput = new ComboBox();
            outputFolderButton = new Button();
            outputFolderInput = new TextBox();
            outputOverwriteLabel = new GroupBox();
            outputOverwriteSelection = new ComboBox();
            postprocessLabel = new GroupBox();
            postprocessInput = new ComboBox();
            customArgumentLabel = new GroupBox();
            customArgumentsInput = new TextBox();
            customArgumentsCheckBox = new CheckBox();
            outputFolderDialog = new FolderBrowserDialog();
            videoCodecGroupLabel = new GroupBox();
            shrinkFactorLabel = new Label();
            bitrateModeLabel = new Label();
            containerLabel = new Label();
            audioCodecGroupLabel = new GroupBox();
            audioBitrateLabel = new Label();
            audioCodecSuffix = new Label();
            preprocessLabel = new GroupBox();
            outputFolderGroup = new GroupBox();
            videoCodecGroupLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shrinkFactorInput).BeginInit();
            audioCodecGroupLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)audioBitrateInput).BeginInit();
            preprocessLabel.SuspendLayout();
            outputFolderGroup.SuspendLayout();
            outputOverwriteLabel.SuspendLayout();
            postprocessLabel.SuspendLayout();
            customArgumentLabel.SuspendLayout();
            SuspendLayout();
            // 
            // videoCodecGroupLabel
            // 
            videoCodecGroupLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            videoCodecGroupLabel.Controls.Add(shrinkFactorLabel);
            videoCodecGroupLabel.Controls.Add(shrinkFactorInput);
            videoCodecGroupLabel.Controls.Add(videoBitrateModeSelection);
            videoCodecGroupLabel.Controls.Add(bitrateModeLabel);
            videoCodecGroupLabel.Controls.Add(twoPassEncodeCheckBox);
            videoCodecGroupLabel.Controls.Add(containerLabel);
            videoCodecGroupLabel.Controls.Add(videoContainerSelection);
            videoCodecGroupLabel.Controls.Add(videoCodecSelection);
            videoCodecGroupLabel.Location = new Point(3, 72);
            videoCodecGroupLabel.Name = "videoCodecGroupLabel";
            videoCodecGroupLabel.Size = new Size(664, 141);
            videoCodecGroupLabel.TabIndex = 0;
            videoCodecGroupLabel.TabStop = false;
            videoCodecGroupLabel.Text = "Video Codec";
            // 
            // shrinkFactorLabel
            // 
            shrinkFactorLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            shrinkFactorLabel.AutoSize = true;
            shrinkFactorLabel.Location = new Point(473, 66);
            shrinkFactorLabel.Name = "shrinkFactorLabel";
            shrinkFactorLabel.Size = new Size(114, 25);
            shrinkFactorLabel.TabIndex = 7;
            shrinkFactorLabel.Text = "Shrink Factor";
            // 
            // shrinkFactorInput
            // 
            shrinkFactorInput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            shrinkFactorInput.DecimalPlaces = 2;
            shrinkFactorInput.Location = new Point(473, 94);
            shrinkFactorInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            shrinkFactorInput.Name = "shrinkFactorInput";
            shrinkFactorInput.Size = new Size(182, 31);
            shrinkFactorInput.TabIndex = 7;
            shrinkFactorInput.TextAlign = HorizontalAlignment.Center;
            shrinkFactorInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // videoBitrateModeSelection
            // 
            videoBitrateModeSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            videoBitrateModeSelection.FormattingEnabled = true;
            videoBitrateModeSelection.Items.AddRange(new object[] { "Average Bitrate", "Quality Bitrate (CRF)" });
            videoBitrateModeSelection.Location = new Point(6, 94);
            videoBitrateModeSelection.Name = "videoBitrateModeSelection";
            videoBitrateModeSelection.Size = new Size(182, 33);
            videoBitrateModeSelection.TabIndex = 6;
            // 
            // bitrateModeLabel
            // 
            bitrateModeLabel.AutoSize = true;
            bitrateModeLabel.Location = new Point(6, 66);
            bitrateModeLabel.Name = "bitrateModeLabel";
            bitrateModeLabel.Size = new Size(114, 25);
            bitrateModeLabel.TabIndex = 4;
            bitrateModeLabel.Text = "Bitrate Mode";
            // 
            // twoPassEncodeCheckBox
            // 
            twoPassEncodeCheckBox.AutoSize = true;
            twoPassEncodeCheckBox.Location = new Point(214, 32);
            twoPassEncodeCheckBox.Name = "twoPassEncodeCheckBox";
            twoPassEncodeCheckBox.Size = new Size(190, 29);
            twoPassEncodeCheckBox.TabIndex = 4;
            twoPassEncodeCheckBox.Text = "Two-Pass Encoding";
            twoPassEncodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // containerLabel
            // 
            containerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            containerLabel.AutoSize = true;
            containerLabel.Location = new Point(473, 2);
            containerLabel.Name = "containerLabel";
            containerLabel.Size = new Size(88, 25);
            containerLabel.TabIndex = 2;
            containerLabel.Text = "Container";
            // 
            // videoContainerSelection
            // 
            videoContainerSelection.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            videoContainerSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            videoContainerSelection.FormattingEnabled = true;
            videoContainerSelection.Items.AddRange(new object[] { "MP4", "WebM", "MKV" });
            videoContainerSelection.Location = new Point(473, 30);
            videoContainerSelection.Name = "videoContainerSelection";
            videoContainerSelection.Size = new Size(182, 33);
            videoContainerSelection.TabIndex = 5;
            // 
            // videoCodecSelection
            // 
            videoCodecSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            videoCodecSelection.FormattingEnabled = true;
            videoCodecSelection.Items.AddRange(new object[] { "AV1 (SVT-AV1)", "VP9", "HEVC (H.265)", "AVC (H.264)" });
            videoCodecSelection.Location = new Point(6, 30);
            videoCodecSelection.Name = "videoCodecSelection";
            videoCodecSelection.Size = new Size(182, 33);
            videoCodecSelection.TabIndex = 3;
            // 
            // audioCodecGroupLabel
            // 
            audioCodecGroupLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            audioCodecGroupLabel.Controls.Add(audioBitrateLabel);
            audioCodecGroupLabel.Controls.Add(audioCodecSuffix);
            audioCodecGroupLabel.Controls.Add(audioBitrateInput);
            audioCodecGroupLabel.Controls.Add(audioCodecSelection);
            audioCodecGroupLabel.Location = new Point(6, 219);
            audioCodecGroupLabel.Name = "audioCodecGroupLabel";
            audioCodecGroupLabel.Size = new Size(664, 74);
            audioCodecGroupLabel.TabIndex = 1;
            audioCodecGroupLabel.TabStop = false;
            audioCodecGroupLabel.Text = "Audio Codec";
            // 
            // audioBitrateLabel
            // 
            audioBitrateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            audioBitrateLabel.AutoSize = true;
            audioBitrateLabel.Location = new Point(473, 0);
            audioBitrateLabel.Name = "audioBitrateLabel";
            audioBitrateLabel.Size = new Size(62, 25);
            audioBitrateLabel.TabIndex = 3;
            audioBitrateLabel.Text = "Bitrate";
            // 
            // audioCodecSuffix
            // 
            audioCodecSuffix.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            audioCodecSuffix.AutoSize = true;
            audioCodecSuffix.Location = new Point(607, 32);
            audioCodecSuffix.Name = "audioCodecSuffix";
            audioCodecSuffix.Size = new Size(52, 25);
            audioCodecSuffix.TabIndex = 2;
            audioCodecSuffix.Text = "Kbps";
            // 
            // audioBitrateInput
            // 
            audioBitrateInput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            audioBitrateInput.Enabled = false;
            audioBitrateInput.Location = new Point(473, 30);
            audioBitrateInput.Maximum = new decimal(new int[] { 510, 0, 0, 0 });
            audioBitrateInput.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            audioBitrateInput.Name = "audioBitrateInput";
            audioBitrateInput.Size = new Size(128, 31);
            audioBitrateInput.TabIndex = 9;
            audioBitrateInput.TextAlign = HorizontalAlignment.Center;
            audioBitrateInput.Value = new decimal(new int[] { 64, 0, 0, 0 });
            // 
            // audioCodecSelection
            // 
            audioCodecSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            audioCodecSelection.FormattingEnabled = true;
            audioCodecSelection.Items.AddRange(new object[] { "Passthrough", "Opus", "AAC" });
            audioCodecSelection.Location = new Point(6, 30);
            audioCodecSelection.Name = "audioCodecSelection";
            audioCodecSelection.Size = new Size(182, 33);
            audioCodecSelection.TabIndex = 8;
            audioCodecSelection.SelectionChangeCommitted += AudioCodec_SelectionChangeCommitted;
            // 
            // preprocessLabel
            // 
            preprocessLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            preprocessLabel.Controls.Add(preprocessInput);
            preprocessLabel.Location = new Point(3, 3);
            preprocessLabel.Name = "preprocessLabel";
            preprocessLabel.Size = new Size(664, 71);
            preprocessLabel.TabIndex = 0;
            preprocessLabel.TabStop = false;
            preprocessLabel.Text = "Preprocess Command";
            // 
            // preprocessInput
            // 
            preprocessInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            preprocessInput.FormattingEnabled = true;
            preprocessInput.Items.AddRange(new object[] { "-i {INPUT_FILE} -map 0 -c copy -bsf:v h264_metadata=video_full_range_flag=0 {OUTPUT_FILE}" });
            preprocessInput.Location = new Point(6, 30);
            preprocessInput.Name = "preprocessInput";
            preprocessInput.Size = new Size(649, 33);
            preprocessInput.TabIndex = 2;
            // 
            // outputFolderGroup
            // 
            outputFolderGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            outputFolderGroup.Controls.Add(outputFolderButton);
            outputFolderGroup.Controls.Add(outputFolderInput);
            outputFolderGroup.Location = new Point(3, 459);
            outputFolderGroup.Name = "outputFolderGroup";
            outputFolderGroup.Size = new Size(458, 75);
            outputFolderGroup.TabIndex = 4;
            outputFolderGroup.TabStop = false;
            outputFolderGroup.Text = "Output Folder";
            // 
            // outputFolderButton
            // 
            outputFolderButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            outputFolderButton.Location = new Point(341, 30);
            outputFolderButton.Name = "outputFolderButton";
            outputFolderButton.Size = new Size(111, 31);
            outputFolderButton.TabIndex = 14;
            outputFolderButton.Text = "Select ";
            outputFolderButton.UseVisualStyleBackColor = true;
            outputFolderButton.Click += OutputFolderButton_Click;
            // 
            // outputFolderInput
            // 
            outputFolderInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            outputFolderInput.Location = new Point(6, 30);
            outputFolderInput.Name = "outputFolderInput";
            outputFolderInput.Size = new Size(329, 31);
            outputFolderInput.TabIndex = 13;
            // 
            // outputOverwriteLabel
            // 
            outputOverwriteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            outputOverwriteLabel.Controls.Add(outputOverwriteSelection);
            outputOverwriteLabel.Location = new Point(467, 459);
            outputOverwriteLabel.Name = "outputOverwriteLabel";
            outputOverwriteLabel.Size = new Size(200, 75);
            outputOverwriteLabel.TabIndex = 5;
            outputOverwriteLabel.TabStop = false;
            outputOverwriteLabel.Text = "Overwrite Condition";
            // 
            // outputOverwriteSelection
            // 
            outputOverwriteSelection.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            outputOverwriteSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            outputOverwriteSelection.FormattingEnabled = true;
            outputOverwriteSelection.Items.AddRange(new object[] { "Do not Overwrite", "If Unexpected Size", "Always Overwrite" });
            outputOverwriteSelection.Location = new Point(9, 30);
            outputOverwriteSelection.Name = "outputOverwriteSelection";
            outputOverwriteSelection.Size = new Size(182, 33);
            outputOverwriteSelection.TabIndex = 15;
            // 
            // postprocessLabel
            // 
            postprocessLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            postprocessLabel.Controls.Add(postprocessInput);
            postprocessLabel.Location = new Point(3, 379);
            postprocessLabel.Name = "postprocessLabel";
            postprocessLabel.RightToLeft = RightToLeft.No;
            postprocessLabel.Size = new Size(664, 74);
            postprocessLabel.TabIndex = 6;
            postprocessLabel.TabStop = false;
            postprocessLabel.Text = "Postprocess Command";
            // 
            // postprocessInput
            // 
            postprocessInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            postprocessInput.FormattingEnabled = true;
            postprocessInput.Location = new Point(6, 30);
            postprocessInput.Name = "postprocessInput";
            postprocessInput.Size = new Size(652, 33);
            postprocessInput.TabIndex = 12;
            // 
            // customArgumentLabel
            // 
            customArgumentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customArgumentLabel.Controls.Add(customArgumentsInput);
            customArgumentLabel.Controls.Add(customArgumentsCheckBox);
            customArgumentLabel.Location = new Point(3, 299);
            customArgumentLabel.Name = "customArgumentLabel";
            customArgumentLabel.RightToLeft = RightToLeft.No;
            customArgumentLabel.Size = new Size(664, 74);
            customArgumentLabel.TabIndex = 3;
            customArgumentLabel.TabStop = false;
            customArgumentLabel.Text = "Custom FFMpeg Arguments";
            // 
            // customArgumentsInput
            // 
            customArgumentsInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customArgumentsInput.Enabled = false;
            customArgumentsInput.Location = new Point(37, 30);
            customArgumentsInput.Name = "customArgumentsInput";
            customArgumentsInput.Size = new Size(621, 31);
            customArgumentsInput.TabIndex = 11;
            customArgumentsInput.Text = "{SETUP_ARGS} {INPUT_ARGS} {VCODEC_ARGS} {ACODEC_ARGS} {OUTPUT_ARGS}";
            // 
            // customArgumentsCheckBox
            // 
            customArgumentsCheckBox.AutoSize = true;
            customArgumentsCheckBox.Location = new Point(9, 34);
            customArgumentsCheckBox.Name = "customArgumentsCheckBox";
            customArgumentsCheckBox.Size = new Size(22, 21);
            customArgumentsCheckBox.TabIndex = 10;
            customArgumentsCheckBox.UseVisualStyleBackColor = true;
            customArgumentsCheckBox.CheckedChanged += AllowCustomArguments_CheckedChanged;
            // 
            // outputFolderDialog
            // 
            outputFolderDialog.RootFolder = Environment.SpecialFolder.MyVideos;
            // 
            // SettingsPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(postprocessLabel);
            Controls.Add(outputOverwriteLabel);
            Controls.Add(outputFolderGroup);
            Controls.Add(customArgumentLabel);
            Controls.Add(preprocessLabel);
            Controls.Add(audioCodecGroupLabel);
            Controls.Add(videoCodecGroupLabel);
            Name = "SettingsPanel";
            Size = new Size(670, 543);
            videoCodecGroupLabel.ResumeLayout(false);
            videoCodecGroupLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shrinkFactorInput).EndInit();
            audioCodecGroupLabel.ResumeLayout(false);
            audioCodecGroupLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)audioBitrateInput).EndInit();
            preprocessLabel.ResumeLayout(false);
            outputFolderGroup.ResumeLayout(false);
            outputFolderGroup.PerformLayout();
            outputOverwriteLabel.ResumeLayout(false);
            postprocessLabel.ResumeLayout(false);
            customArgumentLabel.ResumeLayout(false);
            customArgumentLabel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox videoCodecGroupLabel;
        private ComboBox videoCodecSelection;
        private GroupBox audioCodecGroupLabel;
        private ComboBox audioCodecSelection;
        private ComboBox videoContainerSelection;
        private Label containerLabel;
        private GroupBox preprocessLabel;
        private ComboBox preprocessInput;
        private GroupBox outputFolderLabel;
        private TextBox outputFolderInput;
        private Button outputFolderButton;
        private FolderBrowserDialog outputFolderDialog;
        private NumericUpDown audioBitrateInput;
        private CheckBox twoPassEncodeCheckBox;
        private ComboBox outputOverwriteSelection;
        private ComboBox videoBitrateModeSelection;
        private NumericUpDown shrinkFactorInput;
        private ComboBox postprocessInput;
        private CheckBox customArgumentsCheckBox;
        private TextBox customArgumentsInput;
        private GroupBox customArgumentLabel;
        private GroupBox postprocessLabel;
        private GroupBox outputOverwriteLabel;
    }
}
