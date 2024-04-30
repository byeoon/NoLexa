using SharpAdbClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoLexa.src.Forms
{
    public partial class frmPackageManager : Form
    {
        public frmPackageManager()
        {
            InitializeComponent();
        }

        private void frmPackageManager_Load(object sender, EventArgs e)
        {
            AdbClient Client = new AdbClient();
            var device = Client.GetDevices().First();
            var receiver = new ConsoleOutputReceiver();
            Client.ExecuteShellCommand(device, "sh -c 'cmd package list packages -f'", receiver);
            listBox1.Items.Add(receiver.ToString());
        }
    }
}
