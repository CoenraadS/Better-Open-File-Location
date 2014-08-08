﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace ClickOnce_Open_File_Location
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            args = new string[1];
            args[0] = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\GitHub.appref-ms";

            if (args.Length > 0)
            {
                string filePath = args[0];

                string location = ShortcutHelper.ResolveShortcut(filePath);

                ProcessStartInfo explorer = new ProcessStartInfo();
                explorer.FileName = ("Explorer.exe");
                explorer.Arguments = (@"/select," + location);

                Process.Start(explorer);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SettingsForm());
            }
        }
    }
}
