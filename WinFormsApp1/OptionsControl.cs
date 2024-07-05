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
        /******************************************************************************************************************************
         * |CLICK HANDLER'S|
         * ***************************************************************************************************************************/

        // back_menu_click(): Return user to main menu
        private void back_menu_click(object sender, EventArgs e)
        {
            FolderPathStorage.Clear(); // clears data
            mainMenu = new mainMenuControl();
            MainFormInstance.Controls.Remove(this);
            MainFormInstance.Controls.Add(mainMenu);
            mainMenu.MainFormInstance = MainFormInstance;

        }

        /******************************************************************************************************************************/
        // project_list_click(): Obtain project name on click
        private void project_list_click(object sender, EventArgs e)
        {
            if (projectList.SelectedItems.Count > 0)
            {
                ListViewItem selectedProject = projectList.SelectedItems[0];
                String itemText = selectedProject.Text;
                FolderPathStorage.projectName = selectedProject.Text; // store project name

            }
        }

        /******************************************************************************************************************************/
        // upload_click(): upload's project state to online location
        private void upload_click(object sender, EventArgs e)
        {
            // OCCURS IF PROJECT NAME IS NOT SELECTED
            if (FolderPathStorage.projectName == null)
            {
                MessageBox.Show("Please select your project name from the list");
                return;
            }

            if (FolderPathStorage.commitMessage == null)
            {
                MessageBox.Show("Please create your upload summary");
                return;
            }

            // File browser for FL Studio stem source folder
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

            // Commit message box
            if (FolderPathStorage.stemsSourcePath != null)
            {
                FolderPathStorage.stemsDestinationPath = $"{FolderPathStorage.ProjectFolderPath}/stemStorage";
                String stemsSource = FolderPathStorage.stemsSourcePath;
                String stemDest = FolderPathStorage.stemsDestinationPath;
                CopyStems(stemsSource, stemDest); // Executes copy command
                add();
                commit();
                push();
            }

        }

        /******************************************************************************************************************************/
        // download_click(): download's most recent project state
        private void download_click(object sender, EventArgs e)
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

            // if neither radio button selected
            if (FolderPathStorage.stashOrDiscard == 0)
            {
                MessageBox.Show($"{FolderPathStorage.stashOrDiscard} Please choose to either discard or stash local changes");
                return;
            }

            String command = String.Empty;

            // if stash is chosen
            if (FolderPathStorage.stashOrDiscard == 1)
            {
                stash();
            }

            // if discard is chosen (TBD)
            if (FolderPathStorage.stashOrDiscard == 2)
            {
                command = "clean";
            }

            // reverse order from the upload_click
            FolderPathStorage.stemsDestinationPath = $"{FolderPathStorage.ProjectFolderPath}/stemStorage";
            String stemsSource = FolderPathStorage.stemsDestinationPath;
            String stemDest = FolderPathStorage.stemsSourcePath;
            pull();
            CopyStems(FolderPathStorage.stemsDestinationPath, FolderPathStorage.stemsSourcePath); // copy stems to the source folder
        }

        /******************************************************************************************************************************/
        // launch_project_click(): Button to launch FL project
        private void launch_project_click(object sender, EventArgs e)
        {
            if (FolderPathStorage.projectName == null)
            {
                MessageBox.Show("Please the project from the list");
                return;
            }

            string executablePath = Path.Combine(FolderPathStorage.ProjectFolderPath, FolderPathStorage.projectName);

            if (!File.Exists(executablePath))
            {
                MessageBox.Show($"Executable '{FolderPathStorage.projectName}' not found in folder '{FolderPathStorage.ProjectFolderPath}'");
                return;
            }

            ProcessStartInfo startProcessInfo = new ProcessStartInfo
            {
                FileName = executablePath,
                WorkingDirectory = FolderPathStorage.ProjectFolderPath,
                UseShellExecute = true // Use ShellExecute for direct execution of executable
            };

            try
            {
                Process.Start(startProcessInfo);
                //MessageBox.Show("Application launched successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to launch application: {ex.Message}");
            }
        }

        /******************************************************************************************************************************/
        // stash_changes_click(): Radio button to STASH changes
        private void stash_changes_click(object sender, EventArgs e)
        {
            FolderPathStorage.stashOrDiscard = 1;
        }

        /******************************************************************************************************************************/
        // stow_reapply_click(): Radio button to STOW/REAPPLY changes
        private void stow_reapply_click(object sender, EventArgs e)
        {
            FolderPathStorage.stashOrDiscard = 2;
        }

        /******************************************************************************************************************************
         * GIT FUNCTIONS
         * ***************************************************************************************************************************/

        // push(): Git push
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
                if (process.ExitCode == 0)
                {
                    MessageBox.Show($"push succesful !");

                }
                // displays error message
                else
                {
                    MessageBox.Show($"push failed: {error}");
                }
            }

        }

        /******************************************************************************************************************************/
        // pull(): Git pull
        private void pull()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c cd \"{FolderPathStorage.ProjectFolderPath}\" && git pull",
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
                if (process.ExitCode == 0)
                {
                    MessageBox.Show($"pull succesful !");

                }
                // displays error message
                else
                {
                    MessageBox.Show($"pull failed: {error}");
                }
            }
        }

        /******************************************************************************************************************************/
        // add(): Git add for untracked files
        private void add()
        {

            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c cd \"{FolderPathStorage.ProjectFolderPath}\" && git add *",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                };

                using (Process process = new Process())
                {
                    process.StartInfo = processStartInfo;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        MessageBox.Show($"Files sucessfully added {output}");
                    }
                    else
                    {
                        MessageBox.Show($"Add Command Failed {error}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        /******************************************************************************************************************************/
        // commit(): Git commit -m
        private void commit()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c cd \"{FolderPathStorage.ProjectFolderPath}\" && git commit -m \"{FolderPathStorage.commitMessage}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,

            };

            using (Process process = new Process())
            {
                process.StartInfo = processStartInfo;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    MessageBox.Show($"Commit succesful {output}");
                }
                else
                {
                    MessageBox.Show($"Commit Command Failed {error}");
                }
            }
        }

        /******************************************************************************************************************************/
        // commit(): Git commit -m
        private void stash()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c cd \"{FolderPathStorage.ProjectFolderPath}\" && git stash",
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
                if (process.ExitCode == 0)
                {
                    MessageBox.Show($"stash succesful !");

                }
                // displays error message
                else
                {
                    MessageBox.Show($"stash failed: {error}");
                }
            }
        }
        /******************************************************************************************************************************
         * HELPER FUNCTIONS
         * ***************************************************************************************************************************/

        // add_file_names(): Populate file list view
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

        /******************************************************************************************************************************/
        // CopyStems(): Copy stems from source folder to project folder
        private void CopyStems(String sourceDirectory, String destinationDirectory)
        {
            // Aborts copy process if source directory does not exist
            if (!Directory.Exists(sourceDirectory))
            {
                MessageBox.Show($"Error: source {sourceDirectory} does not exist ABORT");
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
                //MessageBox.Show($"Looking for files that start with {projectName}");

                // Prepare the search pattern based on projectName
                string[] allFiles = Directory.GetFiles(sourceDirectory);

                List<string> filesToCopy = new List<string>();

                foreach (string file in allFiles)
                {
                    string fileName = Path.GetFileName(file);

                    // Check if the file name starts with projectName
                    if (fileName.StartsWith(projectName))
                    {
                        filesToCopy.Add(file); // Add the full file path to the list
                    }
                }

                foreach (var file in filesToCopy)
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(destinationDirectory, fileName);

                    // Copy the file to the destination directory
                    File.Copy(file, destFile, true); // true to overwrite existing files
                }

                MessageBox.Show("Stems successfully copied!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Stem transfer failed: {ex.Message}");
            }

        }

        // summarize_changes(): Adds and commits
        private void summarize_changes(object sender, EventArgs e)
        {
            if (FolderPathStorage.commitMessage == null || FolderPathStorage.commitMessage.Length == 0)
            {
                using (inputCommitDialog inputCommitDialog = new inputCommitDialog())
                {
                    if (inputCommitDialog.ShowDialog() == DialogResult.OK)
                    {
                        string commitString = FolderPathStorage.commitMessage;
                        MessageBox.Show(commitString);

                    }

                    else
                    {
                        return;
                    }
                }
            }

            else
            {
                MessageBox.Show("Summary already created !");
                return;
            }
        }

        private void view_all_files_click(object sender, EventArgs e)
        {
            /*
            if (viewAllCheck.Checked)
            {
                //MessageBox.Show("Box checked");
                string[] files = Directory.GetFiles(FolderPathStorage.ProjectFolderPath);
                foreach (string file in files)
                {
                    String fileName = Path.GetFileName(file);
                    var listViewItem = new ListViewItem(fileName);
                    projectList.Items.Add(listViewItem);
                }
            }

            if (!viewAllCheck.Checked)
            {
                //add_file_names(FolderPathStorage.ProjectFolderPath);
            }
            */
        }
    }
    /******************************************************************************************************************************/
    // my path C:\Users\moses\OneDrive\Documents\Image-Line\FL Studio\Audio\Recorded



}
