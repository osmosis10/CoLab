using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class inputRepoLink : Form
    {
        public inputRepoLink()
        {
            InitializeComponent();
        }

        private void enter_link_box(object sender, EventArgs e)
        {
            if (linkBox.Text.Length == 0)
            {
                FolderPathStorage.cloneLink = null;
                return;
            }

            FolderPathStorage.cloneLink = linkBox.Text;
        }

        private void exit_link_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_click(object sender, EventArgs e)
        {
            MessageBox.Show($"Entered: {FolderPathStorage.cloneLink}");
        }

        private void link_load(object sender, EventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(5, 5, this.Width, this.Height, 20, 20);
            this.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }

        private void key_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                gitClone(FolderPathStorage.cloneLink, FolderPathStorage.ProjectFolderPath);
            }
        }

        private void gitClone(String cloneLink, String folderPath)
        {
            MessageBox.Show($"{folderPath}");
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c cd \"{folderPath}\" && git clone {cloneLink}",
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
                    MessageBox.Show($"Clone succesful !");

                }
                // displays error message
                else
                {
                    MessageBox.Show($"Clone failed: {error}");
                }
            }
        }

        private void newFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = "C:\\"; // default at C drive
                folderBrowserDialog.Description = "Choose location for repo"; // title

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    FolderPathStorage.ProjectFolderPath = folderBrowserDialog.SelectedPath;
                    FolderPathStorage.newFolderName = new DirectoryInfo(folderBrowserDialog.SelectedPath).Name;
                    folderNameLabel.Text = FolderPathStorage.newFolderName;
                }

            }
        }
    }
}
