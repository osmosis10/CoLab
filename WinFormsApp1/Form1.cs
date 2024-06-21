using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private OptionsControl OptionsControl;
        public Form1()
        {
            InitializeComponent();
            
        }

        public static int parentX, parentY;
        private void button1_Click(object sender, EventArgs e)
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

        private void exit_click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
