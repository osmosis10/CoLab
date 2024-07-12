namespace WinFormsApp1
{
    partial class inputRepoLink
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
            commit_back = new Button();
            commit_confirm = new Button();
            cloneTitle = new Label();
            linkBox = new TextBox();
            SuspendLayout();
            // 
            // commit_back
            // 
            commit_back.BackColor = Color.FromArgb(255, 205, 41);
            commit_back.Cursor = Cursors.Hand;
            commit_back.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commit_back.Location = new Point(10, 116);
            commit_back.Name = "commit_back";
            commit_back.Size = new Size(75, 23);
            commit_back.TabIndex = 7;
            commit_back.Text = "Cancel";
            commit_back.UseVisualStyleBackColor = false;
            commit_back.Click += link_back_click;
            // 
            // commit_confirm
            // 
            commit_confirm.BackColor = Color.FromArgb(255, 205, 41);
            commit_confirm.Cursor = Cursors.Hand;
            commit_confirm.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commit_confirm.Location = new Point(145, 116);
            commit_confirm.Name = "commit_confirm";
            commit_confirm.Size = new Size(75, 23);
            commit_confirm.TabIndex = 6;
            commit_confirm.Text = "Confirm";
            commit_confirm.UseVisualStyleBackColor = false;
            commit_confirm.Click += confirm_click;
            // 
            // cloneTitle
            // 
            cloneTitle.AutoSize = true;
            cloneTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cloneTitle.ForeColor = Color.FromArgb(255, 205, 41);
            cloneTitle.Location = new Point(59, 7);
            cloneTitle.Name = "cloneTitle";
            cloneTitle.Size = new Size(109, 15);
            cloneTitle.TabIndex = 5;
            cloneTitle.Text = "Enter repo link !";
            // 
            // linkBox
            // 
            linkBox.Location = new Point(10, 56);
            linkBox.Name = "linkBox";
            linkBox.Size = new Size(210, 23);
            linkBox.TabIndex = 4;
            linkBox.TextChanged += enter_link_box;
            // 
            // inputRepoLink
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(234, 161);
            ControlBox = false;
            Controls.Add(commit_back);
            Controls.Add(commit_confirm);
            Controls.Add(cloneTitle);
            Controls.Add(linkBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "inputRepoLink";
            ShowIcon = false;
            Text = "inputRepoLink";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button commit_back;
        private Button commit_confirm;
        private Label cloneTitle;
        private TextBox linkBox;
    }
}