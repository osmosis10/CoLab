using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            //this.KeyDown += new KeyEventHandler(ModalForm_KeyDown);

        }

        int i;
        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(Form1.parentX + 160, Form1.parentY + 2);

        }



        private void backClick(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
        private void ModalForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        */
        private void modalForm_Load(object sender, EventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(5, 5, this.Width, this.Height, 25, 25);
            this.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);

        }
    }

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
