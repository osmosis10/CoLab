using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private OptionsControl OptionsControl;
        public Form1()
        {
            InitializeComponent();
            connetionIconAsync();


        }
        /******************************************************************************************************************************
         * |CLICK HANDLER'S|
         * ***************************************************************************************************************************/
        public static int parentX, parentY; // var's for parent form width/height

        /******************************************************************************************************************************/
        // create_button(): Launches credential modal to be used for creating new project folder
        private void create_button(object sender, EventArgs e)
        {
            showModal();


        }

        /******************************************************************************************************************************/
        // project_click(): Upon selecting valid project folder, takes user to Version controller options
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

        private void join_project_click(object sender, EventArgs e)
        {
            showModalCLone();
        }

        /******************************************************************************************************************************/
        // exit_click(): Closes the application
        private void exit_click(object sender, EventArgs e)
        {
            this.Close();
        }

        /******************************************************************************************************************************
         * |GIT FUNCTIONS|
         * ***************************************************************************************************************************/

        // RunGitStatus(): Run's git status to confirm folder is a repo
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
                    this.Controls.Clear();
                    OptionsControl = new OptionsControl();
                    OptionsControl.Dock = DockStyle.Fill;
                    OptionsControl.MainFormInstance = this; // passes the instance of the main window to user control 
                    this.Controls.Add(OptionsControl);

                }
                // displays error message
                else
                {
                    MessageBox.Show($"Error: {folderPath} is not a valid repo");
                }
            }
        }

        private void showModal()
        {
            Form modalBack = new Form();
            using (modalForm modal = new modalForm())
            {
                modalBack.StartPosition = FormStartPosition.Manual;
                modalBack.FormBorderStyle = FormBorderStyle.None;
                modalBack.Opacity = .50d;
                modalBack.BackColor = Color.Black;
                modalBack.Size = this.Size;
                modalBack.Location = this.Location;
                modalBack.ShowInTaskbar = false;
                modalBack.Show();
                modal.Owner = modalBack;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                // Set the initial position of the modal off-screen 
                modal.StartPosition = FormStartPosition.Manual;
                modal.Top = this.Top - modal.Height + 150; // Start above the main form
                modal.Left = this.Left + (this.Width - modal.Width) / 2;

                // Show the modal before starting the animation
                modal.Shown += (s, args) =>
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 10; // Set time animation
                    timer.Tick += (s2, args2) =>
                    {
                        if (modal.Top < this.Top + 100)
                        {
                            modal.Top += 8; // Move the modal down
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

        private bool checkConnection()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async void connetionIconAsync()
        {
            while (true)
            {
                Image newImage;
                if (checkConnection())
                {
                    newImage = Image.FromFile("C:\\Users\\moses\\Desktop\\versionController\\WinFormsApp1\\Resources\\wifi.png");
                    connection.Image = newImage;
                }
                else
                {
                    newImage = Image.FromFile("C:\\Users\\moses\\Desktop\\versionController\\WinFormsApp1\\Resources\\no-wifi.png");
                    connection.Image = newImage;
                }
                await Task.Delay(3000);
            }
        }

        private void showModalCLone()
        {
            Form modalClone = new Form();
            using (inputRepoLink modal = new inputRepoLink())
            {
                modalClone.StartPosition = FormStartPosition.Manual;
                modalClone.FormBorderStyle = FormBorderStyle.None;
                modalClone.Opacity = .50d;
                modalClone.BackColor = Color.Black;
                modalClone.Size = this.Size;
                modalClone.Location = this.Location;
                modalClone.ShowInTaskbar = false;
                modalClone.Show();
                modal.Owner = modalClone;

                parentX = this.Location.X;
                parentY = this.Location.Y;

                // Set the initial position of the modal off-screen 
                modal.StartPosition = FormStartPosition.Manual;
                modal.Top = this.Top - modal.Height + 150; // Start above the main form
                modal.Left = this.Left + (this.Width - modal.Width) / 2;

                // Show the modal before starting the animation
                modal.Shown += (s, args) =>
                {
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 10; // Set time animation
                    timer.Tick += (s2, args2) =>
                    {
                        if (modal.Top < this.Top + 100)
                        {
                            modal.Top += 8; // Move the modal down
                        }
                        else
                        {
                            timer.Stop();
                        }
                    };
                    timer.Start();
                };



                modal.ShowDialog();
                modalClone.Dispose();
            }
        }
    }
}
