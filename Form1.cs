using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace HW_4_2_client_NP
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private TcpClient clientConnect;
        private NetworkStream stream;
        private NetworkStream clientConnectStream;
        string[] userList = {
        "26.234.184.154","26.24.106.13","26.129.29.176","26.24.110.212","26.62.203.2","26.165.44.129","26.111.98.24","26.85.131.246","26.64.98.225"
        };
        string[] userListName = {
        "AlexanderY","Gene","HELES","I","Katerina","OleksandraT","Olga","SergT","Kostomarov"
        };

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < userListName.Length; i ++)
            {
                comboBox1.Items.Add(userListName[i]);
            }
            clientConnect = new TcpClient(IPAddress.Loopback.ToString(), 49200);
            client = new TcpClient(IPAddress.Loopback.ToString(), 49220);
            clientConnectStream = clientConnect.GetStream();
            stream = client.GetStream();
            RecieveClients();
            SendUsername();
            RecieveMessages();
        }

        async void RecieveClients()
        {
            await Task.Run(() => 
            {
            while (true)
                {
                  byte[] buffer1 = new byte[10240];
                  int bytesRead = clientConnectStream.Read(buffer1, 0, buffer1.Length);
                  string response = Encoding.ASCII.GetString(buffer1, 0, bytesRead);
                  List<string> userslist = JsonConvert.DeserializeObject<List<string>>(response);
                  if (listBoxUserList.Items.Count > 0)
                    {
                        Invoke(new Action(() => listBoxUserList.Items.Clear()));
                    }
                  foreach (string us in userslist)
                  {
                      Invoke(new Action(() => listBoxUserList.Items.Add(us)));
                  }
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMess();
        }

        async void SendUsername()
        {
            await Task.Run(() =>
            {
                string sendID = comboBox1.Text;
                byte[] buffer = Encoding.ASCII.GetBytes(sendID);
                clientConnectStream.Write(buffer, 0, buffer.Length);
            });
        }

        async void SendMess()
        {
            await Task.Run(() =>
            {
                string message = textBox1.Text;
                byte[] buffer = Encoding.ASCII.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
                
            });
        }
        async void RecieveMessages()
        {
            await Task.Run(() => 
            {
            while (true)
                {
                    byte[] buffer1 = new byte[1024];
                    int bytesRead = stream.Read(buffer1, 0, buffer1.Length);
                    string response = Encoding.ASCII.GetString(buffer1, 0, bytesRead);
                    Invoke(new Action(() => listBoxMessages.Items.Add(response)));
                }
            });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxUserList.Items.Count>0)
                listBoxUserList.Items.Clear();
            RecieveClients();
            SendUsername();
            RecieveMessages();


        }
    }
}
