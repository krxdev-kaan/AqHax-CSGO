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
using System.Timers;
using System.Runtime.InteropServices;
using AqHaxCSGO.MemoryManagers;
using MaterialSkin;
using MaterialSkin.Controls;
using AqHaxCSGO.Objects;
using static AqHaxCSGO.Objects.Globals;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace AqHaxCSGO
{
    public partial class TCPForm : MaterialForm
    {
        System.Timers.Timer timer = new System.Timers.Timer();

        public TCPForm()
        {
            InitializeComponent();
            AllocConsole();

            if (!Memory.Init())
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
                if (Program.entryForm.InvokeRequired)
                {
                    Program.entryForm.BeginInvoke((MethodInvoker)delegate ()
                    {
                        Program.entryForm.Visible = true;
                    });
                }
                this.Close();
            }
            else
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green900, Primary.Green600, Accent.Green200, TextShade.WHITE);
            }

            this.FormClosing += new FormClosingEventHandler(AppEx);

            timer.Elapsed += new ElapsedEventHandler(UpdateHandle);
            timer.Interval = 90000;
            timer.Start();
        }

        private void AppEx(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void UpdateHandle(object source, ElapsedEventArgs e)
        {
            if (!(Process.GetProcessesByName("csgo").Length > 0))
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.Hide();
                        Program.entryForm.Visible = true;
                        this.Close();
                        var materialSkinManager = MaterialSkinManager.Instance;
                        materialSkinManager.AddFormToManage(this);
                        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Red600, Accent.Red200, TextShade.WHITE);
                    });
                }
            }
        }

        private void TCPForm_Load(object sender, EventArgs e)
        {
            materialLabel2.Text = LocalIPAddress()?.ToString();
            Thread th = new Thread(ExecuteServer);
            th.Start();

            NetvarManager.LoadOffsets();
            OffsetManager.ScanOffsets();
            Threads.InitAll();
            FreeConsole();
            NetvarManager.netvarList.Clear();
        }

        private static IPAddress LocalIPAddress()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                var addr = ni.GetIPProperties().GatewayAddresses.FirstOrDefault();
                if (addr != null)
                {
                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || 
                        ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    {
                        foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            {
                                return ip.Address;
                            }
                        }
                    }
                }
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            return host.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }

        public void ExecuteServer()
        {
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = IPAddress.Any;
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 8080);

            Socket listener = new Socket(ipAddr.AddressFamily,
                         SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                Socket clientSocket = listener.Accept();

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
                    else if (data.Contains("bunnyhop,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (formattedStr[1] == "on")
                        {
                            BunnyHopEnabled = true;
                        }
                        else
                        {
                            BunnyHopEnabled = false;
                        }
                    }
                    else if (data.Contains("aim,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (formattedStr[1] == "on")
                        {
                            AimEnabled = true;
                        }
                        else
                        {
                            AimEnabled = false;
                        }
                    }
                    else if (data.Contains("aimrecoil,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (formattedStr[1] == "on")
                        {
                            AimRecoil = true;
                        }
                        else
                        {
                            AimRecoil = false;
                        }
                    }
                    else if (data.Contains("aimtrigger,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (formattedStr[1] == "on")
                        {
                            AimShootOnCollide = true;
                        }
                        else
                        {
                            AimShootOnCollide = false;
                        }
                    }
                    else if (data.Contains("trigger,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (formattedStr[1] == "on")
                        {
                            TriggerEnabled = true;
                        }
                        else
                        {
                            TriggerEnabled = false;
                        }
                    }
                    else if (data.Contains("triggerpress,"))
                    {
                        string[] formattedStr = data.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                        if (formattedStr[1] == "on")
                        {
                            TriggerPressOnlyEnabled = true;
                        }
                        else
                        {
                            TriggerPressOnlyEnabled = false;
                        }
                    }
                }

                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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

        #region Some Shit For Loading State
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();
        #endregion
    }
}
