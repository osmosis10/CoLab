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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputRepoLink));
            commit_back = new Button();
            commit_confirm = new Button();
            cloneTitle = new Label();
            linkBox = new TextBox();
            folderNameLabel = new Label();
            newFolder = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)newFolder).BeginInit();
            SuspendLayout();
            // 
            // commit_back
            // 
            commit_back.BackColor = Color.FromArgb(255, 205, 41);
            commit_back.Cursor = Cursors.Hand;
            commit_back.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commit_back.Location = new Point(25, 215);
            commit_back.Margin = new Padding(3, 4, 3, 4);
            commit_back.Name = "commit_back";
            commit_back.Size = new Size(86, 31);
            commit_back.TabIndex = 7;
            commit_back.Text = "Cancel";
            commit_back.UseVisualStyleBackColor = false;
            commit_back.Click += exit_link_click;
            // 
            // commit_confirm
            // 
            commit_confirm.BackColor = Color.FromArgb(255, 205, 41);
            commit_confirm.Cursor = Cursors.Hand;
            commit_confirm.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commit_confirm.Location = new Point(336, 215);
            commit_confirm.Margin = new Padding(3, 4, 3, 4);
            commit_confirm.Name = "commit_confirm";
            commit_confirm.Size = new Size(86, 31);
            commit_confirm.TabIndex = 6;
            commit_confirm.Text = "Confirm";
            commit_confirm.UseVisualStyleBackColor = false;
            commit_confirm.Click += confirm_click;
            // 
            // cloneTitle
            // 
            cloneTitle.AutoSize = true;
            cloneTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            cloneTitle.ForeColor = Color.FromArgb(255, 205, 41);
            cloneTitle.Location = new Point(138, 9);
            cloneTitle.Name = "cloneTitle";
            cloneTitle.Size = new Size(164, 25);
            cloneTitle.TabIndex = 5;
            cloneTitle.Text = "Enter repo link !";
            // 
            // linkBox
            // 
            linkBox.Location = new Point(108, 79);
            linkBox.Margin = new Padding(3, 4, 3, 4);
            linkBox.Name = "linkBox";
            linkBox.Size = new Size(239, 27);
            linkBox.TabIndex = 4;
            linkBox.TextChanged += enter_link_box;
            linkBox.KeyDown += key_enter;
            // 
            // folderNameLabel
            // 
            folderNameLabel.AutoSize = true;
            folderNameLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderNameLabel.ForeColor = Color.FromArgb(255, 205, 41);
            folderNameLabel.Location = new Point(176, 188);
            folderNameLabel.Name = "folderNameLabel";
            folderNameLabel.Size = new Size(96, 16);
            folderNameLabel.TabIndex = 15;
            folderNameLabel.Text = "Choose Folder";
            // 
            // newFolder
            // 
            newFolder.BackgroundImageLayout = ImageLayout.Stretch;
            newFolder.Image = (Image)resources.GetObject("newFolder.Image");
            newFolder.Location = new Point(202, 132);
            newFolder.Name = "newFolder";
            newFolder.Size = new Size(50, 53);
            newFolder.SizeMode = PictureBoxSizeMode.Zoom;
            newFolder.TabIndex = 14;
            newFolder.TabStop = false;
            newFolder.Click += newFolder_Click;
            // 
            // inputRepoLink
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(462, 270);
            ControlBox = false;
            Controls.Add(folderNameLabel);
            Controls.Add(newFolder);
            Controls.Add(commit_back);
            Controls.Add(commit_confirm);
            Controls.Add(cloneTitle);
            Controls.Add(linkBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inputRepoLink";
            ShowIcon = false;
            Text = "inputRepoLink";
            Load += link_load;
            ((System.ComponentModel.ISupportInitialize)newFolder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button commit_back;
        private Button commit_confirm;
        private Label cloneTitle;
        private TextBox linkBox;
        private Label folderNameLabel;
        private PictureBox newFolder;
    }
}