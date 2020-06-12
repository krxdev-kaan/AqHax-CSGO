using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Timers;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Windows.Forms;
using AqHaxCSGO.MemoryManagers;
using AqHaxCSGO.Objects;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System.Net;
using SlimDX.DirectInput;
using System.Threading;
using AqHaxCSGO.Misc;
using AqHaxCSGO.Objects.Structs;

namespace AqHaxCSGO
{
    public partial class MainForm : MaterialForm
    {
        private bool IsWaitingForInput = false;
        private int currentKey = 16;
        KeysConverter keyConverter = new KeysConverter();

        System.Timers.Timer timer = new System.Timers.Timer();

        public MainForm()
        {
            InitializeComponent();
            AllocConsole();

            #region VERSION CHECK
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            int[] versionParts = { fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart };
            int[] latestVersion = GetVersion();

            if (latestVersion[0] != 0) 
            {
                if (latestVersion[0] > versionParts[0])
                {
                    DialogResult dr = MessageBox.Show("New version of AqHax-CSGO is available. Would you like to update ?", "New Version !", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes) 
                    {
                        Process.Start("https://github.com/krxdev-kaan/AqHax-CSGO/releases");
                    }
                }
                else if (latestVersion[0] == versionParts[0]) 
                {
                    if (latestVersion[1] > versionParts[1])
                    {
                        DialogResult dr = MessageBox.Show("New version of AqHax-CSGO is available. Would you like to update ?", "New Version !", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            Process.Start("https://github.com/krxdev-kaan/AqHax-CSGO/releases");
                        }
                    }
                    else if (latestVersion[1] == versionParts[1])
                    {
                        if (latestVersion[2] > versionParts[2])
                        {
                            DialogResult dr = MessageBox.Show("New version of AqHax-CSGO is available. Would you like to update ?", "New Version !", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                Process.Start("https://github.com/krxdev-kaan/AqHax-CSGO/releases");
                            }
                        }
                    }
                }
            }
            #endregion
            
            #region CUSTOM RENDER
                        GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ctColor.Width, ctColor.Height);
            ctColor.Region = new Region(path);

            GraphicsPath path2 = new GraphicsPath();
            path2.AddEllipse(0, 0, tColor.Width, tColor.Height);
            tColor.Region = new Region(path2);

            GraphicsPath path3 = new GraphicsPath();
            path3.AddEllipse(0, 0, rColor.Width, rColor.Height);
            rColor.Region = new Region(path3);
            #endregion

            #region HANDLE SAVES
            #region Visuals Data
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string programDataPath = Path.Combine(appDataPath, "AqHaxCSGO");
            string fullSavePath = Path.Combine(programDataPath, "CSG.dat");
            try
            {
                string[] lines = File.ReadAllLines(fullSavePath);
                if (lines.Length == 0) 
                {
                    File.WriteAllLines(fullSavePath, new string[] { "00", "255000000", "000255000", "255000000" });
                    lines = File.ReadAllLines(fullSavePath);
                }
                Color colorCT = new Color();
                Color colorT = new Color();
                Color colorR = new Color();
                int p = 0;
                foreach (string line in lines)
                {
                    if (p == 1)
                    {
                        colorCT = Color.FromArgb(Convert.ToInt32(line.Substring(0, 3)), Convert.ToInt32(line.Substring(3, 3)), Convert.ToInt32(line.Substring(6, 3)));
                    }
                    if (p == 2)
                    {
                        colorT = Color.FromArgb(Convert.ToInt32(line.Substring(0, 3)), Convert.ToInt32(line.Substring(3, 3)), Convert.ToInt32(line.Substring(6, 3)));
                    }
                    if (p == 3)
                    {
                        colorR = Color.FromArgb(Convert.ToInt32(line.Substring(0, 3)), Convert.ToInt32(line.Substring(3, 3)), Convert.ToInt32(line.Substring(6, 3)));
                    }
                    p++;
                }

                ctColor.BackColor = colorCT;
                tColor.BackColor = colorT;
                rColor.BackColor = colorR;
                Globals.WallHackEnemy = colorCT;
                Globals.WallHackTeammate = colorT;
                Globals.RenderColor = colorR;
            }
            catch 
            {
                try
                {
                    try
                    {
                        File.Create(fullSavePath);
                        File.WriteAllLines(fullSavePath, new string[] { "00", "255000000", "000255000", "255000000" });
                    }
                    catch 
                    {
                        Directory.CreateDirectory(programDataPath);
                        File.Create(fullSavePath);
                        File.WriteAllLines(fullSavePath, new string[] { "00", "255000000", "000255000", "255000000" });
                    }
                }
                catch
                {
                    MessageBox.Show("IO Error. \nApp save file cannot be initialized. \nRunning the program again should shortly fix th issue.",
                                    "FATAL ERROR");
                    Environment.Exit(1);
                }
            }
            #endregion

