﻿using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace Rectify11Installer.Core
{
    public class Installer
    {
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, MoveFileFlags dwFlags);
        [Flags]
        enum MoveFileFlags
        {
            MOVEFILE_REPLACE_EXISTING = 0x00000001,
            MOVEFILE_COPY_ALLOWED = 0x00000002,
            MOVEFILE_DELAY_UNTIL_REBOOT = 0x00000004,
            MOVEFILE_WRITE_THROUGH = 0x00000008,
            MOVEFILE_CREATE_HARDLINK = 0x00000010,
            MOVEFILE_FAIL_IF_NOT_TRACKABLE = 0x00000020
        }
        public static void Install(frmWizard frm)
        {
            // set EulaAccepted value so license dialog doesn't pop up for PsExec
            RegistryKey sysInternalKey = Registry.CurrentUser.OpenSubKey(@"Software\Sysinternals", true);
            if (!sysInternalKey.GetValueNames().Contains("EulaAccepted"))
                sysInternalKey.SetValue("EulaAccepted", 1, RegistryValueKind.DWord);

            if (!File.Exists(Path.Combine(Variables.r11Folder, "PsExec64.exe")))
                File.WriteAllBytes(Path.Combine(Variables.r11Folder, "PsExec64.exe"), Properties.Resources.PsExec64);

            if (!Directory.Exists(Path.Combine(Variables.r11Folder, "Backup")))
                Directory.CreateDirectory(Path.Combine(Variables.r11Folder, "Backup"));

            // Get all patches
            Patches patches = PatchesParser.GetAll();
            PatchesPatch[] ok = patches.Items;
            foreach (PatchesPatch patch in ok)
            {
                foreach (string items in InstallOptions.iconsList)
                {
                    if (items == Path.GetFileName(patch.HardlinkTarget))
                    {
                        
                    }
                }
            }

        }
        private static void TakeFullOwnership(string file)
        {
            Interaction.Shell(Path.Combine(Variables.sys32Folder, "takeown.exe") + " /F " + file, AppWinStyle.Hide, true, -1);
            Interaction.Shell(Path.Combine(Variables.sys32Folder, "icacls.exe") + " " + file + " /grant Users:(F)", AppWinStyle.Hide, true, -1);
            Interaction.Shell(Path.Combine(Variables.sys32Folder, "icacls.exe") + " " + file + " /grant Administrators:(F)", AppWinStyle.Hide, true, -1);
        }
    }
}
