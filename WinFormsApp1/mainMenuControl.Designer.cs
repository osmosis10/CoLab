namespace WinFormsApp1
{
    partial class mainMenuControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainTitle = new Label();
            button2 = new Button();
            existing_click = new Button();
            CreateButton = new Button();
            SuspendLayout();
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.Font = new Font("Palatino Linotype", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainTitle.ForeColor = Color.FromArgb(255, 205, 41);
            mainTitle.Location = new Point(198, 68);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(280, 38);
            mainTitle.TabIndex = 7;
            mainTitle.Text = "Welcome to Co-Lab !";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 205, 41);
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(227, 459);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(215, 49);
            button2.TabIndex = 6;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            // 
            // existing_click
            // 
            existing_click.BackColor = Color.FromArgb(255, 205, 41);
            existing_click.Cursor = Cursors.Hand;
            existing_click.FlatStyle = FlatStyle.Flat;
            existing_click.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            existing_click.Location = new Point(227, 336);
            existing_click.Margin = new Padding(3, 4, 3, 4);
            existing_click.Name = "existing_click";
            existing_click.Size = new Size(215, 49);
            existing_click.TabIndex = 5;
            existing_click.Text = "Existing Project";
            existing_click.UseVisualStyleBackColor = false;
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
            CreateButton.TabIndex = 4;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = false;
            // 
            // mainMenuControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 19, 122);
            Controls.Add(mainTitle);
            Controls.Add(button2);
            Controls.Add(existing_click);
            Controls.Add(CreateButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainMenuControl";
            Size = new Size(686, 867);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainTitle;
        private Button button2;
        private Button existing_click;
        private Button CreateButton;
    }
}
