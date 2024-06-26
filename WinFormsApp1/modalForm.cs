using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class modalForm : Form
    {
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

        // enter_email(): set's color to characters
        private void enter_email(object sender, EventArgs e)
        {
            emailBox.ForeColor = Color.FromArgb(255, 205, 41);
        }

        // email_field_change(): Constantly updates, set's to null if empty
        private void email_field_change(object sender, EventArgs e)
        {
            emailBox.ForeColor = Color.FromArgb(255, 205, 41);
            if (emailBox.Text.Length == 0)
            {
                FolderPathStorage.email = null;
            }
            else
            {
                FolderPathStorage.email = emailBox.Text; // statement to set it null if empty (add it)

            }
        }

        // password_field_change(): Constantly updates, set's to null if empty
        private void password_field_change(object sender, EventArgs e)
        {
            emailBox.ForeColor = Color.FromArgb(255, 205, 41);
            if (passwordBox.Text.Length == 0)
            {
                FolderPathStorage.password = null;
            }
            else
            {
                FolderPathStorage.password = passwordBox.Text; // statement to set it null if empty (add it)

            }
        }

        // mouse_hover(): Set's underline when user hovers over 'back' label
        private void mouse_hover(object sender, EventArgs e)
        {
            backClick.Font = new Font(backClick.Font, FontStyle.Underline);
        }

        // mouseLeave(): Removes underline when user stops hovering over 'back' label
        private void mouseLeave(object sender, EventArgs e)
        {
            backClick.Font = new Font(backClick.Font, FontStyle.Regular);
        }

        // modal_key_down(): handlers for key presses in modal
        private void modal_key_down(object sender, KeyEventArgs e)
        {
            // Upon enter key down launches file browser to
            // to select where project folder will reside
            if (e.KeyCode == Keys.Enter)
            {
                // Check to ensure fields are filled out
                if (FolderPathStorage.email == null || FolderPathStorage.password == null)
                {
                    MessageBox.Show("Please fill required fields");
                    return;
                }

                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.SelectedPath = "C:\\"; // default at C drive
                    folderBrowserDialog.Description = "Choose a home for your project6"; // title

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        FolderPathStorage.ProjectFolderPath = folderBrowserDialog.SelectedPath;
                    }

                }
            }

            // Upon escape key down, modal closes (add animation in the future
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        // (Will be used to create repo from CLI)
        public void create_repo(String email, String password)
        {
            int i = 0;
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
