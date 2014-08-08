##### Better Open File Location.

This tool aims to enable the Open File Location context menu item on all .lnk (Shortcut) and .appref-ms (Application Reference) files.

To avoid having duplicate 'Open File Location' entries on .lnk files, it's recommended to remove the native entry, by disabling the following registry key:

`HKEY_CLASSES_ROOT\lnkfile\shellex\ContextMenuHandlers\OpenContainingFolderMenu`

##### Usage:

Running the application without arguments will show the Settings window, allowing the user to (de)associate the application with .lnk and .appref-ms file extensions.
