using SharpAdbClient;
using SharpAdbClient.DeviceCommands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoLexa.src.Forms
{
    public partial class NoLexaFunctions
    {
        private static long epoch = (long)(DateTime.Now - new DateTime(1970, 1, 1)).TotalMilliseconds;
        

        public static void DumpSystemInfo()
        {
            var noLexaLogs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NoLexa\\Logs\\";
            var receiver = new ConsoleOutputReceiver();
            frmSetup.client.ExecuteShellCommand(frmSetup.client.GetDevices().First(), "dumpsys meminfo > /sdcard/memorydumpNoLexa.txt", receiver);
            frmSetup.client.ExecuteShellCommand(frmSetup.client.GetDevices().First(), "dumpsys input > /sdcard/inputdumpNoLexa.txt", receiver);
            frmSetup.client.ExecuteShellCommand(frmSetup.client.GetDevices().First(), "dumpsys netstats detail > /sdcard/networkdumpNoLexa.txt", receiver);
            frmSetup.client.ExecuteShellCommand(frmSetup.client.GetDevices().First(), "dumpsys batterystats  > /sdcard/batterydumpNoLexa.txt", receiver);
            frmSetup.client.ExecuteShellCommand(frmSetup.client.GetDevices().First(), "dumpsys -l  > /sdcard/servicesdumpNoLexa.txt", receiver);
            frmSetup.client.ExecuteShellCommand(frmSetup.client.GetDevices().First(), "dumpsys > /sdcard/fulldumpNoLexa.txt", receiver);
            frmSetup.client.ExecuteShellCommand(frmSetup.client.GetDevices().First(), "dumpsys procstats --hours 3  > /sdcard/processstatdumpNoLexa.txt", receiver);


            var SendMemInfo = new ProcessStartInfo();
            SendMemInfo.FileName = @"C:\Program Files (x86)\android-sdk\platform-tools\adb.exe";
            SendMemInfo.Arguments = @"pull /sdcard/memorydumpNoLexa.txt " + noLexaLogs;
            SendMemInfo.WorkingDirectory = @"C:\Program Files (x86)\android-sdk\platform-tools";
            SendMemInfo.CreateNoWindow = false;
            SendMemInfo.UseShellExecute = false;

            var SendInputInfo = new ProcessStartInfo();
            SendInputInfo.FileName = @"C:\Program Files (x86)\android-sdk\platform-tools\adb.exe";
            SendInputInfo.Arguments = @"pull /sdcard/inputdumpNoLexa.txt " + noLexaLogs;
            SendInputInfo.WorkingDirectory = @"C:\Program Files (x86)\android-sdk\platform-tools";
            SendInputInfo.CreateNoWindow = false;
            SendInputInfo.UseShellExecute = false;

            var SendNetworkInfo = new ProcessStartInfo();
            SendNetworkInfo.FileName = @"C:\Program Files (x86)\android-sdk\platform-tools\adb.exe";
            SendNetworkInfo.Arguments = @"pull /sdcard/networkdumpNoLexa.txt " + noLexaLogs;
            SendNetworkInfo.WorkingDirectory = @"C:\Program Files (x86)\android-sdk\platform-tools";
            SendNetworkInfo.CreateNoWindow = false;
            SendNetworkInfo.UseShellExecute = false;

            var SendBatteryInfo = new ProcessStartInfo();
            SendBatteryInfo.FileName = @"C:\Program Files (x86)\android-sdk\platform-tools\adb.exe";
            SendBatteryInfo.Arguments = @"pull /sdcard/batterydumpNoLexa.txt " + noLexaLogs;
            SendBatteryInfo.WorkingDirectory = @"C:\Program Files (x86)\android-sdk\platform-tools";
            SendBatteryInfo.CreateNoWindow = false;
            SendBatteryInfo.UseShellExecute = false;

            var SendServiceInfo = new ProcessStartInfo();
            SendServiceInfo.FileName = @"C:\Program Files (x86)\android-sdk\platform-tools\adb.exe";
            SendServiceInfo.Arguments = @"pull /sdcard/servicesdumpNoLexa.txt " + noLexaLogs;
            SendServiceInfo.WorkingDirectory = @"C:\Program Files (x86)\android-sdk\platform-tools";
            SendServiceInfo.CreateNoWindow = false;
            SendServiceInfo.UseShellExecute = false;

            var SendFullDump = new ProcessStartInfo();
            SendFullDump.FileName = @"C:\Program Files (x86)\android-sdk\platform-tools\adb.exe";
            SendFullDump.Arguments = @"pull /sdcard/fulldumpNoLexa.txt " + noLexaLogs;
            SendFullDump.WorkingDirectory = @"C:\Program Files (x86)\android-sdk\platform-tools";
            SendFullDump.CreateNoWindow = false;
            SendFullDump.UseShellExecute = false;

            var SendProcessInfo = new ProcessStartInfo();
            SendProcessInfo.FileName = @"C:\Program Files (x86)\android-sdk\platform-tools\adb.exe";
            SendProcessInfo.Arguments = @"pull /sdcard/processstatdumpNoLexa.txt " + noLexaLogs;
            SendProcessInfo.WorkingDirectory = @"C:\Program Files (x86)\android-sdk\platform-tools";
            SendProcessInfo.CreateNoWindow = false;
            SendProcessInfo.UseShellExecute = false;

            Process.Start(SendMemInfo);
            Process.Start(SendNetworkInfo);
            Process.Start(SendInputInfo);
            Process.Start(SendBatteryInfo);
            Process.Start(SendServiceInfo);
            Process.Start(SendFullDump);
            Process.Start(SendProcessInfo);

            ZipDebugInfo();
        }

        private static void ZipDebugInfo()
        {
            var noLexaLogs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\NoLexa\\Logs\\";
            MessageBox.Show("All data has been dumped into " + noLexaLogs + ".", "NoLexa");
            Thread.Sleep(2500);
            ZipFile.CreateFromDirectory(noLexaLogs, noLexaLogs + "\\nolexadump-" + epoch + ".zip");
            // todo: delete all leftover files, and also fix where it says its being used by another process.
        }
    }
}
