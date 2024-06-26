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
            button2 = new Button();
            existing_click = new Button();
            createProject = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 205, 41);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(226, 416);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(215, 49);
            button2.TabIndex = 5;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += exit_click;
            // 
            // existing_click
            // 
            existing_click.BackColor = Color.FromArgb(255, 205, 41);
            existing_click.FlatStyle = FlatStyle.Flat;
            existing_click.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            existing_click.Location = new Point(226, 293);
            existing_click.Margin = new Padding(3, 4, 3, 4);
            existing_click.Name = "existing_click";
            existing_click.Size = new Size(215, 49);
            existing_click.TabIndex = 4;
            existing_click.Text = "Existing Project";
            existing_click.UseVisualStyleBackColor = false;
            existing_click.Click += project_click;
            // 
            // createProject
            // 
            createProject.BackColor = Color.FromArgb(255, 205, 41);
            createProject.FlatStyle = FlatStyle.Flat;
            createProject.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createProject.Location = new Point(226, 159);
            createProject.Margin = new Padding(3, 4, 3, 4);
            createProject.Name = "createProject";
            createProject.Size = new Size(215, 49);
            createProject.TabIndex = 3;
            createProject.Text = "Create";
            createProject.UseVisualStyleBackColor = false;
            createProject.Click += create_project;
            // 
            // mainMenuControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 19, 122);
            Controls.Add(button2);
            Controls.Add(existing_click);
            Controls.Add(createProject);
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainMenuControl";
            Size = new Size(686, 867);
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button existing_click;
        private Button createProject;
    }
}
