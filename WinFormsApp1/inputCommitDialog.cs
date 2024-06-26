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

        // commit_key_click(): same behaviour as clicking back button
        private void commit_key_click(object sender, KeyEventArgs e)
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
    }
}
