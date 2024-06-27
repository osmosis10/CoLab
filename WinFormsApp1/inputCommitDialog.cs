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
    public partial class inputCommitDialog : Form
    {
        public inputCommitDialog()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent; // launches window in the middle of previous window
        }


        // commit_confirm_click(): obtains update message to be used for push
        private void commit_confirm_click(object sender, EventArgs e)
        {
            FolderPathStorage.commitMessage = this.Controls.OfType<TextBox>().FirstOrDefault()?.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // commit_back_click(): back button to project options menu
        private void commit_back_click(object sender, EventArgs e)
        {
            this.Close();
        }

        // commit_keydown(): same behaviour's as confirm/cancel button's
        private void commit_keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            // same behaviour as clicking confirm button
            if (e.KeyCode == Keys.Enter)
            {
                FolderPathStorage.commitMessage = this.Controls.OfType<TextBox>().FirstOrDefault()?.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void sign_in_load(object sender, EventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(5, 5, this.Width, this.Height, 20, 20);
            this.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }
    }
}