            #region Settings
            SaveManager.SettingsScheme settings = SaveManager.LoadSettings();
            Globals.BunnyHopAccuracy = Math.Abs(settings.BunnyAccuracy - 5);
            Globals.IdleWait = Math.Abs(settings.IdlePowerConsumption - 50) / 10;
            Globals.UsageDelay = Math.Abs(settings.UsagePowerConsumption - 5);
            Globals.TriggerKey = settings.TriggerKey;
            currentKey = settings.TriggerKey;
            #endregion

            #region SkinChangerPresets
            LoadSkins();
            #endregion
            #endregion

            #region HANDLE FORM ELEMENTS
            List<string> res = Globals.CsgoSkinList.Keys.ToList();
            res.Sort();
            foreach (string s in res) skinSelector.Items.Add(s);

            List<string> ids = Enum.GetNames(typeof(ItemDefinitionIndex)).ToList();
            foreach (string s in ids) if(s.Contains("WEAPON")) weaponSelector.Items.Add(s);

            List<string> knives = Constants.KnifeList.Keys.ToList();
            foreach (string s in knives) knifeSelectionBox.Items.Add(s);
            #endregion

            #region SETUP
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
            #endregion

            #region EVENT REGISTER
            this.FormClosing += new FormClosingEventHandler(AppEx);

            timer.Elapsed += new ElapsedEventHandler(UpdateHandle);
            timer.Interval = 90000;
            timer.Start();
            #endregion
        }

        private int[] GetVersion()
        {
            try
            {
                using (var webC = new WebClient())
                {
                    webC.Headers.Add("User-Agent", "request");
                    string json = webC.DownloadString("https://api.github.com/repos/krxdev-kaan/AqHax-CSGO/releases");
                    JsonTextReader reader = new JsonTextReader(new StringReader(json));
                    while (reader.Read())
                    {
                        if (reader.Value != null)
                        {
                            if (reader.TokenType == JsonToken.PropertyName)
                            {
                                if (reader.Value.ToString() == "tag_name")
                                {
                                    reader.Read();
                                    string version = reader.Value.ToString();
                                    string int_ified = version.Substring(1);
                                    string[] splitted = int_ified.Split('.');
                                    int[] result = new int[3];
                                    for (int i = 0; i < splitted.Length; i++)
                                    {
                                        result[i] = Convert.ToInt32(splitted[i]);
                                    }
                                    return result;
                                }
                            }
                        }
                    }
                    return new int[] { 0, 0, 0 };
                }
            }
            catch 
            {
                return new int[] { 0, 0, 0 };
            }
        }

        private void LoadSkins()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourcePath = "AqHaxCSGO.Resources.Skins.dat";

