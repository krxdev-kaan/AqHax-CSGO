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
using static AqHaxCSGO.Objects.Globals;

namespace AqHaxCSGO
{
    public partial class TCPForm : MaterialForm
    {
        public TCPForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(AppEx);
        }

        private void AppEx(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void TCPForm_Load(object sender, EventArgs e)
        {
            materialLabel2.Text = LocalIPAddress()?.ToString();
            Thread th = new Thread(ExecuteServer);
            th.Start();
            OffsetManager.DownloadOffsets();
            Threads.InitAll();
        }

        private static IPAddress LocalIPAddress()
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }

        public void ExecuteServer()
        {
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = LocalIPAddress();
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 8080);

            Socket listener = new Socket(ipAddr.AddressFamily,
                         SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                Console.WriteLine("Waiting connection ... ");
                Socket clientSocket = listener.Accept();
                Console.WriteLine("Connected.");

                while (true)
                {
                    byte[] bytes = new Byte[1024];
                    string data = null;

                    while (true)
                    {

                        int numByte = clientSocket.Receive(bytes);

                        data += Encoding.ASCII.GetString(bytes,
                                                   0, numByte);

                        if (data != null) break;
                    }

                    Console.WriteLine(data);

                    if (data == "Merhabalar AQ")
                    {
                        SetTextOfLabel("CONNECTED", Color.Green);
                    }
                    else if (data.Contains("wall,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine(formattedStr[1]);
                        if (formattedStr[1] == "on")
                        {
                            WallHackEnabled = true;
                            Console.WriteLine(WallHackEnabled);
                        }
                        else
                        {
                            WallHackEnabled = false;
                        }
                    }
                    else if (data.Contains("wallfull,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (formattedStr[1] == "on")
                        {
                            WallHackFullEnabled = true;
                        }
                        else
                        {
                            WallHackFullEnabled = false;
                        }
                    }
                    else if (data.Contains("wallglow,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (formattedStr[1] == "on")
                        {
                            WallHackGlowOnly = true;
                        }
                        else
                        {
                            WallHackGlowOnly = false;
                        }
                    }
                    else if (data.Contains("enemycolor,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        WallHackEnemy = ColorTranslator.FromHtml("#" + formattedStr[1]);
                    }
                    else if (data.Contains("rendercolor,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (formattedStr[1] == "on")
                        {
                            RenderEnabled = true;
                        }
                        else
                        {
                            RenderEnabled = false;
                        }
                    }
                    else if (data.Contains("rendercolorenemy,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (formattedStr[1] == "on")
                        {
                            RenderEnemyOnly = true;
                        }
                        else
                        {
                            RenderEnemyOnly = false;
                        }
                    }
                    else if (data.Contains("renderercolor,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        RenderColor = ColorTranslator.FromHtml("#" + formattedStr[1]);
                    }
                    else if (data.Contains("flash,"))
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

        private void SetOfLabel(string text, Color color)
        {
            if (this.label1.InvokeRequired)
            {
                this.label1.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.label1.Text = text;
                    this.label1.ForeColor = color;
                });
            }
            else
            {
                this.label1.Text = text;
                this.label1.ForeColor = color;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Memory.Init())
            {
                SetOfLabel("CSGO Online", Color.Green);
                IntPtr temp = AqHaxCSGO.Objects.Structs.Misc.handle;
            }
            else
            {
                SetOfLabel("CSGO Offline", Color.Red);
            }
        }
    }
}
