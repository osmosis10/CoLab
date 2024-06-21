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
            back_click = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            user_panel = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sign_in_title
            // 
            sign_in_title.AutoSize = true;
            sign_in_title.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sign_in_title.ForeColor = SystemColors.ButtonHighlight;
            sign_in_title.Location = new Point(155, 9);
            sign_in_title.Name = "sign_in_title";
            sign_in_title.Size = new Size(94, 23);
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
            pictureBox1.Location = new Point(344, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // back_click
            // 
            back_click.AutoSize = true;
            back_click.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back_click.ForeColor = Color.FromArgb(255, 205, 41);
            back_click.Location = new Point(12, 150);
            back_click.Name = "back_click";
            back_click.Size = new Size(35, 14);
            back_click.TabIndex = 3;
            back_click.Text = "back";
            back_click.Click += backClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Indigo;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.FromArgb(255, 205, 41);
            textBox1.Location = new Point(74, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 16);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Indigo;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.FromArgb(255, 205, 41);
            textBox2.Location = new Point(74, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 16);
            textBox2.TabIndex = 5;
            // 
            // user_panel
            // 
            user_panel.BackColor = Color.White;
            user_panel.ForeColor = Color.FromArgb(255, 205, 41);
            user_panel.Location = new Point(74, 75);
            user_panel.Name = "user_panel";
            user_panel.Size = new Size(244, 4);
            user_panel.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.FromArgb(255, 205, 41);
            panel1.Location = new Point(74, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 4);
            panel1.TabIndex = 7;
            // 
            // modalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(404, 173);
            Controls.Add(panel1);
            Controls.Add(user_panel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(back_click);
            Controls.Add(pictureBox1);
            Controls.Add(sign_in_title);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "modalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "modalForm";
            Load += modalForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sign_in_title;
        private System.Windows.Forms.Timer modalEffect_Timer;
        private PictureBox pictureBox1;
        private Label back_click;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel user_panel;
        private Panel panel1;
    }
}