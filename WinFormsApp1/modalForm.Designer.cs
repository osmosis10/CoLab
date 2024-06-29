namespace WinFormsApp1
{
    partial class modalForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modalForm));
            requiredInfo = new Label();
            modalEffect_Timer = new System.Windows.Forms.Timer(components);
            backClick = new Label();
            usernameBox = new TextBox();
            user_panel = new Panel();
            newFolder = new PictureBox();
            confirmButton = new Button();
            panel1 = new Panel();
            enterToken = new TextBox();
            gitIcon = new PictureBox();
            folderNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)newFolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gitIcon).BeginInit();
            SuspendLayout();
            // 
            // requiredInfo
            // 
            requiredInfo.AutoSize = true;
            requiredInfo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            requiredInfo.ForeColor = SystemColors.ButtonHighlight;
            requiredInfo.Location = new Point(157, 9);
            requiredInfo.Name = "requiredInfo";
            requiredInfo.Size = new Size(146, 29);
            requiredInfo.TabIndex = 0;
            requiredInfo.Text = "REQUIRED";
            // 
            // modalEffect_Timer
            // 
            modalEffect_Timer.Tick += modalEffect_Timer_Tick;
            // 
            // backClick
            // 
            backClick.AutoSize = true;
            backClick.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backClick.ForeColor = Color.FromArgb(255, 205, 41);
            backClick.Location = new Point(11, 289);
            backClick.Name = "backClick";
            backClick.Padding = new Padding(6, 7, 6, 7);
            backClick.Size = new Size(56, 32);
            backClick.TabIndex = 3;
            backClick.Text = "back";
            backClick.Click += back_click;
            backClick.MouseLeave += mouseLeave;
            backClick.MouseHover += mouse_hover;
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.Indigo;
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.ForeColor = Color.FromArgb(255, 205, 41);
            usernameBox.Location = new Point(85, 57);
            usernameBox.Margin = new Padding(3, 4, 3, 4);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Enter your username";
            usernameBox.Size = new Size(279, 20);
            usernameBox.TabIndex = 4;
            usernameBox.TextChanged += username_field_change;
            usernameBox.Enter += enter_username;
            // 
            // user_panel
            // 
            user_panel.BackColor = Color.White;
            user_panel.ForeColor = Color.FromArgb(255, 205, 41);
            user_panel.Location = new Point(85, 87);
            user_panel.Margin = new Padding(3, 4, 3, 4);
            user_panel.Name = "user_panel";
            user_panel.Size = new Size(279, 5);
            user_panel.TabIndex = 6;
            // 
            // newFolder
            // 
            newFolder.BackgroundImageLayout = ImageLayout.Stretch;
            newFolder.Image = (Image)resources.GetObject("newFolder.Image");
            newFolder.Location = new Point(197, 174);
            newFolder.Name = "newFolder";
            newFolder.Size = new Size(50, 53);
            newFolder.SizeMode = PictureBoxSizeMode.Zoom;
            newFolder.TabIndex = 8;
            newFolder.TabStop = false;
            newFolder.Click += new_project_click;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.FromArgb(255, 205, 41);
            confirmButton.Cursor = Cursors.Hand;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmButton.Location = new Point(373, 282);
            confirmButton.Margin = new Padding(3, 4, 3, 4);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(77, 33);
            confirmButton.TabIndex = 9;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirm_click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.FromArgb(255, 205, 41);
            panel1.Location = new Point(85, 146);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 5);
            panel1.TabIndex = 11;
            // 
            // enterToken
            // 
            enterToken.BackColor = Color.Indigo;
            enterToken.BorderStyle = BorderStyle.None;
            enterToken.ForeColor = Color.FromArgb(255, 205, 41);
            enterToken.Location = new Point(85, 116);
            enterToken.Margin = new Padding(3, 4, 3, 4);
            enterToken.Name = "enterToken";
            enterToken.PlaceholderText = "Enter Access Token";
            enterToken.Size = new Size(279, 20);
            enterToken.TabIndex = 10;
            enterToken.UseSystemPasswordChar = true;
            enterToken.TextChanged += access_token_box_change;
            // 
            // gitIcon
            // 
            gitIcon.BackgroundImageLayout = ImageLayout.Zoom;
            gitIcon.Image = (Image)resources.GetObject("gitIcon.Image");
            gitIcon.Location = new Point(385, 15);
            gitIcon.Name = "gitIcon";
            gitIcon.Size = new Size(65, 62);
            gitIcon.SizeMode = PictureBoxSizeMode.Zoom;
            gitIcon.TabIndex = 12;
            gitIcon.TabStop = false;
            // 
            // folderNameLabel
            // 
            folderNameLabel.AutoSize = true;
            folderNameLabel.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderNameLabel.ForeColor = Color.FromArgb(255, 205, 41);
            folderNameLabel.Location = new Point(180, 230);
            folderNameLabel.Name = "folderNameLabel";
            folderNameLabel.Size = new Size(91, 16);
            folderNameLabel.TabIndex = 13;
            folderNameLabel.Text = "Choose folder";
            // 
            // modalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(462, 331);
            Controls.Add(folderNameLabel);
            Controls.Add(gitIcon);
            Controls.Add(panel1);
            Controls.Add(enterToken);
            Controls.Add(confirmButton);
            Controls.Add(newFolder);
            Controls.Add(user_panel);
            Controls.Add(usernameBox);
            Controls.Add(backClick);
            Controls.Add(requiredInfo);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "modalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "modalForm";
            Load += modalForm_Load;
            KeyDown += modal_key_down;
            ((System.ComponentModel.ISupportInitialize)newFolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)gitIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label requiredInfo;
        private System.Windows.Forms.Timer modalEffect_Timer;
        private Label backClick;
        private TextBox usernameBox;
        private Panel user_panel;
        private PictureBox newFolder;
        private Button confirmButton;
        private Panel panel1;
        private TextBox enterToken;
        private PictureBox gitIcon;
        private Label folderNameLabel;
    }
}