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
            sign_in_title = new Label();
            modalEffect_Timer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            backClick = new Label();
            emailBox = new TextBox();
            passwordBox = new TextBox();
            user_panel = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sign_in_title
            // 
            sign_in_title.AutoSize = true;
            sign_in_title.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sign_in_title.ForeColor = SystemColors.ButtonHighlight;
            sign_in_title.Location = new Point(177, 12);
            sign_in_title.Name = "sign_in_title";
            sign_in_title.Size = new Size(108, 29);
            sign_in_title.TabIndex = 0;
            sign_in_title.Text = "SIGN IN";
            // 
            // modalEffect_Timer
            // 
            modalEffect_Timer.Tick += modalEffect_Timer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.github;
            pictureBox1.Location = new Point(393, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // backClick
            // 
            backClick.AutoSize = true;
            backClick.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backClick.ForeColor = Color.FromArgb(255, 205, 41);
            backClick.Location = new Point(14, 200);
            backClick.Name = "backClick";
            backClick.Padding = new Padding(6, 7, 6, 7);
            backClick.Size = new Size(56, 32);
            backClick.TabIndex = 3;
            backClick.Text = "back";
            backClick.Click += back_click;
            backClick.MouseLeave += mouseLeave;
            backClick.MouseHover += mouse_hover;
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.Indigo;
            emailBox.BorderStyle = BorderStyle.None;
            emailBox.ForeColor = Color.FromArgb(255, 205, 41);
            emailBox.Location = new Point(85, 71);
            emailBox.Margin = new Padding(3, 4, 3, 4);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "Enter your email";
            emailBox.Size = new Size(279, 20);
            emailBox.TabIndex = 4;
            emailBox.TextChanged += email_field_change;
            emailBox.Enter += enter_email;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.Indigo;
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.ForeColor = Color.FromArgb(255, 205, 41);
            passwordBox.Location = new Point(85, 137);
            passwordBox.Margin = new Padding(3, 4, 3, 4);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Enter Password";
            passwordBox.Size = new Size(279, 20);
            passwordBox.TabIndex = 5;
            passwordBox.UseSystemPasswordChar = true;
            passwordBox.TextChanged += password_field_change;
            // 
            // user_panel
            // 
            user_panel.BackColor = Color.White;
            user_panel.ForeColor = Color.FromArgb(255, 205, 41);
            user_panel.Location = new Point(85, 100);
            user_panel.Margin = new Padding(3, 4, 3, 4);
            user_panel.Name = "user_panel";
            user_panel.Size = new Size(279, 5);
            user_panel.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.FromArgb(255, 205, 41);
            panel1.Location = new Point(85, 167);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 5);
            panel1.TabIndex = 7;
            // 
            // modalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(462, 231);
            Controls.Add(panel1);
            Controls.Add(user_panel);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(backClick);
            Controls.Add(pictureBox1);
            Controls.Add(sign_in_title);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "modalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "modalForm";
            Load += modalForm_Load;
            KeyDown += modal_key_down;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sign_in_title;
        private System.Windows.Forms.Timer modalEffect_Timer;
        private PictureBox pictureBox1;
        private Label backClick;
        private TextBox emailBox;
        private TextBox passwordBox;
        private Panel user_panel;
        private Panel panel1;
    }
}