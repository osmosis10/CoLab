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
            joinProject = new Button();
            exitProject = new Button();
            existingProject = new Button();
            createProject = new Button();
            connection = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)connection).BeginInit();
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
            // joinProject
            // 
            joinProject.BackColor = Color.FromArgb(255, 205, 41);
            joinProject.Cursor = Cursors.Hand;
            joinProject.FlatStyle = FlatStyle.Flat;
            joinProject.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            joinProject.Location = new Point(227, 336);
            joinProject.Margin = new Padding(3, 4, 3, 4);
            joinProject.Name = "joinProject";
            joinProject.Size = new Size(215, 49);
            joinProject.TabIndex = 11;
            joinProject.Text = "Join Project";
            joinProject.UseVisualStyleBackColor = false;
            joinProject.Click += join_project_click;
            // 
            // exitProject
            // 
            exitProject.BackColor = Color.FromArgb(255, 205, 41);
            exitProject.Cursor = Cursors.Hand;
            exitProject.FlatStyle = FlatStyle.Flat;
            exitProject.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitProject.Location = new Point(227, 569);
            exitProject.Margin = new Padding(3, 4, 3, 4);
            exitProject.Name = "exitProject";
            exitProject.Size = new Size(215, 49);
            exitProject.TabIndex = 10;
            exitProject.Text = "Exit";
            exitProject.UseVisualStyleBackColor = false;
            exitProject.Click += exit_click;
            // 
            // existingProject
            // 
            existingProject.BackColor = Color.FromArgb(255, 205, 41);
            existingProject.Cursor = Cursors.Hand;
            existingProject.FlatStyle = FlatStyle.Flat;
            existingProject.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            existingProject.Location = new Point(227, 459);
            existingProject.Margin = new Padding(3, 4, 3, 4);
            existingProject.Name = "existingProject";
            existingProject.Size = new Size(215, 49);
            existingProject.TabIndex = 9;
            existingProject.Text = "Existing Project";
            existingProject.UseVisualStyleBackColor = false;
            existingProject.Click += project_click;
            // 
            // createProject
            // 
            createProject.BackColor = Color.FromArgb(255, 205, 41);
            createProject.Cursor = Cursors.Hand;
            createProject.FlatStyle = FlatStyle.Flat;
            createProject.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createProject.Location = new Point(226, 203);
            createProject.Margin = new Padding(3, 4, 3, 4);
            createProject.Name = "createProject";
            createProject.Size = new Size(215, 49);
            createProject.TabIndex = 8;
            createProject.Text = "Create Project";
            createProject.UseVisualStyleBackColor = false;
            createProject.Click += create_button;
            // 
            // connection
            // 
            connection.BackgroundImageLayout = ImageLayout.Zoom;
            connection.Enabled = false;
            connection.Image = Properties.Resources.no_wifi;
            connection.Location = new Point(582, 12);
            connection.Name = "connection";
            connection.Size = new Size(43, 40);
            connection.SizeMode = PictureBoxSizeMode.Zoom;
            connection.TabIndex = 12;
            connection.TabStop = false;
            // 
            // mainMenuControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 19, 122);
            Controls.Add(connection);
            Controls.Add(joinProject);
            Controls.Add(exitProject);
            Controls.Add(existingProject);
            Controls.Add(createProject);
            Controls.Add(mainTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainMenuControl";
            Size = new Size(686, 867);
            ((System.ComponentModel.ISupportInitialize)connection).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainTitle;
        private Button joinProject;
        private Button exitProject;
        private Button existingProject;
        private Button createProject;
        private PictureBox connection;
    }
}
