using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ClickOnce_Open_File_Location
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            checkBoxClickOnce.Checked = Properties.Settings.Default.ClickOnce;
            checkBoxShortcut.Checked = Properties.Settings.Default.Shortcut;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            string fileLocation = '"' + Application.ExecutablePath + "\" \"%1\"";

            //(Un)register .appref-ms
            RegistryKey currentKey = Registry.CurrentUser;
            currentKey = currentKey.OpenSubKey("Software");
            currentKey = currentKey.OpenSubKey("Classes", true);
            currentKey = currentKey.CreateSubKey("Application.Reference");
            currentKey = currentKey.CreateSubKey("shell");

            if (checkBoxClickOnce.Checked)
            {
                currentKey = currentKey.CreateSubKey("Open file location");
                currentKey = currentKey.CreateSubKey("command");
                currentKey.SetValue("", fileLocation);
            }
            else
            {
                if (currentKey.OpenSubKey("Open file location") != null)
                {
                    currentKey.DeleteSubKeyTree("Open file location");
                }
            }

            //(Un)register .lnk
            currentKey = Registry.CurrentUser;
            currentKey = currentKey.OpenSubKey("Software");
            currentKey = currentKey.OpenSubKey("Classes");
            currentKey = currentKey.OpenSubKey("Lnkfile", true);
            currentKey = currentKey.CreateSubKey("shell");

            if (checkBoxShortcut.Checked)
            {
                currentKey = currentKey.CreateSubKey("Open file location");
                currentKey = currentKey.CreateSubKey("command");
                currentKey.SetValue("", fileLocation);
            }
            else
            {
                if (currentKey.OpenSubKey("Open file location") != null)
                {
                    currentKey.DeleteSubKeyTree("Open file location");
                }
            }

            //Save Settings
            Properties.Settings.Default.ClickOnce = checkBoxClickOnce.Checked;
            Properties.Settings.Default.Shortcut = checkBoxShortcut.Checked;
            Properties.Settings.Default.Save();

            MessageBox.Show("Settings saved successfully");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
