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
            createProject = new Button();
            ExistingProject = new Button();
            exitProject = new Button();
            mainTitle = new Label();
            JoinProject = new Button();
            SuspendLayout();
            // 
            // createProject
            // 
            createProject.BackColor = Color.FromArgb(255, 205, 41);
            createProject.Cursor = Cursors.Hand;
            createProject.FlatStyle = FlatStyle.Flat;
            createProject.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createProject.Location = new Point(226, 202);
            createProject.Margin = new Padding(3, 4, 3, 4);
            createProject.Name = "createProject";
            createProject.Size = new Size(215, 49);
            createProject.TabIndex = 0;
            createProject.Text = "Create Project";
            createProject.UseVisualStyleBackColor = false;
            createProject.Click += create_button;
            // 
            // ExistingProject
            // 
            ExistingProject.BackColor = Color.FromArgb(255, 205, 41);
            ExistingProject.Cursor = Cursors.Hand;
            ExistingProject.FlatStyle = FlatStyle.Flat;
            ExistingProject.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExistingProject.Location = new Point(226, 454);
            ExistingProject.Margin = new Padding(3, 4, 3, 4);
            ExistingProject.Name = "ExistingProject";
            ExistingProject.Size = new Size(215, 49);
            ExistingProject.TabIndex = 1;
            ExistingProject.Text = "Existing Project";
            ExistingProject.UseVisualStyleBackColor = false;
            ExistingProject.Click += project_click;
            // 
            // exitProject
            // 
            exitProject.BackColor = Color.FromArgb(255, 205, 41);
            exitProject.Cursor = Cursors.Hand;
            exitProject.FlatStyle = FlatStyle.Flat;
            exitProject.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitProject.Location = new Point(226, 569);
            exitProject.Margin = new Padding(3, 4, 3, 4);
            exitProject.Name = "exitProject";
            exitProject.Size = new Size(215, 49);
            exitProject.TabIndex = 2;
            exitProject.Text = "Exit";
            exitProject.UseVisualStyleBackColor = false;
            exitProject.Click += exit_click;
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
            // JoinProject
            // 
            JoinProject.BackColor = Color.FromArgb(255, 205, 41);
            JoinProject.Cursor = Cursors.Hand;
            JoinProject.FlatStyle = FlatStyle.Flat;
            JoinProject.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JoinProject.Location = new Point(226, 328);
            JoinProject.Margin = new Padding(3, 4, 3, 4);
            JoinProject.Name = "JoinProject";
            JoinProject.Size = new Size(215, 49);
            JoinProject.TabIndex = 4;
            JoinProject.Text = "Join Project";
            JoinProject.UseVisualStyleBackColor = false;
            JoinProject.Click += join_project_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 19, 122);
            ClientSize = new Size(665, 804);
            Controls.Add(JoinProject);
            Controls.Add(mainTitle);
            Controls.Add(exitProject);
            Controls.Add(ExistingProject);
            Controls.Add(createProject);
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

        private Button createProject;
        private Button ExistingProject;
        private Button exitProject;
        private Label mainTitle;
        private Button JoinProject;
    }
}
