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
            generateExcelBtn = new Button();
            label1 = new Label();
            saveLink = new LinkLabel();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // chooseFile
            // 
            chooseFile.Anchor = AnchorStyles.Top;
            chooseFile.Location = new Point(541, 47);
            chooseFile.Name = "chooseFile";
            chooseFile.Size = new Size(135, 29);
            chooseFile.TabIndex = 0;
            chooseFile.Text = "Choose File";
            chooseFile.TextAlign = ContentAlignment.BottomCenter;
            chooseFile.UseVisualStyleBackColor = true;
            chooseFile.Click += chooseFile_Click;
            // 
            // fileNameBox
            // 
            fileNameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fileNameBox.Enabled = false;
            fileNameBox.Location = new Point(23, 49);
            fileNameBox.Name = "fileNameBox";
            fileNameBox.PlaceholderText = "Choose analytics log file";
            fileNameBox.Size = new Size(512, 27);
            fileNameBox.TabIndex = 1;
            // 
            // generateExcelBtn
            // 
            generateExcelBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            generateExcelBtn.Enabled = false;
            generateExcelBtn.Location = new Point(23, 136);
            generateExcelBtn.Name = "generateExcelBtn";
            generateExcelBtn.Size = new Size(174, 29);
            generateExcelBtn.TabIndex = 2;
            generateExcelBtn.Text = "Generate Report";
            generateExcelBtn.UseVisualStyleBackColor = true;
            generateExcelBtn.Click += generateExcelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 3;
            label1.Text = "Select the logs file:";
            // 
            // saveLink
            // 
            saveLink.AutoSize = true;
            saveLink.Location = new Point(292, 140);
            saveLink.Name = "saveLink";
            saveLink.Size = new Size(257, 20);
            saveLink.TabIndex = 4;
            saveLink.TabStop = true;
            saveLink.Text = "Report Generated! Click here to save. ";
            saveLink.Visible = false;
            saveLink.LinkClicked += saveLink_LinkClicked;
            // 
            // jsonConverter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 450);
            Controls.Add(saveLink);
            Controls.Add(label1);
            Controls.Add(generateExcelBtn);
            Controls.Add(fileNameBox);
            Controls.Add(chooseFile);
            Name = "jsonConverter";
            Text = "Code Qualtiy Analytics - Report Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button chooseFile;
        private OpenFileDialog openFileDialog1;
        private TextBox fileNameBox;
        private Button generateExcelBtn;
        private Label label1;
        private LinkLabel saveLink;
        private SaveFileDialog saveFileDialog1;
    }
}
