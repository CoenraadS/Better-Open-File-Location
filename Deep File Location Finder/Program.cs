using System;
using System.IO;
using System.Collections.Generic;

namespace Deep_File_Location_Finder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string location = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\GitHub.appref-ms";

                if (ShortcutHelper.IsShortcut(location))
                {
                    location = ShortcutHelper.ResolveShortcut(location);
                    location = Path.GetDirectoryName(location);
                    System.Diagnostics.Process.Start(location);
                }
            }
        }
    }
}
