using SharpAdbClient;
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

namespace NoLexa.src.Forms
{
    public partial class frmBatterySpoof : Form
    {
        public frmBatterySpoof()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var receiver = new ConsoleOutputReceiver();
            frmSetup.client.ExecuteRemoteCommand("dumpsys battery set level " + textBox1.Text, frmSetup.client.GetDevices().First(), receiver);
            Debug.Print(receiver.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var receiver = new ConsoleOutputReceiver();
            frmSetup.client.ExecuteRemoteCommand("dumpsys battery reset", frmSetup.client.GetDevices().First(), receiver);
            Debug.Print(receiver.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var receiver = new ConsoleOutputReceiver();
            if (comboBox1.SelectedItem.ToString() == "Charging")
            {
                frmSetup.client.ExecuteRemoteCommand("dumpsys battery set status 2", frmSetup.client.GetDevices().First(), receiver);
            }

            if (comboBox1.SelectedItem.ToString() == "Not Charging")
            {
                frmSetup.client.ExecuteRemoteCommand("dumpsys battery set ac 1", frmSetup.client.GetDevices().First(), receiver);
            }
        }

        private void frmBatterySpoof_Load(object sender, EventArgs e)
        {

        }
    }
}
