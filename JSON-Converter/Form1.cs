using System.Security;

namespace JSON_Converter
{
    public partial class jsonConverter : Form
    {
        private string newFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.json");
        public jsonConverter()
        {
            InitializeComponent();
        }

        // create a new file in the current folder
        private void createFileLocally(string filePath)
        {
            try
            {
                string fileContent;

                // Read the content of the selected JSON file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    fileContent = reader.ReadToEnd();
                }

                // Create a new JSON file in the current directory with new content
                using (StreamWriter writer = new StreamWriter(newFilePath))
                {
                    writer.Write(fileContent);
                }

                /* MessageBox.Show($"New JSON file created at: {newFilePath}"); */
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
                Filter = "JSON files (*.json)|*.json"

            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    var filePath = openFileDialog1.FileName;
                    fileNameBox.Text = filePath;
                    createFileLocally(filePath);
                    downloadExcelBtn.Visible = true;
                }
                else
                {
                    fileNameBox.Text = "No file selected!";
                }
            }
        }

        private void downloadExcelBtn_Click(object sender, EventArgs e)
        {
            // write json to object logic here
        }
    }
}

