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
            SuspendLayout();
            // 
            // chooseFile
            // 
            chooseFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chooseFile.Location = new Point(447, 51);
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
            fileNameBox.Location = new Point(12, 51);
            fileNameBox.Name = "fileNameBox";
            fileNameBox.Size = new Size(429, 27);
            fileNameBox.TabIndex = 1;
            // 
            // downloadExcelBtn
            // 
            downloadExcelBtn.Location = new Point(190, 156);
            downloadExcelBtn.Name = "downloadExcelBtn";
            downloadExcelBtn.Size = new Size(251, 37);
            downloadExcelBtn.TabIndex = 2;
            downloadExcelBtn.Text = "Download Excel";
            downloadExcelBtn.UseVisualStyleBackColor = true;
            downloadExcelBtn.Visible = false;
            downloadExcelBtn.Click += downloadExcelBtn_Click;
            // 
            // jsonConverter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 450);
            Controls.Add(downloadExcelBtn);
            Controls.Add(fileNameBox);
            Controls.Add(chooseFile);
            Name = "jsonConverter";
            Text = "JSON-Converter";
            Load += jsonConverter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseFile;
        private OpenFileDialog openFileDialog1;
        private TextBox fileNameBox;
        private Button downloadExcelBtn;
    }
}
