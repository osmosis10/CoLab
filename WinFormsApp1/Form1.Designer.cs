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
            CreateButton = new Button();
            existing_click = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.FromArgb(255, 205, 41);
            CreateButton.Cursor = Cursors.Hand;
            CreateButton.FlatStyle = FlatStyle.Flat;
            CreateButton.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateButton.Location = new Point(198, 119);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(188, 37);
            CreateButton.TabIndex = 0;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += create_button;
            // 
            // existing_click
            // 
            existing_click.BackColor = Color.FromArgb(255, 205, 41);
            existing_click.Cursor = Cursors.Hand;
            existing_click.FlatStyle = FlatStyle.Flat;
            existing_click.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            existing_click.Location = new Point(198, 220);
            existing_click.Name = "existing_click";
            existing_click.Size = new Size(188, 37);
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
            button2.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(198, 312);
            button2.Name = "button2";
            button2.Size = new Size(188, 37);
            button2.TabIndex = 2;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += exit_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 19, 122);
            ClientSize = new Size(584, 611);
            Controls.Add(button2);
            Controls.Add(existing_click);
            Controls.Add(CreateButton);
            MaximumSize = new Size(600, 650);
            MinimumSize = new Size(600, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Co-Lab";
            ResumeLayout(false);
        }

        #endregion

        private Button CreateButton;
        private Button existing_click;
        private Button button2;
    }
}
