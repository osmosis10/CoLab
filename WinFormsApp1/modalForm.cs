using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class modalForm : Form
    {
        private const string GitHubApiUrl = "https://api.github.com/user/repos";
        private string GitHubUsername = FolderPathStorage.username; // Replace with your GitHub username
        private string GitHubToken = string.Empty; // This will be set after reading the token from the file

        public modalForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

        }


        /******************************************************************************************************************************
         * |CLICK HANDLER'S|
         * ***************************************************************************************************************************/

        // backClick(): closes modal sign in window
        private void back_click(object sender, EventArgs e)
        {
            this.Close();
        }

        // backClick(): closes modal sign in window 
        private void ModalForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        /******************************************************************************************************************************
         * |MODALITY FUNCTIONS|
         ****************************************************************************************************************************/

        // modalForm_Load(): Gives sign in modal rounded corners
        private void modalForm_Load(object sender, EventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(5, 5, this.Width, this.Height, 20, 20);
            this.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }

        // modalEffect_Timer_Tick(): Timer for modal form descent
        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(Form1.parentX + 160, Form1.parentY + 2);
        }


        /******************************************************************************************************************************
         * |HANDLER FUNCTIONS|
         ****************************************************************************************************************************/

        // enter_username(): set's color to characters
        private void enter_username(object sender, EventArgs e)
        {
            usernameBox.ForeColor = Color.FromArgb(255, 205, 41);
        }

        // username_field_change(): Constantly updates, set's to null if empty
        private void username_field_change(object sender, EventArgs e)
        {
            usernameBox.ForeColor = Color.FromArgb(255, 205, 41);
            if (usernameBox.Text.Length == 0)
            {
                FolderPathStorage.username = null;
            }
            else
            {
                FolderPathStorage.username = usernameBox.Text; // statement to set it null if empty (add it)

            }
        }


        // mouse_hover(): Set's underline when user hovers over 'back' label
        private void mouse_hover(object sender, EventArgs e)
        {
            backClick.Font = new Font(backClick.Font, FontStyle.Underline | FontStyle.Bold); // bitwise OR operator to obtain both bold and underline
        }

        // mouseLeave(): Removes underline when user stops hovering over 'back' label
        private void mouseLeave(object sender, EventArgs e)
        {
            backClick.Font = new Font(backClick.Font, FontStyle.Bold);
        }

        // modal_key_down(): handlers for key presses in modal
        private void modal_key_down(object sender, KeyEventArgs e)
        {
            // Upon enter key down launches file browser to
            // to select where project folder will reside
            if (e.KeyCode == Keys.Enter)
            {
                if (FolderPathStorage.username != null || FolderPathStorage.ProjectFolderPath != null || FolderPathStorage.tokenPath != null)
                {
                    try
                    {
                        GitHubToken = ExtractTokenFromPemFile(FolderPathStorage.tokenPath);
                        CreateRepository();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error reading token file: {ex.Message}");
                    }
                }

                else
                {
                    MessageBox.Show("Please complete all fields");
                }
            }

            // Upon escape key down, modal closes (add animation in the future
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void confirm_click(object sender, EventArgs e)
        {

            if (FolderPathStorage.username != null || FolderPathStorage.ProjectFolderPath != null || FolderPathStorage.tokenPath != null)
            {
                try
                {
                    GitHubToken = ExtractTokenFromPemFile(FolderPathStorage.tokenPath);
                    MessageBox.Show($"{FolderPathStorage.username}");
                    CreateRepository();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading token file: {ex.Message}");
                }
            }

            else
            {
                MessageBox.Show("Please complete all fields");
            }
            
        }

        // (Will be used to create repo from CLI)
        private async void CreateRepository()
        {
            string repoName = "test name"; // same name as folder
            string localPath = FolderPathStorage.ProjectFolderPath; // path to the folder

            // Create GitHub repository
            bool repoCreated = await CreateGitHubRepository(repoName);
            if (!repoCreated)
            {
                MessageBox.Show("Failed to create GitHub repository");
                return;
            }

            // Create directory
            Directory.CreateDirectory(localPath);

            // Initialize git repository
            RunCommand("git", "init", localPath);

            // Add remote origin
            string remoteUrl = $"https://github.com/{FolderPathStorage.username}/{repoName}.git";
            RunCommand("git", $"remote add origin {remoteUrl}", localPath);

            // Create a README.md file
            File.WriteAllText(Path.Combine(localPath, "README.md"), "# " + repoName);

            // Add files to staging area
            RunCommand("git", "add .", localPath);

            // Commit files
            RunCommand("git", "commit -m \"Initial commit\"", localPath);

            // Push to GitHub
            RunCommand("git", "push -u origin master", localPath);
        }

        private async Task<bool> CreateGitHubRepository(string repoName)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("AppName", "1.0"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GitHubToken);

                var repository = new
                {
                    name = repoName,
                    description = $"Repo for {repoName} ",
                    @private = true
                };

                var content = new StringContent(JsonConvert.SerializeObject(repository), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(GitHubApiUrl, content);
                
                // Log the response for debugging
                string responseContent = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"{GitHubToken}");
                MessageBox.Show($"Response Status Code: {response.StatusCode}");
                MessageBox.Show($"Response Content: {responseContent}");
                
                return response.IsSuccessStatusCode;
            }
        }

        //  access_token_click(): Obtains github access token
        private void access_token_click(object sender, EventArgs e)
        {
            // Create a new instance of the OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to show only text files
            openFileDialog.Filter = "Discord Token (*.pem)|*.pem";

            // Optionally, you can set the title of the dialog
            openFileDialog.Title = "Select a Text File";

            // Show the dialog and get the result
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // store path
                FolderPathStorage.tokenPath = openFileDialog.FileName;
            }
        }



        // new_project_click(): NEW project destination path
        private void new_project_click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = "C:\\"; // default at C drive
                folderBrowserDialog.Description = "Choose location for repo"; // title

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    FolderPathStorage.ProjectFolderPath = folderBrowserDialog.SelectedPath;
                    FolderPathStorage.newFolderName = new DirectoryInfo(folderBrowserDialog.SelectedPath).Name;
                }

            }
        }


        private string ExtractTokenFromPemFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            StringBuilder tokenBuilder = new StringBuilder();

            foreach (string line in lines)
            {
                if (!line.StartsWith("-----"))
                {
                    tokenBuilder.Append(line.Trim());
                }
            }

            return tokenBuilder.ToString();
        }

        private void RunCommand(string command, string arguments, string workingDirectory)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
                FileName = command,
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = workingDirectory
            };

            using (Process process = new Process())
            {
                process.StartInfo = processStartInfo;
                process.OutputDataReceived += (sender, args) => Console.WriteLine(args.Data);
                process.ErrorDataReceived += (sender, args) => Console.WriteLine(args.Data);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
            }
        }

        
    }

    // class to make round corners for modal form
    public class NativeMethods
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern System.IntPtr CreateRoundRectRgn
         (
          int nLeftRect, // x-coordinate of upper-left corner
          int nTopRect, // y-coordinate of upper-left corner
          int nRightRect, // x-coordinate of lower-right corner
          int nBottomRect, // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
         );

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(System.IntPtr hObject);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    }

    
}