            using (StreamReader reader = new StreamReader(assembly.GetManifestResourceStream(resourcePath)))
            {
                while (!reader.EndOfStream)
                {
                    string raw = reader.ReadLine();
                    string[] splitted = raw.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    int count = 0;
                    foreach (SkinObj s in Globals.CsgoSkinList.Values) 
                    {
                        if (s.SkinName == splitted[1]) 
                        {
                            count += 1;
                        }
                    }
                    Globals.CsgoSkinList.Add(splitted[1] + (count == 0 ? "" : count.ToString()), new Misc.SkinObj(Convert.ToInt32(splitted[0]), splitted[1]));
                }
            }
        }

        #region Events
        private void AppEx(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            if (IsWaitingForInput) 
            {
                currentKey = e.KeyValue;
                keyButton.Text = e.KeyCode.ToString();
                IsWaitingForInput = false;
            }
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            NetvarManager.LoadOffsets();
            OffsetManager.ScanOffsets();
            Threads.InitAll();
            FreeConsole();
            NetvarManager.netvarList.Clear();
        }
        #endregion

        #region User Events
        private void tabChangeLeft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabController.TabPages.Count; i++) 
            {
                if (tabController.TabPages[i] == tabController.SelectedTab) 
                {
                    tabController.SelectTab(i-1 >= 0 ? i - 1 : tabController.TabPages.Count - 1);
                    tabLabel.Text = tabController.TabPages[i - 1 >= 0 ? i - 1 : tabController.TabPages.Count - 1].Text;
                    tabLabel.Location = new Point(this.Size.Width / 2 - tabLabel.Width / 2, tabLabel.Location.Y);

                    if (tabLabel.Text.Contains("Settings")) 
                    {
                        bunnySlider.Value = Math.Abs(Globals.BunnyHopAccuracy - 5);
                        idlePowerSlider.Value = Math.Abs(Globals.IdleWait - 50) / 10;
                        usagePowerSlider.Value = Math.Abs(Globals.UsageDelay - 5);
                        keyButton.Text = keyConverter.ConvertToString(Globals.TriggerKey).Replace("İ", "I");
                    }
                    break;
                }
            }
        }

        private void tabChangeRight_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabController.TabPages.Count; i++)
            {
                if (tabController.TabPages[i] == tabController.SelectedTab)
                {
                    tabController.SelectTab(i + 1 < tabController.TabPages.Count ? i + 1 : 0);
                    tabLabel.Text = tabController.TabPages[i + 1 < tabController.TabPages.Count ? i + 1 : 0].Text;
                    tabLabel.Location = new Point(this.Size.Width / 2 - tabLabel.Width / 2, tabLabel.Location.Y);

                    if (tabLabel.Text.Contains("Settings"))
                    {
                        bunnySlider.Value = Math.Abs(Globals.BunnyHopAccuracy - 5);
                        idlePowerSlider.Value = Math.Abs(Globals.IdleWait - 50) / 10;
                        usagePowerSlider.Value = Math.Abs(Globals.UsageDelay - 5);
                        keyButton.Text = keyConverter.ConvertToString(Globals.TriggerKey).Replace("İ", "I");
                    }
                    break;
                }
            }
        }

        private void wallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.WallHackEnabled = !Globals.WallHackEnabled;
        }

        private void fullCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.WallHackFullEnabled = !Globals.WallHackFullEnabled;
        }

        private void fresnelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.WallHackGlowOnly = !Globals.WallHackGlowOnly;
        }

        private void radarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.RadarEnabled = !Globals.RadarEnabled;
        }

        private void renderColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.RenderEnabled = !Globals.RenderEnabled;
        }

        private void enemyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.RenderEnemyOnly = !Globals.RenderEnemyOnly;
        }

        private void ctColor_Click(object sender, EventArgs e)
        {
            ColorDialog clrDialog = new ColorDialog();
            Color c = new Color();

            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                c = clrDialog.Color;
            }

            string r = ToFormedColor(c.R.ToString());
            string g = ToFormedColor(c.G.ToString());
            string b = ToFormedColor(c.B.ToString());

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string programDataPath = Path.Combine(appDataPath, "AqHaxCSGO");
            string fullSavePath = Path.Combine(programDataPath, "CSG.dat");
            string[] lines = File.ReadAllLines(fullSavePath);
            lines[1] = r + g + b;
            File.WriteAllLines(fullSavePath, lines);

            int r2 = Convert.ToInt32(r);
            int g2 = Convert.ToInt32(g);
            int b2 = Convert.ToInt32(b);

            ctColor.BackColor = Color.FromArgb(r2, g2, b2);

            Globals.WallHackEnemy = Color.FromArgb(r2, g2, b2);
        }

        private void tColor_Click(object sender, EventArgs e)
        {
            ColorDialog clrDialog = new ColorDialog();
            Color c = new Color();

            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                c = clrDialog.Color;
            }

            string r = ToFormedColor(c.R.ToString());
            string g = ToFormedColor(c.G.ToString());
            string b = ToFormedColor(c.B.ToString());

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string programDataPath = Path.Combine(appDataPath, "AqHaxCSGO");
            string fullSavePath = Path.Combine(programDataPath, "CSG.dat");
            string[] lines = File.ReadAllLines(fullSavePath);
            lines[2] = r + g + b;
            File.WriteAllLines(fullSavePath, lines);

            int r2 = Convert.ToInt32(r);
            int g2 = Convert.ToInt32(g);
            int b2 = Convert.ToInt32(b);

            tColor.BackColor = Color.FromArgb(r2, g2, b2);

            Globals.WallHackTeammate = Color.FromArgb(r2, g2, b2);
        }

        private void rColor_Click(object sender, EventArgs e)
        {
            ColorDialog clrDialog = new ColorDialog();
            Color c = new Color();

            if (clrDialog.ShowDialog() == DialogResult.OK)
            {
                c = clrDialog.Color;
            }

            string r = ToFormedColor(c.R.ToString());
            string g = ToFormedColor(c.G.ToString());
            string b = ToFormedColor(c.B.ToString());

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string programDataPath = Path.Combine(appDataPath, "AqHaxCSGO");
            string fullSavePath = Path.Combine(programDataPath, "CSG.dat");
            string[] lines = File.ReadAllLines(fullSavePath);
            lines[3] = r + g + b;
            File.WriteAllLines(fullSavePath, lines);

            int r2 = Convert.ToInt32(r);
            int g2 = Convert.ToInt32(g);
            int b2 = Convert.ToInt32(b);

            rColor.BackColor = Color.FromArgb(r2, g2, b2);

            Globals.RenderColor = Color.FromArgb(r2, g2, b2);
        }

        string ToFormedColor(string f)
        {
            if (f.Length == 2)
            {
                f = "0" + f;
                return f;
            }
            else if (f.Length == 1)
            {
                f = "00" + f;
                return f;
            }
            else
            {
                return f;
            }
        }

        private void aimCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.AimEnabled = !Globals.AimEnabled;
            if (Globals.AimEnabled)
            {
                triggerBotCheckBox.Checked = false;
            }
        }

        private void shootOnCollideCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.AimShootOnCollide = !Globals.AimShootOnCollide;
        }

        private void recoilControlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.AimRecoil = !Globals.AimRecoil;
        }

        private void triggerBotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.TriggerEnabled = !Globals.TriggerEnabled;
            if (Globals.TriggerEnabled)
            {
                aimCheckBox.Checked = false;
            }
        }

        private void holdForTriggerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.TriggerPressOnlyEnabled = !Globals.TriggerPressOnlyEnabled;
        }

        private void aimAssistCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet because im not sure if i want to add it right now.");
        }

        private void bunnyHopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.BunnyHopEnabled = !Globals.BunnyHopEnabled;
        }

        private void antiFlashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Globals.AntiFlashEnabled = !Globals.AntiFlashEnabled;
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            IsWaitingForInput = !IsWaitingForInput;
            keyButton.Text = "Press any key..";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsWaitingForInput) 
            {
                MessageBox.Show("Aim/Trigger Key undefined.", "Error");
                return;
            }

            Globals.TriggerKey = currentKey;
            Globals.BunnyHopAccuracy = bunnySlider.Value;
            Globals.IdleWait = idlePowerSlider.Value;
            Globals.UsageDelay = usagePowerSlider.Value;

            SaveManager.SettingsScheme settings = new SaveManager.SettingsScheme();
            settings.BunnyAccuracy = Globals.BunnyHopAccuracy;
            settings.IdlePowerConsumption = Globals.IdleWait;
            settings.UsagePowerConsumption = Globals.UsageDelay;
            settings.TriggerKey = Globals.TriggerKey;
            SaveManager.SaveSettings(settings);
        }

        private void skinChangerButton_CheckedChanged(object sender, EventArgs e)
        {
            Globals.SkinChangerEnabled = !Globals.SkinChangerEnabled;
        }

        private void knifeChangerButton_CheckedChanged(object sender, EventArgs e)
        {
            Globals.KnifeChangerEnabled = !Globals.KnifeChangerEnabled;
        }

        private void manualLoadButton_CheckedChanged(object sender, EventArgs e)
        {
            Globals.ManualLoadEnabled = !Globals.ManualLoadEnabled;
        }

        private void skinSaveButton_Click(object sender, EventArgs e)
        {
            //IMPLEMENT TOMORROW
        }

        private void knifeSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.SelectedKnife = (string)knifeSelectionBox.SelectedItem;
            Console.WriteLine(Globals.SelectedKnife);
        }
        #endregion

        #region Some Shit For Loading State
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();
        #endregion
    }
}
