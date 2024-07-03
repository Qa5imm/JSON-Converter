namespace JSON_Converter
{
    partial class jsonConverter
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
            chooseFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            fileNameBox = new TextBox();
            downloadExcelBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // chooseFile
            // 
            chooseFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chooseFile.Location = new Point(483, 106);
            chooseFile.Name = "chooseFile";
            chooseFile.Size = new Size(120, 29);
            chooseFile.TabIndex = 0;
            chooseFile.Text = "Choose File";
            chooseFile.TextAlign = ContentAlignment.BottomCenter;
            chooseFile.UseVisualStyleBackColor = true;
            chooseFile.Click += chooseFile_Click;
            // 
            // fileNameBox
            // 
            fileNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileNameBox.Location = new Point(39, 106);
            fileNameBox.Name = "fileNameBox";
            fileNameBox.Size = new Size(429, 27);
            fileNameBox.TabIndex = 1;
            // 
            // downloadExcelBtn
            // 
            downloadExcelBtn.Location = new Point(190, 209);
            downloadExcelBtn.Name = "downloadExcelBtn";
            downloadExcelBtn.Size = new Size(251, 37);
            downloadExcelBtn.TabIndex = 2;
            downloadExcelBtn.Text = "Download Excel";
            downloadExcelBtn.UseVisualStyleBackColor = true;
            downloadExcelBtn.Visible = false;
            downloadExcelBtn.Click += downloadExcelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 27);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 3;
            label1.Text = "JSON TO Excel";
            // 
            // jsonConverter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 450);
            Controls.Add(label1);
            Controls.Add(downloadExcelBtn);
            Controls.Add(fileNameBox);
            Controls.Add(chooseFile);
            Name = "jsonConverter";
            Text = "JSON-Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseFile;
        private OpenFileDialog openFileDialog1;
        private TextBox fileNameBox;
        private Button downloadExcelBtn;
        private Label label1;
    }
}
