﻿using System;

namespace Rectify11Installer.Core
{
    public class Variables
    {
        public static string windir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        public static string r11Folder = System.IO.Path.Combine(windir, "Rectify11");
        public static string sys32Folder = Environment.SystemDirectory;
    }
}
