namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CreateButton = new Button();
            existing_click = new Button();
            button2 = new Button();
            mainTitle = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.FromArgb(255, 205, 41);
            CreateButton.Cursor = Cursors.Hand;
            CreateButton.FlatStyle = FlatStyle.Flat;
            CreateButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateButton.Location = new Point(226, 202);
            CreateButton.Margin = new Padding(3, 4, 3, 4);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(215, 49);
            CreateButton.TabIndex = 0;
            CreateButton.Text = "Create Project";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += create_button;
            // 
            // existing_click
            // 
            existing_click.BackColor = Color.FromArgb(255, 205, 41);
            existing_click.Cursor = Cursors.Hand;
            existing_click.FlatStyle = FlatStyle.Flat;
            existing_click.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            existing_click.Location = new Point(226, 454);
            existing_click.Margin = new Padding(3, 4, 3, 4);
            existing_click.Name = "existing_click";
            existing_click.Size = new Size(215, 49);
            existing_click.TabIndex = 1;
            existing_click.Text = "Existing Project";
            existing_click.UseVisualStyleBackColor = false;
            existing_click.Click += project_click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 205, 41);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(226, 569);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(215, 49);
            button2.TabIndex = 2;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += exit_click;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainTitle.ForeColor = Color.FromArgb(255, 205, 41);
            mainTitle.Location = new Point(198, 68);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(280, 38);
            mainTitle.TabIndex = 3;
            mainTitle.Text = "Welcome to Co-Lab !";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 205, 41);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(226, 328);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(215, 49);
            button1.TabIndex = 4;
            button1.Text = "Join Project";
            button1.UseVisualStyleBackColor = false;
            button1.Click += join_project_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 19, 122);
            ClientSize = new Size(665, 804);
            Controls.Add(button1);
            Controls.Add(mainTitle);
            Controls.Add(button2);
            Controls.Add(existing_click);
            Controls.Add(CreateButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(683, 851);
            MinimumSize = new Size(683, 851);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Co-Lab";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateButton;
        private Button existing_click;
        private Button button2;
        private Label mainTitle;
        private Button button1;
    }
}
