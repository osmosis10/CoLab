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
         * ***************************************************************************************************************************/

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

        // leave_email(): should set color for placeholder (not functional)
        private void leave_email(object sender, EventArgs e)
        {
            emailBox.ForeColor = Color.FromArgb(255, 205, 41);
        }

        // enter_email(): set's color to characters
        private void enter_email(object sender, EventArgs e)
        {
            emailBox.ForeColor = Color.FromArgb(255, 205, 41);
        }

        // mouse_hover(): Set's underline when user hovers
        private void mouse_hover(object sender, EventArgs e)
        {
            backClick.Font = new Font(backClick.Font, FontStyle.Underline);
        }

        // mouseLeave(): Removes underline when user stops hovering
        private void mouseLeave(object sender, EventArgs e)
        {
            backClick.Font = new Font(backClick.Font, FontStyle.Regular);
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
