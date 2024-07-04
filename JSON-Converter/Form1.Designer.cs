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
            saveFileLabel = new Label();
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
            fileNameBox.Enabled = false;
            fileNameBox.Location = new Point(39, 106);
            fileNameBox.Name = "fileNameBox";
            fileNameBox.PlaceholderText = "Choose analytics log file";
            fileNameBox.Size = new Size(429, 27);
            fileNameBox.TabIndex = 1;
            // 
            // generateExcelBtn
            // 
            generateExcelBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            generateExcelBtn.Enabled = false;
            generateExcelBtn.Location = new Point(190, 209);
            generateExcelBtn.Name = "generateExcelBtn";
            generateExcelBtn.Size = new Size(251, 37);
            generateExcelBtn.TabIndex = 2;
            generateExcelBtn.Text = "Generate Excel";
            generateExcelBtn.UseVisualStyleBackColor = true;
            generateExcelBtn.Click += generateExcelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 19);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 3;
            label1.Text = "Code Log Ananlytics Conveter";
            // 
            // saveLink
            // 
            saveLink.AutoSize = true;
            saveLink.Location = new Point(198, 324);
            saveLink.Name = "saveLink";
            saveLink.Size = new Size(243, 20);
            saveLink.TabIndex = 4;
            saveLink.TabStop = true;
            saveLink.Text = "File Genenrated! Click here to save. ";
            saveLink.Visible = false;
            saveLink.LinkClicked += saveLink_LinkClicked;
            // 
            // saveFileLabel
            // 
            saveFileLabel.AutoSize = true;
            saveFileLabel.ForeColor = Color.Blue;
            saveFileLabel.Location = new Point(240, 354);
            saveFileLabel.Name = "saveFileLabel";
            saveFileLabel.Size = new Size(158, 20);
            saveFileLabel.TabIndex = 5;
            saveFileLabel.Text = "File saved successfully!";
            saveFileLabel.Visible = false;
            // 
            // jsonConverter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 450);
            Controls.Add(saveFileLabel);
            Controls.Add(saveLink);
            Controls.Add(label1);
            Controls.Add(generateExcelBtn);
            Controls.Add(fileNameBox);
            Controls.Add(chooseFile);
            Name = "jsonConverter";
            Text = "Log Analytics Converter";
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
        private Label saveFileLabel;
    }
}
