using NoLexa.src.Forms;
using SharpAdbClient.DeviceCommands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
