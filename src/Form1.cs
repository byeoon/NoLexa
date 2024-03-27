using NoLexa.src;
using SharpAdbClient;
using System.Diagnostics;
using System.Net;

namespace NoLexa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AdbServer server = new AdbServer();
            ListDevices();
        }

        private void ListDevices()
        {
            try
            {
                AdbClient Client = new AdbClient();
                var devices = Client.GetDevices();

                foreach (var device in devices)
                {
                    listView1.Items.Add(device.Name);
                }
            }
            catch
            {
                groupBox1.Visible = true;
                btnADBYes.Visible = true;
                btnDismiss.Visible = true;
                lblADBWarning.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ListDevices();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            btnADBYes.Visible = false;
            btnDismiss.Visible = false;
            lblADBWarning.Visible = false;
        }

        private void btnADBYes_Click(object sender, EventArgs e)
        {
            DownloadHelper.InstallADB();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://en.wikipedia.org/wiki/Fire_HD", UseShellExecute = true });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // todo: selection code.
        }
    }
}
