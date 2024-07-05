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
            commit_back.Location = new Point(12, 155);
            commit_back.Margin = new Padding(3, 4, 3, 4);
            commit_back.Name = "commit_back";
            commit_back.Size = new Size(86, 31);
            commit_back.TabIndex = 7;
            commit_back.Text = "Cancel";
            commit_back.UseVisualStyleBackColor = false;
            // 
            // commit_confirm
            // 
            commit_confirm.BackColor = Color.FromArgb(255, 205, 41);
            commit_confirm.Cursor = Cursors.Hand;
            commit_confirm.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commit_confirm.Location = new Point(166, 155);
            commit_confirm.Margin = new Padding(3, 4, 3, 4);
            commit_confirm.Name = "commit_confirm";
            commit_confirm.Size = new Size(86, 31);
            commit_confirm.TabIndex = 6;
            commit_confirm.Text = "Confirm";
            commit_confirm.UseVisualStyleBackColor = false;
            // 
            // cloneTitle
            // 
            cloneTitle.AutoSize = true;
            cloneTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cloneTitle.ForeColor = Color.FromArgb(255, 205, 41);
            cloneTitle.Location = new Point(67, 9);
            cloneTitle.Name = "cloneTitle";
            cloneTitle.Size = new Size(127, 18);
            cloneTitle.TabIndex = 5;
            cloneTitle.Text = "Enter repo link !";
            cloneTitle.Click += commitTitle_Click;
            // 
            // linkBox
            // 
            linkBox.Location = new Point(12, 75);
            linkBox.Margin = new Padding(3, 4, 3, 4);
            linkBox.Name = "linkBox";
            linkBox.Size = new Size(239, 27);
            linkBox.TabIndex = 4;
            linkBox.TextChanged += enter_link_box;
            // 
            // inputRepoLink
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(267, 215);
            ControlBox = false;
            Controls.Add(commit_back);
            Controls.Add(commit_confirm);
            Controls.Add(cloneTitle);
            Controls.Add(linkBox);
            FormBorderStyle = FormBorderStyle.None;
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