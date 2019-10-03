using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace ChatClient
{
    public partial class FormClient1 : Form
    {
        IFormatter bfmt = new BinaryFormatter();
        TcpClient myclient = new TcpClient();
        NetworkStream stream;
        

        public FormClient1()
        {
            InitializeComponent();
        }

        private void FormClient1_Load(object sender, EventArgs e)
        {
            buttonSend.Enabled = false;
            textBoxWrite.Enabled = false;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            buttonSend.Enabled = true;
            textBoxWrite.Enabled = true;
            string ip = textBoxHost.Text.ToString();
            int port = int.Parse(textBoxPort.Text);
            myclient.Connect(ip, port); // 
            richTextBoxWrite.AppendText(textBoxChatName.Text + " Connected to server\n");
            stream = myclient.GetStream();
            bfmt.Serialize(stream, textBoxChatName.Text);
            Thread threadListClient = new Thread(new ThreadStart(ClientList));
            threadListClient.IsBackground = true;
            threadListClient.Start();
        }

        public void ClientList()
        {
            while (true)
            {
                while (!stream.DataAvailable) // wait for data from server
                {
                    Thread.Sleep(100);
                }
                List<string> clients = new List<string>(); // make a new list of clients
                object obj = bfmt.Deserialize(stream); // creating object from the stream & deserialize
                if (obj is List<string>)
                {
                    clients = obj as List<string>;
                    Updateclientlist(richTextBoxList, "");
                    foreach (string client in clients)
                    {
                        Updateclientlist(richTextBoxList, client);
                    }
                }
                if (obj is string)
                {
                    //MessageBox.Show(obj.ToString());
                    string[] line = obj.ToString().Split(':');
                    string text = line[2] + ":" + line[3];
                    //Updateclientlist(richTextBoxWrite, obj as string);
                    Updateclientlist(richTextBoxWrite, text.Substring(1));


                }
            }

        }

        delegate void UpdateLabelDelegate(RichTextBox textboxclient, string text);

        private void Updateclientlist(RichTextBox textboxclient, string text)
        {
            

            if (textboxclient.InvokeRequired)
            {
                UpdateLabelDelegate del = Updateclientlist;
                object[] param = new object[] { textboxclient, text };
                textboxclient.Invoke(del, param);
            }

            else
            {
                if (text == "")
                {
                    textboxclient.Text = "";
                }
                else
                {
                    textboxclient.AppendText(text + "\n");
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (myclient.Connected == true)
            {
                string message = textBoxChatName.Text + " is gone....";
                textBoxWrite.Text = message;
                buttonSend_Click(sender, e);
                Thread.Sleep(1500);
                bfmt.Serialize(stream, 0);
                myclient.Close();
            }
            this.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string message = textBoxWrite.Text;
            //MessageBox.Show(message);
            bfmt.Serialize(stream, message);

            textBoxWrite.Text = String.Empty;
            //textBoxWrite.Text = "";
            //textBoxWrite.Clear();
            textBoxWrite.Text = "";
           // textBoxWrite.Select(0, 0);



        }

        private void textBoxHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWrite_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter) e.Handled = false;
           // else e.Handled = true;
              if(e.Control == true && e.KeyCode == Keys.Enter)      
        
            {
                buttonSend_Click(sender, e);
               
                
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        

        private void richTextBoxWrite_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxChatName.Text + ":";
            int len = this.richTextBoxWrite.TextLength;
            int index = 0;
            int last = this.richTextBoxWrite.Text.LastIndexOf(searchText);
            //MessageBox.Show(index +":"+ last);
            while(index < last)
            {
               
                richTextBoxWrite.Find(searchText,index,len,RichTextBoxFinds.None);
                richTextBoxWrite.SelectionColor = Color.Blue;
                index = richTextBoxWrite.Text.IndexOf(searchText, index) + 1;
            }
            
            
        }

      
    }
}
