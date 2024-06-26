﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************
    Class to store reused data used througout application 
    functions
  *************************************************************/
namespace WinFormsApp1
{
    public static class FolderPathStorage
    {
        public static String ProjectFolderPath { get; set; } // Chosen project folder path
        public static String projectName { get; set; } // Chosen .flp project name
        public static String commitMessage { get; set; } // User update message
        public static String stemsSourcePath { get; set; } // path to FL studio stem folder
        public static String stemsDestinationPath { get; set; } // path
        public static String email {  get; set; } // user email
        public static String password { get; set; } // user password (look into encryption)
        public static int stashOrDiscard = 0; // 0 by default, 1 for discard and 2 for stash

        // Clears class data contents
        public static void Clear()
        {
            ProjectFolderPath = null;
            projectName = null;
            commitMessage = null;
            stemsSourcePath = null;
            stemsDestinationPath = null;
            stashOrDiscard = 0;
        }


    }


}
