using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using SimpleTCP;

namespace TCP_IP_SendText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            SimpleTcpServer server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += ServerDataReceved;
        }

        private void ServerDataReceved(object sender, SimpleTCP.Message e)
        {
            txtBoxStatus.Invoke((MethodInvoker)delegate ()
            {
                txtBoxStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("Message received: {0}", e.MessageString));
            });
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            txtBoxStatus.Text += "Server starting...";
            System.Net.IPAddress ipServer = new System.Net.IPAddress(long.Parse(txtBoxHostIP.Text));
            server.Start(ipServer, Convert.ToInt32(txtBoxHostPort.Text));
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }
        }
    }
}
