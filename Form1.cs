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
        SimpleTcpClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += ServerDataReceved;

            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void ServerDataReceved(object sender, SimpleTCP.Message e)
        {
            txtBoxStatus.Invoke((MethodInvoker)delegate ()
            {
                txtBoxStatus.Text += e.MessageString;
                e.ReplyLine(string.Format("Message received: {0}", e.MessageString));
            });
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {

        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            txtBoxStatus.Text += "Server starting...";
            System.Net.IPAddress ipServer = new System.Net.IPAddress(long.Parse(txtBoxHostIP.Text));
            server.Start(Convert.ToInt32(txtBoxHostPort.Text), false);
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                server.Stop();
            }
        }

        private void txtBoxClientSend_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(txtBoxMessage.Text, TimeSpan.FromSeconds(3));
        }
    }
}
