using NoLexa.src;
using SharpAdbClient;
using System.Diagnostics;
using System.Net;

namespace NoLexa
{
    public partial class frmSetup : Form
    {
        public static AdbServer server = new AdbServer();
        public static AdbClient client = new AdbClient();

        public frmSetup()
        {
            server.StartServer(@"C:\Program Files (x86)\android-sdk\platform-tools\adb.exe", restartServerIfNewer: false);

            InitializeComponent();
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
                if (File.Exists("C:\\Program Files (x86)\\android-sdk\\platform-tools\\adb.exe"))
                {
                    MessageBox.Show("You do not have any compatible devices connected, please connect a device.", "NoLexa");
                }
                else
                {
                    groupBox1.Visible = true;
                    btnADBYes.Visible = true;
                    btnDismiss.Visible = true;
                    lblADBWarning.Visible = true;
                }


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
            var device = client.GetDevices().First();

            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void frmSetup_Load(object sender, EventArgs e)
        {

        }
    }
}
