using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChatServer
{
    public class ClientHandler
    {
        TcpClient client;
        NetworkStream stream;
        IFormatter bfmt = new BinaryFormatter();
        FormServer guiForm;
        Server server;
        string name;
        string message;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public TcpClient Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        public ClientHandler (TcpClient client, Server server, FormServer guiForm)
        {
            this.client = client;
            stream = client.GetStream();
            this.guiForm = guiForm;
            this.server = server;
        }

        public void Run()
        {
            while (!stream.DataAvailable)
            {
                Thread.Sleep(100);
            }
            object obj = bfmt.Deserialize(stream);
            
            if (obj is String)
            {
                name = obj as String;
            }
            name = client.Client.RemoteEndPoint.ToString() + ": " + name ;
            
            guiForm.Updateclientlist(name);

            Thread threadMessage = new Thread(new ThreadStart(recieveMessage));
            threadMessage.IsBackground = true;
            threadMessage.Start();
        }

        private void recieveMessage()
        {
            while (true)
            {
                while (!stream.DataAvailable)
                {
                    Thread.Sleep(100);
                }
                object o = bfmt.Deserialize(stream);

                if (o is String)
                {
                    message = o as String;
                    message = name + ": " + message;
                    server.SendMessage(message);
                }

                if (o is int )
                {
                    server.RemoveClient(this);
                }
            }
        }

        
    }
}
