﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class FolderPathStorage
    {
        public static String ProjectFolderPath { get; set; }
        public static String projectName { get; set; }
        public static String commitMessage { get; set; }
        public static String stemsSourcePath { get; set; }
        public static String stemsDestinationPath { get; set; }

        public static int stashOrDiscard = 0; // 0 by default, 1 for discard and 2 for stash

    }
}
