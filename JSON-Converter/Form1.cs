using System.Diagnostics;
using System.Security;
using System.Text.Json;
using OfficeOpenXml;
using System.IO;

namespace JSON_Converter
{
    public partial class jsonConverter : Form
    {


        //This will get the current WORKING directory
        static string projectDir = Path.GetFullPath(@"..\..\..\");

        private string jsonFilePath = Path.Combine(projectDir, "assets/data.json");
        private string templateFilePath = Path.Combine(projectDir, "assets/template.xlsx");
        private string generatedExcelFilePath = Path.Combine(projectDir, "assets/output.xlsx");
        public jsonConverter()
        {
            InitializeComponent();
        }

        // create a new file in the current folder
        private void createFileLocally(string readFilePath, string writeFilePath)
        {
            try
            {
                string fileContent;

                // Read the content of the selected JSON file
                using (StreamReader reader = new StreamReader(readFilePath))
                {
                    fileContent = reader.ReadToEnd();
                }

                // Create a new JSON file in the current directory with new content
                using (StreamWriter writer = new StreamWriter(writeFilePath))
                {
                    writer.Write(fileContent);
                }

            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }
        private void chooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Title = "Select a JSON file",
                InitialDirectory = @"C:\",
                Filter = "JSON files (*.json)|*.json|SARIF files (*.SARIF)|*.SARIF",
                FilterIndex = 2,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    var selectedFilePath = openFileDialog1.FileName;
                    fileNameBox.Text = selectedFilePath;
                    createFileLocally(selectedFilePath, jsonFilePath);
                    generateExcelBtn.Enabled = true;
                }
                else
                {
                    fileNameBox.Text = "No file selected!";
                }
            }
        }

        private void generateExcelBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor; // change cursor to hourglass type
            convertJSONToExcel();
            Cursor = Cursors.Arrow; // change cursor to normal type
            saveLink.Visible = true;
        }

        private void convertJSONToExcel()
        {
            try
            {

                // Reading the JSON file


                var jsonText = File.ReadAllText(jsonFilePath);

                var data = JsonSerializer.Deserialize<Root>(jsonText);

                // Copying template to new file
                if (File.Exists(generatedExcelFilePath))
                {
                    File.SetAttributes(generatedExcelFilePath, FileAttributes.Normal);
                    File.Delete(generatedExcelFilePath);
                }
                File.Copy(templateFilePath, generatedExcelFilePath, true);

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                int start_cell = 2;

                // Load the copied file
                FileInfo outputFile = new FileInfo(generatedExcelFilePath);


                using (ExcelPackage package = new ExcelPackage(outputFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[2]; // Data goes into the third worksheet (Results)

                    foreach (var obj in data.runs[0].results)
                    {

                        string guideline = "";
                        string? severity = obj.properties.severity;
                        string? sourceLocation = obj.locations[0]?.physicalLocation?.artifactLocation?.uri;
                        int? line = obj.locations[0].physicalLocation.region.startLine;
                        string? type = obj.properties.type;
                        string? member = obj.properties.member;
                        string? statement = obj.locations[0]?.physicalLocation?.region?.snippet?.text;
                        string? ruleId = obj.ruleId;
                        string? message = obj.message.text;
                        string guidance_url = "";

                        // Populate the data

                        worksheet.Cells["A" + start_cell.ToString()].Value = guideline;
                        worksheet.Cells["B" + start_cell.ToString()].Value = severity;
                        worksheet.Cells["C" + start_cell.ToString()].Value = sourceLocation;
                        worksheet.Cells["D" + start_cell.ToString()].Value = line;
                        worksheet.Cells["E" + start_cell.ToString()].Value = type;
                        worksheet.Cells["F" + start_cell.ToString()].Value = member;
                        worksheet.Cells["G" + start_cell.ToString()].Value = statement;
                        worksheet.Cells["H" + start_cell.ToString()].Value = ruleId;
                        worksheet.Cells["I" + start_cell.ToString()].Value = message;
                        worksheet.Cells["J" + start_cell.ToString()].Value = guidance_url;

                        start_cell++;

                    }

                    // Save the file
                    package.Save();


                    Console.WriteLine("Excel file populated and saved successfully.");
                }

                Console.WriteLine("Excel file populated and saved successfully.");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access to the path is denied: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An I/O error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder to save the log file.";
                folderBrowserDialog.ShowNewFolderButton = true;

                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    string saveFilePath = Path.Combine(selectedPath, "output.xlsx");
                    File.Copy(generatedExcelFilePath, saveFilePath);
                    saveLink.Visible = false;
                    saveFileLabel.Visible = true;
                    generateExcelBtn.Enabled = false;
                }
            }

        }
    }
}


