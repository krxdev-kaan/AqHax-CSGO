using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using AqHaxCSGO.MemoryManagers;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using AqHaxCSGO.Objects;

namespace AqHaxCSGO
{
    public partial class EntryForm : MaterialForm
    {
        public EntryForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red900, Primary.Red600, Accent.Red200, TextShade.WHITE);
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
        }

        private void launcherButton_Click(object sender, EventArgs e)
        {
            Process.Start("steam://rungameid/730");
        }

        private void initButton_Click(object sender, EventArgs e)
        {
            if ((Process.GetProcessesByName("csgo").Length > 0))
            {
                this.Visible = false;
                new MainForm().Show();
            }
        }
    }
}
