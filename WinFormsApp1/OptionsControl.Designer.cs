﻿namespace WinFormsApp1
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
            prepareCommit = new Button();
            viewAllCheck = new CheckBox();
            changesRadioBox.SuspendLayout();
            SuspendLayout();
            // 
            // UploadClick
            // 
            UploadClick.BackColor = Color.FromArgb(255, 205, 41);
            UploadClick.Cursor = Cursors.Hand;
            UploadClick.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UploadClick.Location = new Point(35, 273);
            UploadClick.Margin = new Padding(3, 4, 3, 4);
            UploadClick.Name = "UploadClick";
            UploadClick.Size = new Size(136, 56);
            UploadClick.TabIndex = 0;
            UploadClick.Text = "Upload";
            UploadClick.UseVisualStyleBackColor = false;
            UploadClick.Click += upload_click;
            // 
            // loadChanges
            // 
            loadChanges.BackColor = Color.FromArgb(255, 205, 41);
            loadChanges.Cursor = Cursors.Hand;
            loadChanges.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadChanges.Location = new Point(35, 404);
            loadChanges.Margin = new Padding(3, 4, 3, 4);
            loadChanges.Name = "loadChanges";
            loadChanges.Size = new Size(136, 60);
            loadChanges.TabIndex = 1;
            loadChanges.Text = "Download Changes";
            loadChanges.UseVisualStyleBackColor = false;
            loadChanges.Click += download_click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 205, 41);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(35, 552);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(136, 56);
            button3.TabIndex = 2;
            button3.Text = "Revert state";
            button3.UseVisualStyleBackColor = false;
            // 
            // projectName
            // 
            projectName.AutoSize = true;
            projectName.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectName.ForeColor = Color.FromArgb(255, 205, 41);
            projectName.Location = new Point(431, 96);
            projectName.Name = "projectName";
            projectName.Size = new Size(103, 17);
            projectName.TabIndex = 3;
            projectName.Text = "Project name";
            // 
            // projectList
            // 
            projectList.BackColor = Color.FromArgb(79, 3, 78);
            projectList.Columns.AddRange(new ColumnHeader[] { fileCol });
            projectList.Cursor = Cursors.Hand;
            projectList.ForeColor = Color.FromArgb(255, 205, 41);
            projectList.Location = new Point(431, 119);
            projectList.Margin = new Padding(3, 4, 3, 4);
            projectList.Name = "projectList";
            projectList.Size = new Size(205, 444);
            projectList.TabIndex = 4;
            projectList.UseCompatibleStateImageBehavior = false;
            projectList.View = View.Details;
            projectList.Click += project_list_click;
            projectList.DoubleClick += project_list_double_click;
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
            button1.Location = new Point(3, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(64, 67);
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
            changesRadioBox.Location = new Point(419, 571);
            changesRadioBox.Margin = new Padding(3, 4, 3, 4);
            changesRadioBox.Name = "changesRadioBox";
            changesRadioBox.Padding = new Padding(3, 4, 3, 4);
            changesRadioBox.Size = new Size(229, 133);
            changesRadioBox.TabIndex = 8;
            changesRadioBox.TabStop = false;
            changesRadioBox.Text = "Local change options";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.FromArgb(255, 205, 41);
            radioButton1.Location = new Point(16, 72);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(164, 22);
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
            radioButton2.Location = new Point(16, 39);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(196, 22);
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
            launchProject.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            launchProject.Location = new Point(249, 755);
            launchProject.Margin = new Padding(3, 4, 3, 4);
            launchProject.Name = "launchProject";
            launchProject.Size = new Size(190, 37);
            launchProject.TabIndex = 9;
            launchProject.Text = "Launch Project";
            launchProject.UseVisualStyleBackColor = false;
            launchProject.Click += launch_project_click;
            // 
            // prepareCommit
            // 
            prepareCommit.BackColor = Color.FromArgb(255, 205, 41);
            prepareCommit.Cursor = Cursors.Hand;
            prepareCommit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prepareCommit.Location = new Point(35, 133);
            prepareCommit.Margin = new Padding(3, 4, 3, 4);
            prepareCommit.Name = "prepareCommit";
            prepareCommit.Size = new Size(136, 59);
            prepareCommit.TabIndex = 10;
            prepareCommit.Text = "Summarize changes";
            prepareCommit.UseVisualStyleBackColor = false;
            prepareCommit.Click += summarize_changes;
            // 
            // viewAllCheck
            // 
            viewAllCheck.AutoSize = true;
            viewAllCheck.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewAllCheck.ForeColor = Color.FromArgb(255, 205, 41);
            viewAllCheck.Location = new Point(309, 119);
            viewAllCheck.Name = "viewAllCheck";
            viewAllCheck.Size = new Size(116, 20);
            viewAllCheck.TabIndex = 11;
            viewAllCheck.Text = "View all files";
            viewAllCheck.UseVisualStyleBackColor = true;
            viewAllCheck.Click += view_all_files_click;
            // 
            // OptionsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 19, 122);
            Controls.Add(viewAllCheck);
            Controls.Add(prepareCommit);
            Controls.Add(launchProject);
            Controls.Add(changesRadioBox);
            Controls.Add(button1);
            Controls.Add(projectList);
            Controls.Add(projectName);
            Controls.Add(button3);
            Controls.Add(loadChanges);
            Controls.Add(UploadClick);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OptionsControl";
            Size = new Size(686, 867);
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
        private Button prepareCommit;
        private CheckBox viewAllCheck;
    }
}
