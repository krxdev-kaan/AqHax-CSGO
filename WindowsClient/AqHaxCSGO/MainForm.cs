using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AqHaxCSGO.MemoryManagers;
using AqHaxCSGO.Objects;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AqHaxCSGO
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, ctColor.Width, ctColor.Height);
            ctColor.Region = new Region(path);

            System.Drawing.Drawing2D.GraphicsPath path2 = new System.Drawing.Drawing2D.GraphicsPath();
            path2.AddEllipse(0, 0, tColor.Width, tColor.Height);
            tColor.Region = new Region(path2);

            System.Drawing.Drawing2D.GraphicsPath path3 = new System.Drawing.Drawing2D.GraphicsPath();
            path3.AddEllipse(0, 0, rColor.Width, rColor.Height);
            rColor.Region = new Region(path3);

            #region HANDLE SAVES
            string[] lines = File.ReadAllLines("CSG.dat");
            Color colorCT = new Color();
            Color colorT = new Color();
            Color colorR = new Color();
            int p = 0;
            foreach (string line in lines)
            {
                //if (p == 0) trigk = Convert.ToInt32(line);
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
            #endregion

            if (!Memory.Init())
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Red600, Accent.Red200, TextShade.WHITE);
            }
            else 
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green900, Primary.Green600, Accent.Green200, TextShade.WHITE);
            }

            
            Application.ApplicationExit += new EventHandler(AppEx);
        }

        private void AppEx(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OffsetManager.DownloadOffsets();
            Threads.InitAll();
        }

        private void tabChangeLeft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabController.TabPages.Count; i++) 
            {
                if (tabController.TabPages[i] == tabController.SelectedTab) 
                {
                    tabController.SelectTab(i-1 >= 0 ? i - 1 : tabController.TabPages.Count - 1);
                    tabLabel.Text = tabController.TabPages[i - 1 >= 0 ? i - 1 : tabController.TabPages.Count - 1].Text;
                    tabLabel.Location = new Point(this.Size.Width / 2 - tabLabel.Width / 2, tabLabel.Location.Y);
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

            string[] lines = File.ReadAllLines("CSG.dat");
            lines[1] = r + g + b;
            File.WriteAllLines("CSG.dat", lines);

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

            string[] lines = File.ReadAllLines("CSG.dat");
            lines[2] = r + g + b;
            File.WriteAllLines("CSG.dat", lines);

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

            string[] lines = File.ReadAllLines("CSG.dat");
            lines[3] = r + g + b;
            File.WriteAllLines("CSG.dat", lines);

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

        }

        private void shootOnCollideCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void recoilControlCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void triggerBotCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void holdForTriggerCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aimAssistCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
