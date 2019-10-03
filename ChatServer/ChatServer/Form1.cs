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
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace ChatServer
{
    public partial class FormServer : Form
    {
        Server server;
        IFormatter bfmt = new BinaryFormatter();


        public FormServer()
        {
            InitializeComponent();
        }

        private void FormServer_Load(object sender, EventArgs e)
        {
            buttonStop.Enabled = false;
        }

        public void buttonStart_Click(object sender, EventArgs e)
        {
            richTextBoxServer.AppendText("Start chat application.....");
            server = new Server(this);

            Thread thread = new Thread(new ThreadStart(server.WaitClient));
            thread.IsBackground = true; //stop when program closes 
            thread.Start();
            buttonStop.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        delegate void UpdateLabelDelegate(string text);
        public void Updateclientlist(string text)
        {
            if (InvokeRequired)
            {
                UpdateLabelDelegate del = Updateclientlist;
                object[] param = new object[] { text };
                richTextBoxClient.Invoke(del, param);
            }

            else
            {
                richTextBoxClient.AppendText(text + "\n");
            }
        }





        delegate void UpdateLogDelegate(string text);

        public void UpdateLog(string text)
        {

            if (InvokeRequired)
            {
                UpdateLabelDelegate del = UpdateLog;
                object[] param = new object[] { text };
                richTextBoxServer.Invoke(del, param);
            }

            else
            {
                richTextBoxServer.AppendText(text + "\n");
            }
        }

        public string getPort()
        {
            return textBoxPort.Text;
        }

       
    }
}
