using System;
using System.IO;
using System.Collections.Generic;

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
        }
    }
}
