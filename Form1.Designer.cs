namespace TCP_IP_SendText
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBoxStatus = new System.Windows.Forms.TextBox();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.txtBoxHostPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxHostIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBoxClientSend = new System.Windows.Forms.Button();
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.btnClientConnect = new System.Windows.Forms.Button();
            this.txtBoxServerPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxServerIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.txtBoxStatus);
            this.tabPage1.Controls.Add(this.btnStopServer);
            this.tabPage1.Controls.Add(this.btnStartServer);
            this.tabPage1.Controls.Add(this.txtBoxHostPort);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtBoxHostIP);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server";
            // 
            // txtBoxStatus
            // 
            this.txtBoxStatus.Location = new System.Drawing.Point(60, 44);
            this.txtBoxStatus.Multiline = true;
            this.txtBoxStatus.Name = "txtBoxStatus";
            this.txtBoxStatus.Size = new System.Drawing.Size(555, 201);
            this.txtBoxStatus.TabIndex = 6;
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(522, 15);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(93, 23);
            this.btnStopServer.TabIndex = 5;
            this.btnStopServer.Text = "Stop SERVER";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(423, 16);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(93, 23);
            this.btnStartServer.TabIndex = 4;
            this.btnStartServer.Text = "Start SERVER";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // txtBoxHostPort
            // 
            this.txtBoxHostPort.Location = new System.Drawing.Point(287, 18);
            this.txtBoxHostPort.Name = "txtBoxHostPort";
            this.txtBoxHostPort.Size = new System.Drawing.Size(117, 20);
            this.txtBoxHostPort.TabIndex = 3;
            this.txtBoxHostPort.Text = "8910";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // txtBoxHostIP
            // 
            this.txtBoxHostIP.Location = new System.Drawing.Point(60, 18);
            this.txtBoxHostIP.Name = "txtBoxHostIP";
            this.txtBoxHostIP.Size = new System.Drawing.Size(178, 20);
            this.txtBoxHostIP.TabIndex = 1;
            this.txtBoxHostIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.txtBoxClientSend);
            this.tabPage2.Controls.Add(this.txtBoxMessage);
            this.tabPage2.Controls.Add(this.btnClientConnect);
            this.tabPage2.Controls.Add(this.txtBoxServerPort);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtBoxServerIP);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            // 
            // txtBoxClientSend
            // 
            this.txtBoxClientSend.Location = new System.Drawing.Point(438, 198);
            this.txtBoxClientSend.Name = "txtBoxClientSend";
            this.txtBoxClientSend.Size = new System.Drawing.Size(93, 23);
            this.txtBoxClientSend.TabIndex = 11;
            this.txtBoxClientSend.Text = "Send";
            this.txtBoxClientSend.UseVisualStyleBackColor = true;
            this.txtBoxClientSend.Click += new System.EventHandler(this.txtBoxClientSend_Click);
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.Location = new System.Drawing.Point(75, 32);
            this.txtBoxMessage.Multiline = true;
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(456, 160);
            this.txtBoxMessage.TabIndex = 10;
            // 
            // btnClientConnect
            // 
            this.btnClientConnect.Location = new System.Drawing.Point(438, 4);
            this.btnClientConnect.Name = "btnClientConnect";
            this.btnClientConnect.Size = new System.Drawing.Size(93, 23);
            this.btnClientConnect.TabIndex = 9;
            this.btnClientConnect.Text = "Connect";
            this.btnClientConnect.UseVisualStyleBackColor = true;
            this.btnClientConnect.Click += new System.EventHandler(this.btnClientConnect_Click);
            // 
            // txtBoxServerPort
            // 
            this.txtBoxServerPort.Location = new System.Drawing.Point(302, 6);
            this.txtBoxServerPort.Name = "txtBoxServerPort";
            this.txtBoxServerPort.Size = new System.Drawing.Size(117, 20);
            this.txtBoxServerPort.TabIndex = 8;
            this.txtBoxServerPort.Text = "8910";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port:";
            // 
            // txtBoxServerIP
            // 
            this.txtBoxServerIP.Location = new System.Drawing.Point(75, 6);
            this.txtBoxServerIP.Name = "txtBoxServerIP";
            this.txtBoxServerIP.Size = new System.Drawing.Size(178, 20);
            this.txtBoxServerIP.TabIndex = 6;
            this.txtBoxServerIP.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Connect to:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 281);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP IP Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBoxHostIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox txtBoxHostPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxStatus;
        private System.Windows.Forms.Button txtBoxClientSend;
        private System.Windows.Forms.TextBox txtBoxMessage;
        private System.Windows.Forms.Button btnClientConnect;
        private System.Windows.Forms.TextBox txtBoxServerPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxServerIP;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

