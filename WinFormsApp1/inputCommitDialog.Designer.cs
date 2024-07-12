namespace WinFormsApp1
{
    partial class inputCommitDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            commitBox = new TextBox();
            commitTitle = new Label();
            commit_confirm = new Button();
            commit_back = new Button();
            SuspendLayout();
            // 
            // commitBox
            // 
            commitBox.Location = new Point(12, 55);
            commitBox.Name = "commitBox";
            commitBox.Size = new Size(210, 23);
            commitBox.TabIndex = 0;
            commitBox.KeyDown += commit_keydown;
            // 
            // commitTitle
            // 
            commitTitle.AutoSize = true;
            commitTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commitTitle.ForeColor = Color.FromArgb(255, 205, 41);
            commitTitle.Location = new Point(33, 9);
            commitTitle.Name = "commitTitle";
            commitTitle.Size = new Size(177, 15);
            commitTitle.TabIndex = 1;
            commitTitle.Text = "Summarize your changes !";
            // 
            // commit_confirm
            // 
            commit_confirm.BackColor = Color.FromArgb(255, 205, 41);
            commit_confirm.Cursor = Cursors.Hand;
            commit_confirm.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commit_confirm.Location = new Point(147, 115);
            commit_confirm.Name = "commit_confirm";
            commit_confirm.Size = new Size(75, 23);
            commit_confirm.TabIndex = 2;
            commit_confirm.Text = "Confirm";
            commit_confirm.UseVisualStyleBackColor = false;
            commit_confirm.Click += commit_confirm_click;
            // 
            // commit_back
            // 
            commit_back.BackColor = Color.FromArgb(255, 205, 41);
            commit_back.Cursor = Cursors.Hand;
            commit_back.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commit_back.Location = new Point(12, 115);
            commit_back.Name = "commit_back";
            commit_back.Size = new Size(75, 23);
            commit_back.TabIndex = 3;
            commit_back.Text = "Cancel";
            commit_back.UseVisualStyleBackColor = false;
            commit_back.Click += commit_back_click;
            // 
            // inputCommitDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(234, 161);
            Controls.Add(commit_back);
            Controls.Add(commit_confirm);
            Controls.Add(commitTitle);
            Controls.Add(commitBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inputCommitDialog";
            Text = "inputCommitDialog";
            Load += sign_in_load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox commitBox;
        private Label commitTitle;
        private Button commit_confirm;
        private Button commit_back;
    }
}