using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

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
            //args = new string[1];
            //args[0] = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Visual Studio 2012.lnk";

            if (args.Length > 0)
            {
                string filePath = args[0];

                if (ShortcutHelper.IsShortcut(filePath))
                {
                    string location = ShortcutHelper.ResolveShortcut(filePath);
                    location = Path.GetDirectoryName(location);
                    System.Diagnostics.Process.Start(location);
                }
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
