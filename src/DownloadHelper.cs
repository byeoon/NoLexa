using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static NoLexa.src.Desktop;

namespace NoLexa.src
{
    public static class DownloadHelper
    {
        static string downloadsPath = KnownFolders.GetPath(KnownFolder.Downloads);

        public static void InstallADB()
        {
            if (IsAdministrator() == false)
            {
                MessageBox.Show("To install ADB, NoLexa needs to run as administrator.");
            }
            else
            {
                    if (!Directory.Exists("C:\\Program Files (x86)\\android-sdk\\platform-tools"))
                    {
                        Directory.CreateDirectory("C:\\Program Files (x86)\\android-sdk\\");
                        Directory.CreateDirectory("C:\\Program Files (x86)\\android-sdk\\platform-tools");
                    }
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadFile("https://dl.google.com/android/repository/platform-tools-latest-windows.zip", @"C:\\Program Files (x86)\\android-sdk\\adb.zip");
                        wc.Dispose();
                        UnzipADB(); // fuck you c#
                        MessageBox.Show("ADB has been downloaded successfully, please click the 'Refresh' button.", "NoLexa");
                    }
            }
        }

        private static void UnzipADB() {
            var fileName = "C:\\Program Files (x86)\\android-sdk\\adb.zip";
            ZipFile.ExtractToDirectory(fileName, "C:\\Program Files (x86)\\android-sdk\\");
        }

        public static bool IsAdministrator() {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

    }
}
