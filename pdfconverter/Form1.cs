using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
    
namespace MyWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    pathTextBox.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            string path = pathTextBox.Text;

            if (string.IsNullOrWhiteSpace(path) || !Directory.Exists(path))
            {
                MessageBox.Show("Please enter a valid path.");
                return;
            }

            var shaFiles = Directory.GetFiles(path, "*.sha");

            if (!shaFiles.Any())
            {
                MessageBox.Show("No .sha files found in the specified path.");
                return;
            }

            string outputFilePath = Path.Combine(path, "yk.ibu");

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                // Write the static configuration
                writer.WriteLine("[Settings]");
                writer.WriteLine("Application:=Drawing Editor");
                writer.WriteLine("Error handling:=0");
                writer.WriteLine("Log mode:=1");
                writer.WriteLine("Function To Execute=Save as PDF");
                writer.WriteLine("FileSelectionMode=Individual Files");
                writer.WriteLine($"FileNamesCount={shaFiles.Length}");
                writer.WriteLine("[FileNames]");

                // Write the dynamic file entries
                for (int i = 0; i < shaFiles.Length; i++)
                {
                    writer.WriteLine($"File{i + 1} = {shaFiles[i]}");
                }

                // Write the remaining static configuration
                writer.WriteLine("[Save as PDF]");
                writer.WriteLine("Output folder:=<Same folder as drawing file>");
                writer.WriteLine("Color mode:=0");
                writer.WriteLine("JPG compression level:=2");
                writer.WriteLine("Resolution:=2");
                writer.WriteLine("Create bookmarks=0");
                writer.WriteLine("Custom command to run:=");
            }

            MessageBox.Show("yk.ibu file created successfully.");
        }
    }
}
    