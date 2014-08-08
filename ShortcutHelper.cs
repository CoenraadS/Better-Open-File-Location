using System;
using System.IO;
using IWshRuntimeLibrary;

namespace Better_Open_File_Location
{
    public static class ShortcutHelper
    {

        public static string ResolveShortcut(string path)
        {
            /* While the Shell32 method also works for .lnk files, it requires Admin rights in some cases.
             * WshShell achieves the same without admin rights, hence this check */
            if (Path.GetExtension(path).Equals(".lnk", StringComparison.OrdinalIgnoreCase))
            {
                WshShell shell = new WshShell(); //Create a new WshShell Interface
                /*Link the interface to our shortcut because we don't want the shortcuts
                  location, but the actual programs location*/
                IWshShortcut link = (IWshShortcut)shell.CreateShortcut(path);
                if (!string.IsNullOrEmpty(link.TargetPath)) //Sometimes IWshShortcut returns empty string, then use the shallow location.
                {
                    path = link.TargetPath;
                }

                return path;
            }
            else
            {
                string directory = Path.GetDirectoryName(path);
                string file = Path.GetFileName(path);

                Shell32.Shell shell = new Shell32.Shell();
                Shell32.Folder folder = shell.NameSpace(directory);
                Shell32.FolderItem folderItem = folder.ParseName(file);

                Shell32.ShellLinkObject link = (Shell32.ShellLinkObject)folderItem.GetLink;
                return link.Path;
            }
        }
    }
}
