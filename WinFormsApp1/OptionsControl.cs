using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class OptionsControl : UserControl
    {
        private mainMenuControl mainMenu;
        private Form1 form1;
        public Form1 MainFormInstance { get; set; }
        public OptionsControl()
        {
            InitializeComponent();
            projectName.Text = Path.GetFileName(FolderPathStorage.ProjectFolderPath); // set's label to project file path
            add_file_names(FolderPathStorage.ProjectFolderPath);
            
        }

        private void add_file_names(String folderName)
        {
            if (folderName == null)
            {
                folderName = FolderPathStorage.ProjectFolderPath;
            }

            string[] files = Directory.GetFiles(folderName);
            foreach (string file in files)
            {
                if (file.EndsWith(".flp"))
                {
                    String fileName = Path.GetFileName(file);
                    var listViewItem = new ListViewItem(fileName);
                    fileList.Items.Add(listViewItem);
                }

            }
        }

        private void back_menu_click(object sender, EventArgs e)
        {
            mainMenu = new mainMenuControl();
            Parent.Controls.Remove(this);
            MainFormInstance.Controls.Add(mainMenu);

        }
    }


}
