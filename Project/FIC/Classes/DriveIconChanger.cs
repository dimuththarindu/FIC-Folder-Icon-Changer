using System;
using System.IO;
using System.Windows.Forms;

namespace FIC
{
    class DriveIconChanger
    {
        private void CreateNewSysDir()
        {
            string path = Path.GetPathRoot(Environment.SystemDirectory) + @".Custom";

            // Create a new directory to store icon files
            Directory.CreateDirectory(path + @"\Icons");

            // Make it a system file
            File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden); //hidden file
            File.SetAttributes(path + @"\Icons", File.GetAttributes(path + @"\Icons") | FileAttributes.Hidden); //hidden file
            File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.System); //System file
            File.SetAttributes(path + @"\Icons", File.GetAttributes(path + @"\Icons") | FileAttributes.System); //System file
        }

        private void RegEditor(string letter)
        {
            string output = "";
            string nl = Environment.NewLine;

            //Registry.LocalMachine.CreateSubKey(@"SOFTWARE\YourCompanyName\SomeNewKey");

            output = @"[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\DriveIcons]" + nl + nl;

            output += @"[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\DriveIcons\" + letter + "]" + nl + nl;

            output += @"[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\DriveIcons\" + letter + @"\DefaultIcon]" + nl;


            output += "@=\"\\\"C:\\\\Custom\\\\Icons\\\\MapDrive\\\\Study_01.ico\\\"\" " + nl + nl; // @="\"C:\\Custom\\Icons\\MapDrive\\Study_01.ico\""

            MessageBox.Show(output);
        }
    }
}
