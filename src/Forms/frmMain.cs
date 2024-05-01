using NoLexa.src.Forms;
using SharpAdbClient;
using SharpAdbClient.DeviceCommands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static NoLexa.src.Forms.NoLexaFunctions;

namespace NoLexa.src
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label1.Text = "Serial Number: " + frmSetup.client.GetDevices().First().Serial;
            label2.Text = "Device Codename: " + frmSetup.client.GetDevices().First().Product;
            label3.Text = "Model: " + frmSetup.client.GetDevices().First().Model;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmADBShell adbshell = new frmADBShell();
            adbshell.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBatterySpoof batterySpoof = new frmBatterySpoof();
            batterySpoof.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DumpSystemInfo();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdbClient Client = new AdbClient();
            var device = Client.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            Client.ExecuteRemoteCommand("pm clear com.amazon.kindle.kso", device, receiver);
            Client.ExecuteRemoteCommand("pm hide com.amazon.kindle.kso", device, receiver);
            Client.ExecuteRemoteCommand("pm uninstall --user 0 com.amazon.kindle.kso", device, receiver);
            Client.ExecuteRemoteCommand("settings put global LOCKSCREEN_AD_ENABLED 0", device, receiver);

            Debug.Print(receiver.ToString());
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            frmPackageManager packageManager = new frmPackageManager();
            packageManager.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AdbClient Client = new AdbClient();
            var device = Client.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            // Client.ExecuteShellCommand(device, "pm uninstall -k amazon.alexa.tablet", receiver);

            Client.ExecuteShellCommand(device, "pm hide com.amazon.alexa.multimodal.gemini", receiver);
            Client.ExecuteShellCommand(device, "pm hide com.amazon.alexa.youtube.app", receiver);
            Debug.Print(receiver.ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AdbClient Client = new AdbClient();
            var device = Client.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            Client.ExecuteShellCommand(device, "pm uninstall --user 0 com.goodreads.kindle", receiver);
            Client.ExecuteShellCommand(device, "pm disable amazon.client.metrics.api", receiver);
            Client.ExecuteShellCommand(device, "pm uninstall --user 0 com.amazon.recess", receiver);
            Client.ExecuteShellCommand(device, "pm uninstall --user 0 amazon.jackson19", receiver);
            Debug.Print(receiver.ToString());
        }
    }
}
