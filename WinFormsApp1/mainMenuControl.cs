﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class mainMenuControl : UserControl
    {
        private OptionsControl OptionsControl; // used to open exiting project
        public Form1 MainFormInstance { get; set; } // stores passed instance of main window
        public mainMenuControl()
        {
            InitializeComponent();
        }
        public static int parentX, parentY;
        private void create_project(object sender, EventArgs e)
        {
            Form modalBack = new Form();
            using (modalForm modal = new modalForm())
            {
                modalBack.StartPosition = FormStartPosition.Manual;
                modalBack.FormBorderStyle = FormBorderStyle.None;
                modalBack.Opacity = .50d;
                modalBack.BackColor = Color.Black;
                modalBack.Size = MainFormInstance.Size;
                modalBack.Location = MainFormInstance.Location;
                modalBack.ShowInTaskbar = false;
                modalBack.Show();
                modal.Owner = modalBack;

                parentX = MainFormInstance.Location.X;
                parentY = MainFormInstance.Location.Y;

                // Set the initial position of the modal off-screen 
                modal.StartPosition = FormStartPosition.Manual;
                modal.Top = MainFormInstance.Top - modal.Height + 150; // Start above the main form
                modal.Left = MainFormInstance.Left + (MainFormInstance.Width - modal.Width) / 2;

                // Show the modal before starting the animation
                modal.Shown += (s, args) =>
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 10; // Set time animation
                    timer.Tick += (s2, args2) =>
                    {
                        if (modal.Top < MainFormInstance.Top + 100)
                        {
                            modal.Top += 5; // Move the modal down
                        }
                        else
                        {
                            timer.Stop();
                        }
                    };
                    timer.Start();
                };



                modal.ShowDialog();
                modalBack.Dispose();
            }
        }

        private void project_click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = "C:\\"; // default at C drive
                folderBrowserDialog.Description = "Choose Existing git Repo"; // title

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    FolderPathStorage.ProjectFolderPath = folderBrowserDialog.SelectedPath;
                    RunGitStatus(folderBrowserDialog.SelectedPath);
                }
            }
        }

        private void RunGitStatus(String folderPath)
        {
            ProcessStartInfo ProcessStartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c cd \"{FolderPathStorage.ProjectFolderPath}\" && git status",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,

            };

            // starting the execution
            using (Process process = new Process())
            {
                process.StartInfo = ProcessStartInfo;
                process.Start();

                //Read output

                String output = process.StandardOutput.ReadToEnd();
                String error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                // if the git command worked then window changes to show new options
                if (string.IsNullOrEmpty(error))
                {
                    
                    OptionsControl = new OptionsControl();
                    OptionsControl.Dock = DockStyle.Fill;
                    MainFormInstance.Controls.Clear();
                    MainFormInstance.Controls.Add(OptionsControl);
                    OptionsControl.MainFormInstance = MainFormInstance;

                }
                // displays error 
                else
                {
                    MessageBox.Show($"Error: {folderPath} is not a valid repo");
                }
            }
        }

        private void exit_click(object sender, EventArgs e)
        {
            MainFormInstance.Close();
        }
    }
}
