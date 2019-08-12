using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using AqHaxCSGO.MemoryManagers;
using MaterialSkin;
using MaterialSkin.Controls;
using AqHaxCSGO.Objects;

namespace AqHaxCSGO
{
    public partial class TCPForm : MaterialForm
    {
        public bool WallHackEnabled = false;
        public bool AntiFlashEnabled = false;

        public TCPForm()
        {
            InitializeComponent();
        }

        private void TCPForm_Load(object sender, EventArgs e)
        {
            materialLabel2.Text = LocalIPAddress().ToString();
            Thread th = new Thread(ExecuteServer);
            th.Start();
            Console.WriteLine(new EntityList()[0]);
        }

        private static IPAddress LocalIPAddress()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }

        public void ExecuteServer()
        {
            // Establish the local endpoint  
            // for the socket. Dns.GetHostName 
            // returns the name of the host  
            // running the application. 
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = LocalIPAddress();
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 8080);
            Console.WriteLine(ipAddr.MapToIPv4());

            // Creation TCP/IP Socket using  
            // Socket Class Costructor 
            Socket listener = new Socket(ipAddr.AddressFamily,
                         SocketType.Stream, ProtocolType.Tcp);

            try
            {

                // Using Bind() method we associate a 
                // network address to the Server Socket 
                // All client that will connect to this  
                // Server Socket must know this network 
                // Address 
                listener.Bind(localEndPoint);

                // Using Listen() method we create  
                // the Client list that will want 
                // to connect to Server 
                listener.Listen(10);

                Console.WriteLine("Waiting connection ... ");

                // Suspend while waiting for 
                // incoming connection Using  
                // Accept() method the server  
                // will accept connection of client 
                Socket clientSocket = listener.Accept();
                Console.WriteLine("Connected.");

                while (true)
                {
                    // Data buffer 
                    byte[] bytes = new Byte[1024];
                    string data = null;

                    while (true)
                    {

                        int numByte = clientSocket.Receive(bytes);

                        data += Encoding.ASCII.GetString(bytes,
                                                   0, numByte);

                        if (data != null) break;
                    }

                    if (data == "Merhabalar AQ")
                    {
                        SetTextOfLabel("CONNECTED", Color.Green);
                    }
                    else if (data.Contains("wall"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (formattedStr[1] == "on")
                        {
                            WallHackEnabled = true;
                        }
                        else
                        {
                            WallHackEnabled = false;
                        }
                    }
                    else if (data.Contains("flash"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (formattedStr[1] == "on")
                        {
                            AntiFlashEnabled = true;
                        }
                        else
                        {
                            AntiFlashEnabled = false;
                        }
                    }

                    Console.WriteLine("Text received -> {0} ", data);
                }

                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void SetTextOfLabel(string text, Color color)
        {
            if (this.materialLabel3.InvokeRequired)
            {
                this.materialLabel3.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.materialLabel3.Text = text;
                    this.materialLabel3.ForeColor = color;
                });
            }
            else
            {
                this.materialLabel3.Text = text;
                this.materialLabel3.ForeColor = color;
            }
        }
    }
}
