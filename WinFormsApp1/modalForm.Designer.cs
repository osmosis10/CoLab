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
            accessToken = new PictureBox();
            backClick = new Label();
            usernameBox = new TextBox();
            user_panel = new Panel();
            newFolder = new PictureBox();
            confirmButton = new Button();
            ((System.ComponentModel.ISupportInitialize)accessToken).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newFolder).BeginInit();
            SuspendLayout();
            // 
            // requiredInfo
            // 
            requiredInfo.AutoSize = true;
            requiredInfo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            requiredInfo.ForeColor = SystemColors.ButtonHighlight;
            requiredInfo.Location = new Point(137, 7);
            requiredInfo.Name = "requiredInfo";
            requiredInfo.Size = new Size(115, 24);
            requiredInfo.TabIndex = 0;
            requiredInfo.Text = "REQUIRED";
            // 
            // modalEffect_Timer
            // 
            modalEffect_Timer.Tick += modalEffect_Timer_Tick;
            // 
            // accessToken
            // 
            accessToken.Image = Properties.Resources.github;
            accessToken.Location = new Point(267, 141);
            accessToken.Name = "accessToken";
            accessToken.Size = new Size(51, 40);
            accessToken.SizeMode = PictureBoxSizeMode.Zoom;
            accessToken.TabIndex = 2;
            accessToken.TabStop = false;
            accessToken.Click += access_token_click;
            // 
            // backClick
            // 
            backClick.AutoSize = true;
            backClick.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backClick.ForeColor = Color.FromArgb(255, 205, 41);
            backClick.Location = new Point(10, 217);
            backClick.Name = "backClick";
            backClick.Padding = new Padding(5);
            backClick.Size = new Size(47, 25);
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
            usernameBox.Location = new Point(74, 43);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Enter your username";
            usernameBox.Size = new Size(244, 16);
            usernameBox.TabIndex = 4;
            usernameBox.TextChanged += username_field_change;
            usernameBox.Enter += enter_username;
            // 
            // user_panel
            // 
            user_panel.BackColor = Color.White;
            user_panel.ForeColor = Color.FromArgb(255, 205, 41);
            user_panel.Location = new Point(74, 65);
            user_panel.Name = "user_panel";
            user_panel.Size = new Size(244, 4);
            user_panel.TabIndex = 6;
            // 
            // newFolder
            // 
            newFolder.BackgroundImageLayout = ImageLayout.Stretch;
            newFolder.Image = (Image)resources.GetObject("newFolder.Image");
            newFolder.Location = new Point(74, 141);
            newFolder.Margin = new Padding(3, 2, 3, 2);
            newFolder.Name = "newFolder";
            newFolder.Size = new Size(44, 40);
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
            confirmButton.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmButton.Location = new Point(163, 200);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(67, 25);
            confirmButton.TabIndex = 9;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirm_click;
            // 
            // modalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(404, 248);
            Controls.Add(confirmButton);
            Controls.Add(newFolder);
            Controls.Add(user_panel);
            Controls.Add(usernameBox);
            Controls.Add(backClick);
            Controls.Add(accessToken);
            Controls.Add(requiredInfo);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "modalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "modalForm";
            Load += modalForm_Load;
            KeyDown += modal_key_down;
            ((System.ComponentModel.ISupportInitialize)accessToken).EndInit();
            ((System.ComponentModel.ISupportInitialize)newFolder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label requiredInfo;
        private System.Windows.Forms.Timer modalEffect_Timer;
        private PictureBox accessToken;
        private Label backClick;
        private TextBox usernameBox;
        private Panel user_panel;
        private PictureBox newFolder;
        private Button confirmButton;
    }
}