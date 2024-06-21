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
            fileList = new ListView();
            fileCol = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // UploadClick
            // 
            UploadClick.BackColor = Color.FromArgb(255, 205, 41);
            UploadClick.Location = new Point(29, 132);
            UploadClick.Name = "UploadClick";
            UploadClick.Size = new Size(119, 39);
            UploadClick.TabIndex = 0;
            UploadClick.Text = "Upload";
            UploadClick.UseVisualStyleBackColor = false;
            // 
            // loadChanges
            // 
            loadChanges.BackColor = Color.FromArgb(255, 205, 41);
            loadChanges.Location = new Point(29, 242);
            loadChanges.Name = "loadChanges";
            loadChanges.Size = new Size(119, 45);
            loadChanges.TabIndex = 1;
            loadChanges.Text = "Download Changes";
            loadChanges.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 205, 41);
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
            projectName.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectName.ForeColor = Color.FromArgb(255, 205, 41);
            projectName.Location = new Point(399, 71);
            projectName.Name = "projectName";
            projectName.Size = new Size(91, 14);
            projectName.TabIndex = 3;
            projectName.Text = "Project name";
            // 
            // fileList
            // 
            fileList.BackColor = Color.FromArgb(79, 3, 78);
            fileList.Columns.AddRange(new ColumnHeader[] { fileCol });
            fileList.ForeColor = Color.FromArgb(255, 205, 41);
            fileList.Location = new Point(399, 88);
            fileList.Name = "fileList";
            fileList.Size = new Size(180, 334);
            fileList.TabIndex = 4;
            fileList.UseCompatibleStateImageBehavior = false;
            fileList.View = View.Details;
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
            // OptionsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(83, 19, 122);
            Controls.Add(button1);
            Controls.Add(fileList);
            Controls.Add(projectName);
            Controls.Add(button3);
            Controls.Add(loadChanges);
            Controls.Add(UploadClick);
            Cursor = Cursors.Hand;
            Name = "OptionsControl";
            Size = new Size(600, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UploadClick;
        private Button loadChanges;
        private Button button3;
        private Label projectName;
        private ListView fileList;
        private ColumnHeader fileCol;
        private Button button1;
    }
}
