using SharpAdbClient;
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
    public partial class frmADBShell : Form
    {
        public frmADBShell()
        {
            InitializeComponent();
        }

        private void frmADBShell_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var receiver = new ConsoleOutputReceiver();
            frmSetup.client.ExecuteRemoteCommand(textBox1.Text, frmSetup.client.GetDevices().First(), receiver);
            richTextBox1.Text += receiver.ToString();
            textBox1.Clear();
        }
    }
}
