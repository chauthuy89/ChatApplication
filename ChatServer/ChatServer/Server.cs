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
    public class Server
    {
        FormServer guiForm;
        List<ClientHandler> clients = new List<ClientHandler>();
        List<string> ClientNameList = new List<string>();
        TcpClient client;
        NetworkStream stream;
        TcpListener listener;
        IFormatter bfmt = new BinaryFormatter();


        public Server(FormServer guiForm)
        {
            this.guiForm = guiForm;
        }

        public void WaitClient()
        {
            //IPEndPoint ep = new IPEndPoint(IPAddress.Parse("192.168.80.75"), 13000);
            listener = new TcpListener(IPAddress.Any, int.Parse(guiForm.getPort())); // server may connect to any ip address, port number refer to textboxport 
            
            listener.Start();
            guiForm.UpdateLog("\nRunning on port: " + guiForm.getPort() + "\n");
            while (true)
            {
                try
                {
                    client = listener.AcceptTcpClient();
                    ClientHandler ch = new ClientHandler(client, this, guiForm);
                    clients.Add(ch);
                    ch.Run();
                    SendClientList();
                }
                catch (Exception ex) { }
            }

        }

        public void SendClientList()
        {
            ClientNameList.Clear();
            foreach (ClientHandler ch in clients)
            {
                ClientNameList.Add(ch.Name);
            }
                foreach (ClientHandler ch in clients)
            {
                stream = ch.Client.GetStream();
                bfmt.Serialize(stream, ClientNameList);
            }
        }

        public void SendMessage(string message)
        {
            guiForm.UpdateLog(message);
            foreach (ClientHandler ch in clients)
            {
                stream = ch.Client.GetStream();
                bfmt.Serialize(stream, message);
            }
        }

        public void RemoveClient(ClientHandler ch)
        {
            clients.Remove(ch);
            SendClientList();
        }
    }
}
