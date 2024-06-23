using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class OptionsControl : UserControl
    {
        private mainMenuControl mainMenu;
        private Form1 form1;
        public Form1 MainFormInstance { get; set; }
        public OptionsControl()
        {
            InitializeComponent();
            projectName.Text = $"Folder: {Path.GetFileName(FolderPathStorage.ProjectFolderPath)}"; // set's label to project file path
            add_file_names(FolderPathStorage.ProjectFolderPath); // populate list view

        }

        // add's project names to listview
        private void add_file_names(String folderName)
        {
            if (folderName == null)
            {
                folderName = FolderPathStorage.ProjectFolderPath;
            }

            string[] files = Directory.GetFiles(folderName);
            foreach (string file in files)
            {
                if (file.EndsWith(".flp"))
                {
                    String fileName = Path.GetFileName(file);
                    var listViewItem = new ListViewItem(fileName);
                    projectList.Items.Add(listViewItem);
                }

            }
        }

        // returns to main menu (opens new instance of user control
        private void back_menu_click(object sender, EventArgs e)
        {
            mainMenu = new mainMenuControl();
            MainFormInstance.Controls.Remove(this);
            MainFormInstance.Controls.Add(mainMenu);
            mainMenu.MainFormInstance = MainFormInstance;

        }

        // obtain project name after click
        private void project_list_click(object sender, EventArgs e)
        {
            if (projectList.SelectedItems.Count > 0)
            {
                ListViewItem selectedProject = projectList.SelectedItems[0];
                String itemText = selectedProject.Text;
                FolderPathStorage.projectName = selectedProject.Text; // store project name
                //MessageBox.Show($"{FolderPathStorage.projectName}"); test
            }
        }
        // UPLOAD BUTTON
        private void upload_click(object sender, EventArgs e)
        {
            // OCCURS IF PROJECT NAME IS NOT SELECTED
            if (FolderPathStorage.projectName == null)
            {
                MessageBox.Show("Please select your project name from the list");
                return;
            }
            // FILE BROWSER
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = "C:\\"; // default at C drive
                folderBrowserDialog.Description = "Enter the location of your stems folder"; // title

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    FolderPathStorage.stemsSourcePath = folderBrowserDialog.SelectedPath; // STEM SOURCE FOLDER PATH
                    MessageBox.Show($"{FolderPathStorage.stemsSourcePath}");
           
                }

                else
                {
                    return;
                }

            }

            // COMMIT MESSAGE BOX
            if (FolderPathStorage.stemsSourcePath != null)
            {
                using (inputCommitDialog inputCommitDialog = new inputCommitDialog())
                {
                    if (inputCommitDialog.ShowDialog() == DialogResult.OK)
                    {
                        string commitString = FolderPathStorage.commitMessage;
                        MessageBox.Show(commitString);
                    }

                    else { 
                        return;
                    }
                }

                // my path C:\Users\moses\OneDrive\Documents\Image-Line\FL Studio\Audio\Recorded
                FolderPathStorage.stemsDestinationPath = $"{FolderPathStorage.ProjectFolderPath}/stemStorage";
                String stemsSource = FolderPathStorage.stemsSourcePath;
                String stemDest = FolderPathStorage.stemsDestinationPath;

                CopyStems(stemsSource, stemDest); // EXECUTE COPY COMMAND



            }

            
        }


        private void push()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c cd \"{FolderPathStorage.ProjectFolderPath}\" && git push",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,

            };

            // starting the execution
            using (Process process = new Process())
            {
                process.StartInfo = processStartInfo;
                process.Start();

                //Read output

                String output = process.StandardOutput.ReadToEnd();
                String error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                // if the git command worked then display success message
                if (string.IsNullOrEmpty(error))
                {
                    MessageBox.Show($"push succsesful !");

                }
                // displays error message
                else
                {
                    MessageBox.Show($"push failed: {error}");
                }
            }

        }

        // MESSAGE TO ENTER SUMMARY OF CHANGES (git commit)
        private void commit()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c cd \"{FolderPathStorage.ProjectFolderPath}\" && git commit {FolderPathStorage.commitMessage}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,

            };
        }

        private void CopyStems (String sourceDirectory, String destinationDirectory)
        {
            // Aborts copy process if source directory does not exist
            if (!Directory.Exists(sourceDirectory))
            {
                MessageBox.Show("Error: source does not exist ABORT");
            }

               // if destination folder does not exist, it creates it
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            try
            {
                String ext = ".flp";
                String projectName = FolderPathStorage.projectName.Substring(0, FolderPathStorage.projectName.Length - ext.Length);
                MessageBox.Show($"Looking for files that start with {projectName}");

                // Get all files in the source directory that start with the specified prefix
                var filesToCopy = Directory.GetFiles(sourceDirectory, $"{FolderPathStorage.projectName}*");

                foreach (var file in filesToCopy)
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(destinationDirectory, fileName);

                    // Copy the file to the destination directory
                    File.Copy(file, destFile, true); // true to overwrite existing files
                }

                MessageBox.Show("Stem's sucessfully copied !");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Stem transfer failed: {ex.Message}");
            }

            

           
   



        }



    }


}
