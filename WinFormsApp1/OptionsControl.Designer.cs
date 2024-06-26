namespace WinFormsApp1
{
    partial class OptionsControl
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
            UploadClick = new Button();
            loadChanges = new Button();
            button3 = new Button();
            projectName = new Label();
            projectList = new ListView();
            fileCol = new ColumnHeader();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            changesRadioBox = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            launchProject = new Button();
            changesRadioBox.SuspendLayout();
            SuspendLayout();
            // 
            // UploadClick
            // 
            UploadClick.BackColor = Color.FromArgb(255, 205, 41);
            UploadClick.Cursor = Cursors.Hand;
            UploadClick.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UploadClick.Location = new Point(29, 132);
            UploadClick.Name = "UploadClick";
            UploadClick.Size = new Size(119, 39);
            UploadClick.TabIndex = 0;
            UploadClick.Text = "Upload";
            UploadClick.UseVisualStyleBackColor = false;
            UploadClick.Click += upload_click;
            // 
            // loadChanges
            // 
            loadChanges.BackColor = Color.FromArgb(255, 205, 41);
            loadChanges.Cursor = Cursors.Hand;
            loadChanges.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadChanges.Location = new Point(29, 242);
            loadChanges.Name = "loadChanges";
            loadChanges.Size = new Size(119, 45);
            loadChanges.TabIndex = 1;
            loadChanges.Text = "Download Changes";
            loadChanges.UseVisualStyleBackColor = false;
            loadChanges.Click += download_click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 205, 41);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(29, 361);
            button3.Name = "button3";
            button3.Size = new Size(119, 42);
            button3.TabIndex = 2;
            button3.Text = "Revert state";
            button3.UseVisualStyleBackColor = false;
            // 
            // projectName
            // 
            projectName.AutoSize = true;
            projectName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectName.ForeColor = Color.FromArgb(255, 205, 41);
            projectName.Location = new Point(399, 71);
            projectName.Name = "projectName";
            projectName.Size = new Size(81, 13);
            projectName.TabIndex = 3;
            projectName.Text = "Project name";
            // 
            // projectList
            // 
            projectList.BackColor = Color.FromArgb(79, 3, 78);
            projectList.Columns.AddRange(new ColumnHeader[] { fileCol });
            projectList.Cursor = Cursors.Hand;
            projectList.ForeColor = Color.FromArgb(255, 205, 41);
            projectList.Location = new Point(399, 88);
            projectList.Name = "projectList";
            projectList.Size = new Size(180, 334);
            projectList.TabIndex = 4;
            projectList.UseCompatibleStateImageBehavior = false;
            projectList.View = View.Details;
            projectList.Click += project_list_click;
            // 
            // fileCol
            // 
            fileCol.Text = "Select project";
            fileCol.Width = 175;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.back_button_better;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(83, 19, 122);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(49, 50);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += back_menu_click;
            // 
            // changesRadioBox
            // 
            changesRadioBox.Controls.Add(radioButton1);
            changesRadioBox.Controls.Add(radioButton2);
            changesRadioBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changesRadioBox.ForeColor = Color.FromArgb(255, 205, 41);
            changesRadioBox.Location = new Point(397, 428);
            changesRadioBox.Name = "changesRadioBox";
            changesRadioBox.Size = new Size(200, 100);
            changesRadioBox.TabIndex = 8;
            changesRadioBox.TabStop = false;
            changesRadioBox.Text = "Local change options";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.FromArgb(255, 205, 41);
            radioButton1.Location = new Point(14, 54);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(140, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Stow and Reapply";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += stow_reapply_click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.FromArgb(255, 205, 41);
            radioButton2.Location = new Point(14, 29);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(167, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Discard local changes";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += stash_changes_click;
            // 
            // launchProject
            // 
            launchProject.BackColor = Color.FromArgb(255, 205, 41);
            launchProject.Cursor = Cursors.Hand;
            launchProject.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            launchProject.Location = new Point(212, 558);
            launchProject.Name = "launchProject";
            launchProject.Size = new Size(166, 28);
            launchProject.TabIndex = 9;
            launchProject.Text = "Launch Project";
            launchProject.UseVisualStyleBackColor = false;
            launchProject.Click += launch_project_click;
            // 
            // OptionsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 19, 122);
            Controls.Add(launchProject);
            Controls.Add(changesRadioBox);
            Controls.Add(button1);
            Controls.Add(projectList);
            Controls.Add(projectName);
            Controls.Add(button3);
            Controls.Add(loadChanges);
            Controls.Add(UploadClick);
            Name = "OptionsControl";
            Size = new Size(600, 650);
            changesRadioBox.ResumeLayout(false);
            changesRadioBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UploadClick;
        private Button loadChanges;
        private Button button3;
        private Label projectName;
        private ListView projectList;
        private ColumnHeader fileCol;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox changesRadioBox;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button launchProject;
    }
}
