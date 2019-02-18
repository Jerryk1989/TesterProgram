namespace WindowsFormsApp3
{
    partial class Form1
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
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.testWritingBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartRecordingButton = new System.Windows.Forms.Button();
            this.testWritingButton = new System.Windows.Forms.Button();
            this.stopRecording = new System.Windows.Forms.Button();
            this.LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(197, 69);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FileNameTextBox.TabIndex = 1;
            // 
            // testWritingBox
            // 
            this.testWritingBox.Location = new System.Drawing.Point(197, 104);
            this.testWritingBox.Name = "testWritingBox";
            this.testWritingBox.Size = new System.Drawing.Size(100, 20);
            this.testWritingBox.TabIndex = 2;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(124, 76);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FileNameLabel.TabIndex = 0;
            this.FileNameLabel.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // StartRecordingButton
            // 
            this.StartRecordingButton.Location = new System.Drawing.Point(143, 252);
            this.StartRecordingButton.Name = "StartRecordingButton";
            this.StartRecordingButton.Size = new System.Drawing.Size(164, 33);
            this.StartRecordingButton.TabIndex = 4;
            this.StartRecordingButton.Text = "Start Recording";
            this.StartRecordingButton.UseVisualStyleBackColor = true;
            this.StartRecordingButton.Click += new System.EventHandler(this.StartRecordingButton_Click);
            // 
            // testWritingButton
            // 
            this.testWritingButton.Location = new System.Drawing.Point(143, 177);
            this.testWritingButton.Name = "testWritingButton";
            this.testWritingButton.Size = new System.Drawing.Size(144, 28);
            this.testWritingButton.TabIndex = 5;
            this.testWritingButton.Text = "AddText";
            this.testWritingButton.UseVisualStyleBackColor = true;
            this.testWritingButton.Click += new System.EventHandler(this.testWritingButton_Click);
            // 
            // stopRecording
            // 
            this.stopRecording.Location = new System.Drawing.Point(153, 324);
            this.stopRecording.Name = "stopRecording";
            this.stopRecording.Size = new System.Drawing.Size(144, 28);
            this.stopRecording.TabIndex = 6;
            this.stopRecording.Text = "Finish";
            this.stopRecording.UseVisualStyleBackColor = true;
            this.stopRecording.Click += new System.EventHandler(this.stopRecording_Click);
            // 
            // LoopCheckBox
            // 
            this.LoopCheckBox.AutoSize = true;
            this.LoopCheckBox.Location = new System.Drawing.Point(175, 30);
            this.LoopCheckBox.Name = "LoopCheckBox";
            this.LoopCheckBox.Size = new System.Drawing.Size(76, 17);
            this.LoopCheckBox.TabIndex = 7;
            this.LoopCheckBox.Text = "Loop test?";
            this.LoopCheckBox.UseVisualStyleBackColor = true;
            this.LoopCheckBox.CheckedChanged += new System.EventHandler(this.LoopCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 364);
            this.Controls.Add(this.LoopCheckBox);
            this.Controls.Add(this.stopRecording);
            this.Controls.Add(this.testWritingButton);
            this.Controls.Add(this.StartRecordingButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testWritingBox);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.FileNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.TextBox testWritingBox;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartRecordingButton;
        private System.Windows.Forms.Button testWritingButton;
        private System.Windows.Forms.Button stopRecording;
        private System.Windows.Forms.CheckBox LoopCheckBox;
    }
}

