﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FIC
{
    class IconCustomizer
    {
        List<string> allDir = new List<string>{};

        public List<string> AllDir { get => allDir; set => allDir = value; }      

        public Boolean SelectDirectory(int subFolders, RichTextBox richTextBox)
        {
            try
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        allDir.Add(fbd.SelectedPath);

                        if (subFolders == 0)
                        {
                            allDir.AddRange(System.IO.Directory.GetDirectories(fbd.SelectedPath, "*", System.IO.SearchOption.TopDirectoryOnly));
                        }
                        else if (subFolders == 1)
                        {
                            allDir.AddRange(System.IO.Directory.GetDirectories(fbd.SelectedPath, "*", System.IO.SearchOption.AllDirectories));
                        }

                        // Write to richTextbox
                        richTextBox.Text = "Selected Folders" + Environment.NewLine + " - ";
                        richTextBox.Text += string.Join(Environment.NewLine + " - ", allDir.ToArray());

                        return true;
                    }
                }
            }
            catch (Exception)
            {
            }
            return false;
        }

        public void ClearDirectories(RichTextBox richTextBox)
        {
            allDir.Clear();
            richTextBox.Text = String.Empty;
        }

        public string GettingIcons(string dir, PictureBox pictureBox)
        {
            try
            {
                if (string.IsNullOrEmpty(dir))
                {
                    dir = "Select an Icon";
                }
                else
                {
                    dir = "Select an Icon: " + dir;
                }

                using (OpenFileDialog open = new OpenFileDialog())
                {
                    open.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
                    open.Filter = "Image Files(*.icon)|*.ico";
                    open.Title = dir;

                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox.Image = Bitmap.FromHicon(new Icon(open.FileName, new Size(256, 256)).Handle);
                        return open.FileName;
                    }
                }
            }
            catch (Exception)
            {
            }

            return null;
        }

        public void SettingIcons(string dir, string icoPath, string folderType)
        {
            if (folderType == "General items")
            {
                folderType = "Generic";
            }

            try
            {
                //deleting existing files
                RettingIcons(dir);               

                //copying Icon file //overwriting
                File.Copy(icoPath, dir + @"\Icon.ico", true);
                //System.IO.File.Copy(filePath, TempIconSaveLocation + GetDateTime() + ".ico", true);

                //writing configuration file
                string[] lines = { "[.ShellClassInfo]", "IconResource=Icon.ico,0", "[ViewState]", "Mode=", "Vid=", "FolderType=" + folderType };
                File.WriteAllLines(dir + @"\desktop.ini", lines);

                //configure file 2            
                string[] linesLinux = { "desktop.ini", "Icon.ico" };
                File.WriteAllLines(dir + @"\.hidden", linesLinux);

                //making system files
                File.SetAttributes(dir + @"\desktop.ini", File.GetAttributes(dir + @"\desktop.ini") | FileAttributes.Hidden | FileAttributes.System | FileAttributes.ReadOnly); 
                File.SetAttributes(dir + @"\Icon.ico", File.GetAttributes(dir + @"\Icon.ico") | FileAttributes.Hidden | FileAttributes.System | FileAttributes.ReadOnly); 
                File.SetAttributes(dir + @"\.hidden", File.GetAttributes(dir + @"\.hidden") | FileAttributes.Hidden | FileAttributes.System | FileAttributes.ReadOnly); 

                File.SetAttributes(dir, File.GetAttributes(dir) | FileAttributes.ReadOnly);

                RefreshIcons(dir);
            }
            catch (Exception)
            {
            }
            finally
            {                
            }
        }

        public void RettingIcons(string dir)
        {
            try
            {
                // desktop.ini
                if (File.Exists(dir + @"\desktop.ini"))
                {
                    File.SetAttributes(dir + @"\desktop.ini", File.GetAttributes(dir + @"\desktop.ini") | FileAttributes.Normal); //Normal file

                    FileInfo fileInfo = new FileInfo(dir + @"\desktop.ini");
                    fileInfo.IsReadOnly = false;

                    File.Delete(dir + @"\desktop.ini");
                }

                // Icon.ico
                if (File.Exists(dir + @"\Icon.ico"))
                {
                    File.SetAttributes(dir + @"\Icon.ico", File.GetAttributes(dir + @"\Icon.ico") | FileAttributes.Normal); //Normal file

                    FileInfo fileInfo = new FileInfo(dir + @"\Icon.ico");
                    fileInfo.IsReadOnly = false;

                    File.Delete(dir + @"\Icon.ico");
                }

                // .hidden
                if (File.Exists(dir + @"\.hidden"))
                {
                    File.SetAttributes(dir + @"\.hidden", File.GetAttributes(dir + @"\.hidden") | FileAttributes.Normal); //Normal file

                    FileInfo fileInfo = new FileInfo(dir + @"\.hidden");
                    fileInfo.IsReadOnly = false;

                    File.Delete(dir + @"\.hidden");
                }
            }
            catch (Exception)
            {                
            }
        }

        public void RefreshIcons(string dir)
        {
            try
            {
                // Attempt 01 
                Directory.Move(dir, dir + "_Processing");
                Directory.Move(dir + "_Processing", dir);

                // Attempt 02
                string localIconCachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\IconCache.db";
                if (File.Exists(localIconCachePath))
                {
                    File.Delete(localIconCachePath);
                }

                // Attempt 03
                string dirCachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\Windows\Explorer\";
                DirectoryInfo di = new DirectoryInfo(dirCachePath);
                FileInfo[] files = di.GetFiles("iconcache*.db");
                foreach (FileInfo file in files)
                {
                    File.Delete(file.FullName);
                }

                // Attempt 04.01
                using (Process process = new Process())
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C ie4uinit.exe -ClearIconCache";
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo = startInfo;
                    process.Start();
                }

                // Attempt 04.02
                using (Process process = new Process())
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C ie4uinit.exe -ClearIconCache";
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo = startInfo;
                    process.Start();
                }

                // Attempt 05
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.MainModule.ModuleName.Contains("explorer") == true)
                    {
                        p.Kill();
                    }
                }
                Process.Start("explorer.exe");

                // Attempt 06
                // Copied from stackoverflow.com
                SHChangeNotify(0x08000000, 0x0000, (IntPtr)null, (IntPtr)null);//SHCNE_ASSOCCHANGED SHCNF_IDLIST
            }
            catch (Exception)
            {
            }            
        }

        // Copied from stackoverflow.com
        [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern void SHChangeNotify(int wEventId, int uFlags, IntPtr dwItem1, IntPtr dwItem2);
    }
}
