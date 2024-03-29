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
    }
}
