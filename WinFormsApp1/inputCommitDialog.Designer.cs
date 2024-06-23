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
            // 
            // commitTitle
            // 
            commitTitle.AutoSize = true;
            commitTitle.Location = new Point(48, 9);
            commitTitle.Name = "commitTitle";
            commitTitle.Size = new Size(146, 15);
            commitTitle.TabIndex = 1;
            commitTitle.Text = "Summarize your changes !";
            // 
            // commit_confirm
            // 
            commit_confirm.Location = new Point(147, 115);
            commit_confirm.Name = "commit_confirm";
            commit_confirm.Size = new Size(75, 23);
            commit_confirm.TabIndex = 2;
            commit_confirm.Text = "Confirm";
            commit_confirm.UseVisualStyleBackColor = true;
            commit_confirm.Click += commit_confirm_click;
            // 
            // commit_back
            // 
            commit_back.Location = new Point(12, 115);
            commit_back.Name = "commit_back";
            commit_back.Size = new Size(75, 23);
            commit_back.TabIndex = 3;
            commit_back.Text = "back";
            commit_back.UseVisualStyleBackColor = true;
            commit_back.Click += commit_back_click;
            commit_back.KeyDown += commit_key_click;
            // 
            // inputCommitDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 161);
            Controls.Add(commit_back);
            Controls.Add(commit_confirm);
            Controls.Add(commitTitle);
            Controls.Add(commitBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inputCommitDialog";
            Text = "inputCommitDialog";
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