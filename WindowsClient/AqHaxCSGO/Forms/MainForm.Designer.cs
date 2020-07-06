namespace AqHaxCSGO
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabController = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.renderBrightnessSlider = new System.Windows.Forms.TrackBar();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.fullBloomSlider = new System.Windows.Forms.TrackBar();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.rColor = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tColor = new System.Windows.Forms.PictureBox();
            this.ctColor = new System.Windows.Forms.PictureBox();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.fresnelCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.fullCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.enemyCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.renderColorCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.radarCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.wallCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aimAssistCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.holdForTriggerCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.triggerBotCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.recoilControlCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.shootOnCollideCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.aimCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bunnyHopCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.antiFlashCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.knifeAnimationFixerButton = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.knifeSelectionBox = new System.Windows.Forms.ComboBox();
            this.seedTextBox = new System.Windows.Forms.TextBox();
            this.skinSaveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.manualLoadButton = new MaterialSkin.Controls.MaterialCheckBox();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.wearSlider = new System.Windows.Forms.TrackBar();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.skinSelector = new System.Windows.Forms.ComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.weaponSelector = new System.Windows.Forms.ComboBox();
            this.skinChangerButton = new MaterialSkin.Controls.MaterialCheckBox();
            this.knifeChangerButton = new MaterialSkin.Controls.MaterialCheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.saveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.keyButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.usagePowerSlider = new System.Windows.Forms.TrackBar();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.bunnySlider = new System.Windows.Forms.TrackBar();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.idlePowerSlider = new System.Windows.Forms.TrackBar();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabController.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renderBrightnessSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullBloomSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctColor)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wearSlider)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usagePowerSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idlePowerSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabPage1);
            this.tabController.Controls.Add(this.tabPage2);
            this.tabController.Controls.Add(this.tabPage3);
            this.tabController.Controls.Add(this.tabPage4);
            this.tabController.Controls.Add(this.tabPage5);
            this.tabController.Controls.Add(this.tabPage6);
            this.tabController.Depth = 0;
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 121);
            this.tabController.Margin = new System.Windows.Forms.Padding(6);
            this.tabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1166, 546);
            this.tabController.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialLabel22);
            this.tabPage1.Controls.Add(this.renderBrightnessSlider);
            this.tabPage1.Controls.Add(this.materialLabel21);
            this.tabPage1.Controls.Add(this.fullBloomSlider);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.rColor);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.tColor);
            this.tabPage1.Controls.Add(this.ctColor);
            this.tabPage1.Controls.Add(this.materialDivider3);
            this.tabPage1.Controls.Add(this.materialDivider2);
            this.tabPage1.Controls.Add(this.fresnelCheckBox);
            this.tabPage1.Controls.Add(this.fullCheckBox);
            this.tabPage1.Controls.Add(this.enemyCheckBox);
            this.tabPage1.Controls.Add(this.renderColorCheckBox);
            this.tabPage1.Controls.Add(this.radarCheckBox);
            this.tabPage1.Controls.Add(this.wallCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1150, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visuals";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel22.Location = new System.Drawing.Point(654, 359);
            this.materialLabel22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(261, 37);
            this.materialLabel22.TabIndex = 54;
            this.materialLabel22.Text = "Render Brightness";
            // 
            // renderBrightnessSlider
            // 
            this.renderBrightnessSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.renderBrightnessSlider.Location = new System.Drawing.Point(592, 411);
            this.renderBrightnessSlider.Margin = new System.Windows.Forms.Padding(6);
            this.renderBrightnessSlider.Maximum = 8;
            this.renderBrightnessSlider.Minimum = 1;
            this.renderBrightnessSlider.Name = "renderBrightnessSlider";
            this.renderBrightnessSlider.Size = new System.Drawing.Size(370, 90);
            this.renderBrightnessSlider.TabIndex = 53;
            this.renderBrightnessSlider.Value = 1;
            this.renderBrightnessSlider.Scroll += new System.EventHandler(this.renderBrightnessSlider_Scroll);
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel21.Location = new System.Drawing.Point(640, 27);
            this.materialLabel21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(279, 37);
            this.materialLabel21.TabIndex = 52;
            this.materialLabel21.Text = "Full Bloom Intensity";
            // 
            // fullBloomSlider
            // 
            this.fullBloomSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.fullBloomSlider.Location = new System.Drawing.Point(592, 85);
            this.fullBloomSlider.Margin = new System.Windows.Forms.Padding(6);
            this.fullBloomSlider.Minimum = 1;
            this.fullBloomSlider.Name = "fullBloomSlider";
            this.fullBloomSlider.Size = new System.Drawing.Size(370, 90);
            this.fullBloomSlider.TabIndex = 46;
            this.fullBloomSlider.Value = 10;
            this.fullBloomSlider.Scroll += new System.EventHandler(this.fullBloomSlider_Scroll);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(1006, 390);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(88, 37);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Color";
            // 
            // rColor
            // 
            this.rColor.BackColor = System.Drawing.Color.Red;
            this.rColor.Location = new System.Drawing.Point(1096, 387);
            this.rColor.Margin = new System.Windows.Forms.Padding(6);
            this.rColor.Name = "rColor";
            this.rColor.Size = new System.Drawing.Size(42, 40);
            this.rColor.TabIndex = 12;
            this.rColor.TabStop = false;
            this.rColor.Click += new System.EventHandler(this.rColor_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(992, 92);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(93, 37);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Team";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(986, 27);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 37);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Enemy";
            // 
            // tColor
            // 
            this.tColor.BackColor = System.Drawing.Color.Chartreuse;
            this.tColor.Location = new System.Drawing.Point(1096, 92);
            this.tColor.Margin = new System.Windows.Forms.Padding(6);
            this.tColor.Name = "tColor";
            this.tColor.Size = new System.Drawing.Size(42, 40);
            this.tColor.TabIndex = 9;
            this.tColor.TabStop = false;
            this.tColor.Click += new System.EventHandler(this.tColor_Click);
            // 
            // ctColor
            // 
            this.ctColor.BackColor = System.Drawing.Color.Red;
            this.ctColor.Location = new System.Drawing.Point(1096, 23);
            this.ctColor.Margin = new System.Windows.Forms.Padding(6);
            this.ctColor.Name = "ctColor";
            this.ctColor.Size = new System.Drawing.Size(42, 40);
            this.ctColor.TabIndex = 8;
            this.ctColor.TabStop = false;
            this.ctColor.Click += new System.EventHandler(this.ctColor_Click);
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(0, 296);
            this.materialDivider3.Margin = new System.Windows.Forms.Padding(6);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(1176, 44);
            this.materialDivider3.TabIndex = 7;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 183);
            this.materialDivider2.Margin = new System.Windows.Forms.Padding(6);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1176, 44);
            this.materialDivider2.TabIndex = 6;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // fresnelCheckBox
            // 
            this.fresnelCheckBox.AutoSize = true;
            this.fresnelCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.fresnelCheckBox.Depth = 0;
            this.fresnelCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.fresnelCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fresnelCheckBox.Location = new System.Drawing.Point(56, 121);
            this.fresnelCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.fresnelCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fresnelCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fresnelCheckBox.Name = "fresnelCheckBox";
            this.fresnelCheckBox.Ripple = true;
            this.fresnelCheckBox.Size = new System.Drawing.Size(207, 30);
            this.fresnelCheckBox.TabIndex = 5;
            this.fresnelCheckBox.Text = "Fresnel-Effect";
            this.fresnelCheckBox.UseVisualStyleBackColor = false;
            this.fresnelCheckBox.CheckedChanged += new System.EventHandler(this.fresnelCheckBox_CheckedChanged);
            // 
            // fullCheckBox
            // 
            this.fullCheckBox.AutoSize = true;
            this.fullCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.fullCheckBox.Depth = 0;
            this.fullCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.fullCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fullCheckBox.Location = new System.Drawing.Point(56, 63);
            this.fullCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.fullCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fullCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fullCheckBox.Name = "fullCheckBox";
            this.fullCheckBox.Ripple = true;
            this.fullCheckBox.Size = new System.Drawing.Size(167, 30);
            this.fullCheckBox.TabIndex = 4;
            this.fullCheckBox.Text = "Full-Bloom";
            this.fullCheckBox.UseVisualStyleBackColor = false;
            this.fullCheckBox.CheckedChanged += new System.EventHandler(this.fullCheckBox_CheckedChanged);
            // 
            // enemyCheckBox
            // 
            this.enemyCheckBox.AutoSize = true;
            this.enemyCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.enemyCheckBox.Depth = 0;
            this.enemyCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.enemyCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enemyCheckBox.Location = new System.Drawing.Point(56, 408);
            this.enemyCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.enemyCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.enemyCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.enemyCheckBox.Name = "enemyCheckBox";
            this.enemyCheckBox.Ripple = true;
            this.enemyCheckBox.Size = new System.Drawing.Size(179, 30);
            this.enemyCheckBox.TabIndex = 3;
            this.enemyCheckBox.Text = "Enemy Only";
            this.enemyCheckBox.UseVisualStyleBackColor = false;
            this.enemyCheckBox.CheckedChanged += new System.EventHandler(this.enemyCheckBox_CheckedChanged);
            // 
            // renderColorCheckBox
            // 
            this.renderColorCheckBox.AutoSize = true;
            this.renderColorCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.renderColorCheckBox.Depth = 0;
            this.renderColorCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.renderColorCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.renderColorCheckBox.Location = new System.Drawing.Point(0, 350);
            this.renderColorCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.renderColorCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.renderColorCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.renderColorCheckBox.Name = "renderColorCheckBox";
            this.renderColorCheckBox.Ripple = true;
            this.renderColorCheckBox.Size = new System.Drawing.Size(304, 30);
            this.renderColorCheckBox.TabIndex = 2;
            this.renderColorCheckBox.Text = "Render Color Changer";
            this.renderColorCheckBox.UseVisualStyleBackColor = false;
            this.renderColorCheckBox.CheckedChanged += new System.EventHandler(this.renderColorCheckBox_CheckedChanged);
            // 
            // radarCheckBox
            // 
            this.radarCheckBox.AutoSize = true;
            this.radarCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.radarCheckBox.Depth = 0;
            this.radarCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.radarCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radarCheckBox.Location = new System.Drawing.Point(0, 233);
            this.radarCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.radarCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radarCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.radarCheckBox.Name = "radarCheckBox";
            this.radarCheckBox.Ripple = true;
            this.radarCheckBox.Size = new System.Drawing.Size(106, 30);
            this.radarCheckBox.TabIndex = 1;
            this.radarCheckBox.Text = "Radar";
            this.radarCheckBox.UseVisualStyleBackColor = false;
            this.radarCheckBox.CheckedChanged += new System.EventHandler(this.radarCheckBox_CheckedChanged);
            // 
            // wallCheckBox
            // 
            this.wallCheckBox.AutoSize = true;
            this.wallCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.wallCheckBox.Depth = 0;
            this.wallCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.wallCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wallCheckBox.Location = new System.Drawing.Point(6, 6);
            this.wallCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.wallCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.wallCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.wallCheckBox.Name = "wallCheckBox";
            this.wallCheckBox.Ripple = true;
            this.wallCheckBox.Size = new System.Drawing.Size(160, 30);
            this.wallCheckBox.TabIndex = 0;
            this.wallCheckBox.Text = "Wall-Hack";
            this.wallCheckBox.UseVisualStyleBackColor = false;
            this.wallCheckBox.CheckedChanged += new System.EventHandler(this.wallCheckBox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.aimAssistCheckBox);
            this.tabPage2.Controls.Add(this.materialDivider5);
            this.tabPage2.Controls.Add(this.holdForTriggerCheckBox);
            this.tabPage2.Controls.Add(this.triggerBotCheckBox);
            this.tabPage2.Controls.Add(this.materialDivider4);
            this.tabPage2.Controls.Add(this.recoilControlCheckBox);
            this.tabPage2.Controls.Add(this.shootOnCollideCheckBox);
            this.tabPage2.Controls.Add(this.aimCheckBox);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1150, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aimbot";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // aimAssistCheckBox
            // 
            this.aimAssistCheckBox.AutoSize = true;
            this.aimAssistCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.aimAssistCheckBox.Depth = 0;
            this.aimAssistCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.aimAssistCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aimAssistCheckBox.Location = new System.Drawing.Point(4, 406);
            this.aimAssistCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.aimAssistCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.aimAssistCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.aimAssistCheckBox.Name = "aimAssistCheckBox";
            this.aimAssistCheckBox.Ripple = true;
            this.aimAssistCheckBox.Size = new System.Drawing.Size(170, 30);
            this.aimAssistCheckBox.TabIndex = 13;
            this.aimAssistCheckBox.Text = "Aim-Assist";
            this.aimAssistCheckBox.UseVisualStyleBackColor = false;
            this.aimAssistCheckBox.CheckedChanged += new System.EventHandler(this.aimAssistCheckBox_CheckedChanged);
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(6, 356);
            this.materialDivider5.Margin = new System.Windows.Forms.Padding(6);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(1174, 44);
            this.materialDivider5.TabIndex = 12;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // holdForTriggerCheckBox
            // 
            this.holdForTriggerCheckBox.AutoSize = true;
            this.holdForTriggerCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.holdForTriggerCheckBox.Depth = 0;
            this.holdForTriggerCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.holdForTriggerCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.holdForTriggerCheckBox.Location = new System.Drawing.Point(54, 292);
            this.holdForTriggerCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.holdForTriggerCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.holdForTriggerCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.holdForTriggerCheckBox.Name = "holdForTriggerCheckBox";
            this.holdForTriggerCheckBox.Ripple = true;
            this.holdForTriggerCheckBox.Size = new System.Drawing.Size(235, 30);
            this.holdForTriggerCheckBox.TabIndex = 11;
            this.holdForTriggerCheckBox.Text = "Hold For Trigger";
            this.holdForTriggerCheckBox.UseVisualStyleBackColor = false;
            this.holdForTriggerCheckBox.CheckedChanged += new System.EventHandler(this.holdForTriggerCheckBox_CheckedChanged);
            // 
            // triggerBotCheckBox
            // 
            this.triggerBotCheckBox.AutoSize = true;
            this.triggerBotCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.triggerBotCheckBox.Depth = 0;
            this.triggerBotCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.triggerBotCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.triggerBotCheckBox.Location = new System.Drawing.Point(4, 235);
            this.triggerBotCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.triggerBotCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.triggerBotCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.triggerBotCheckBox.Name = "triggerBotCheckBox";
            this.triggerBotCheckBox.Ripple = true;
            this.triggerBotCheckBox.Size = new System.Drawing.Size(174, 30);
            this.triggerBotCheckBox.TabIndex = 10;
            this.triggerBotCheckBox.Text = "Trigger-Bot";
            this.triggerBotCheckBox.UseVisualStyleBackColor = false;
            this.triggerBotCheckBox.CheckedChanged += new System.EventHandler(this.triggerBotCheckBox_CheckedChanged);
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(-14, 185);
            this.materialDivider4.Margin = new System.Windows.Forms.Padding(6);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(1194, 44);
            this.materialDivider4.TabIndex = 9;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // recoilControlCheckBox
            // 
            this.recoilControlCheckBox.AutoSize = true;
            this.recoilControlCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.recoilControlCheckBox.Depth = 0;
            this.recoilControlCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.recoilControlCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recoilControlCheckBox.Location = new System.Drawing.Point(54, 121);
            this.recoilControlCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.recoilControlCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.recoilControlCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.recoilControlCheckBox.Name = "recoilControlCheckBox";
            this.recoilControlCheckBox.Ripple = true;
            this.recoilControlCheckBox.Size = new System.Drawing.Size(207, 30);
            this.recoilControlCheckBox.TabIndex = 8;
            this.recoilControlCheckBox.Text = "Control Recoil";
            this.recoilControlCheckBox.UseVisualStyleBackColor = false;
            this.recoilControlCheckBox.CheckedChanged += new System.EventHandler(this.recoilControlCheckBox_CheckedChanged);
            // 
            // shootOnCollideCheckBox
            // 
            this.shootOnCollideCheckBox.AutoSize = true;
            this.shootOnCollideCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.shootOnCollideCheckBox.Depth = 0;
            this.shootOnCollideCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.shootOnCollideCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shootOnCollideCheckBox.Location = new System.Drawing.Point(54, 63);
            this.shootOnCollideCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.shootOnCollideCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.shootOnCollideCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.shootOnCollideCheckBox.Name = "shootOnCollideCheckBox";
            this.shootOnCollideCheckBox.Ripple = true;
            this.shootOnCollideCheckBox.Size = new System.Drawing.Size(273, 30);
            this.shootOnCollideCheckBox.TabIndex = 7;
            this.shootOnCollideCheckBox.Text = "Shoot When Visible";
            this.shootOnCollideCheckBox.UseVisualStyleBackColor = false;
            this.shootOnCollideCheckBox.CheckedChanged += new System.EventHandler(this.shootOnCollideCheckBox_CheckedChanged);
            // 
            // aimCheckBox
            // 
            this.aimCheckBox.AutoSize = true;
            this.aimCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.aimCheckBox.Depth = 0;
            this.aimCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.aimCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aimCheckBox.Location = new System.Drawing.Point(4, 6);
            this.aimCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.aimCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.aimCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.aimCheckBox.Name = "aimCheckBox";
            this.aimCheckBox.Ripple = true;
            this.aimCheckBox.Size = new System.Drawing.Size(148, 30);
            this.aimCheckBox.TabIndex = 6;
            this.aimCheckBox.Text = "Rage-Bot";
            this.aimCheckBox.UseVisualStyleBackColor = false;
            this.aimCheckBox.CheckedChanged += new System.EventHandler(this.aimCheckBox_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bunnyHopCheckBox);
            this.tabPage3.Controls.Add(this.antiFlashCheckBox);
            this.tabPage3.Controls.Add(this.materialDivider6);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1150, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Misc";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bunnyHopCheckBox
            // 
            this.bunnyHopCheckBox.AutoSize = true;
            this.bunnyHopCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.bunnyHopCheckBox.Depth = 0;
            this.bunnyHopCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.bunnyHopCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunnyHopCheckBox.Location = new System.Drawing.Point(-4, 142);
            this.bunnyHopCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.bunnyHopCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bunnyHopCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.bunnyHopCheckBox.Name = "bunnyHopCheckBox";
            this.bunnyHopCheckBox.Ripple = true;
            this.bunnyHopCheckBox.Size = new System.Drawing.Size(171, 30);
            this.bunnyHopCheckBox.TabIndex = 16;
            this.bunnyHopCheckBox.Text = "Bunny-Hop";
            this.bunnyHopCheckBox.UseVisualStyleBackColor = false;
            this.bunnyHopCheckBox.CheckedChanged += new System.EventHandler(this.bunnyHopCheckBox_CheckedChanged);
            // 
            // antiFlashCheckBox
            // 
            this.antiFlashCheckBox.AutoSize = true;
            this.antiFlashCheckBox.BackColor = System.Drawing.Color.Maroon;
            this.antiFlashCheckBox.Depth = 0;
            this.antiFlashCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.antiFlashCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.antiFlashCheckBox.Location = new System.Drawing.Point(-4, 256);
            this.antiFlashCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.antiFlashCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.antiFlashCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.antiFlashCheckBox.Name = "antiFlashCheckBox";
            this.antiFlashCheckBox.Ripple = true;
            this.antiFlashCheckBox.Size = new System.Drawing.Size(159, 30);
            this.antiFlashCheckBox.TabIndex = 15;
            this.antiFlashCheckBox.Text = "Anti-Flash";
            this.antiFlashCheckBox.UseVisualStyleBackColor = false;
            this.antiFlashCheckBox.CheckedChanged += new System.EventHandler(this.antiFlashCheckBox_CheckedChanged);
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(-8, 206);
            this.materialDivider6.Margin = new System.Windows.Forms.Padding(6);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(1188, 44);
            this.materialDivider6.TabIndex = 14;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.knifeAnimationFixerButton);
            this.tabPage4.Controls.Add(this.materialLabel16);
            this.tabPage4.Controls.Add(this.knifeSelectionBox);
            this.tabPage4.Controls.Add(this.seedTextBox);
            this.tabPage4.Controls.Add(this.skinSaveButton);
            this.tabPage4.Controls.Add(this.manualLoadButton);
            this.tabPage4.Controls.Add(this.tagTextBox);
            this.tabPage4.Controls.Add(this.materialLabel15);
            this.tabPage4.Controls.Add(this.wearSlider);
            this.tabPage4.Controls.Add(this.materialLabel14);
            this.tabPage4.Controls.Add(this.materialLabel13);
            this.tabPage4.Controls.Add(this.materialLabel12);
            this.tabPage4.Controls.Add(this.skinSelector);
            this.tabPage4.Controls.Add(this.materialLabel11);
            this.tabPage4.Controls.Add(this.weaponSelector);
            this.tabPage4.Controls.Add(this.skinChangerButton);
            this.tabPage4.Controls.Add(this.knifeChangerButton);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1150, 499);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Skins";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // knifeAnimationFixerButton
            // 
            this.knifeAnimationFixerButton.AutoSize = true;
            this.knifeAnimationFixerButton.BackColor = System.Drawing.Color.Maroon;
            this.knifeAnimationFixerButton.Depth = 0;
            this.knifeAnimationFixerButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.knifeAnimationFixerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.knifeAnimationFixerButton.Location = new System.Drawing.Point(610, 333);
            this.knifeAnimationFixerButton.Margin = new System.Windows.Forms.Padding(0);
            this.knifeAnimationFixerButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.knifeAnimationFixerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.knifeAnimationFixerButton.Name = "knifeAnimationFixerButton";
            this.knifeAnimationFixerButton.Ripple = true;
            this.knifeAnimationFixerButton.Size = new System.Drawing.Size(473, 30);
            this.knifeAnimationFixerButton.TabIndex = 52;
            this.knifeAnimationFixerButton.Text = "Knife Animation Fixer (CPU HEAVY)";
            this.knifeAnimationFixerButton.UseVisualStyleBackColor = false;
            this.knifeAnimationFixerButton.CheckedChanged += new System.EventHandler(this.knifeAnimationFixerButton_CheckedChanged);
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(4, 406);
            this.materialLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(93, 37);
            this.materialLabel16.TabIndex = 51;
            this.materialLabel16.Text = "Knife:";
            // 
            // knifeSelectionBox
            // 
            this.knifeSelectionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.knifeSelectionBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.knifeSelectionBox.FormattingEnabled = true;
            this.knifeSelectionBox.Location = new System.Drawing.Point(136, 406);
            this.knifeSelectionBox.Margin = new System.Windows.Forms.Padding(6);
            this.knifeSelectionBox.Name = "knifeSelectionBox";
            this.knifeSelectionBox.Size = new System.Drawing.Size(366, 33);
            this.knifeSelectionBox.TabIndex = 50;
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(136, 181);
            this.seedTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(366, 31);
            this.seedTextBox.TabIndex = 49;
            // 
            // skinSaveButton
            // 
            this.skinSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.skinSaveButton.Depth = 0;
            this.skinSaveButton.ForeColor = System.Drawing.Color.Transparent;
            this.skinSaveButton.Location = new System.Drawing.Point(866, 77);
            this.skinSaveButton.Margin = new System.Windows.Forms.Padding(6);
            this.skinSaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.skinSaveButton.Name = "skinSaveButton";
            this.skinSaveButton.Primary = true;
            this.skinSaveButton.Size = new System.Drawing.Size(242, 58);
            this.skinSaveButton.TabIndex = 48;
            this.skinSaveButton.Text = "Apply & Save";
            this.skinSaveButton.UseVisualStyleBackColor = false;
            this.skinSaveButton.Click += new System.EventHandler(this.skinSaveButton_Click);
            // 
            // manualLoadButton
            // 
            this.manualLoadButton.AutoSize = true;
            this.manualLoadButton.BackColor = System.Drawing.Color.Maroon;
            this.manualLoadButton.Depth = 0;
            this.manualLoadButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.manualLoadButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manualLoadButton.Location = new System.Drawing.Point(866, 206);
            this.manualLoadButton.Margin = new System.Windows.Forms.Padding(0);
            this.manualLoadButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.manualLoadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.manualLoadButton.Name = "manualLoadButton";
            this.manualLoadButton.Ripple = true;
            this.manualLoadButton.Size = new System.Drawing.Size(217, 30);
            this.manualLoadButton.TabIndex = 47;
            this.manualLoadButton.Text = "Manual Reload";
            this.manualLoadButton.UseVisualStyleBackColor = false;
            this.manualLoadButton.CheckedChanged += new System.EventHandler(this.manualLoadButton_CheckedChanged);
            // 
            // tagTextBox
            // 
            this.tagTextBox.Location = new System.Drawing.Point(136, 252);
            this.tagTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(366, 31);
            this.tagTextBox.TabIndex = 46;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(4, 252);
            this.materialLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(75, 37);
            this.materialLabel15.TabIndex = 45;
            this.materialLabel15.Text = "Tag:";
            // 
            // wearSlider
            // 
            this.wearSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.wearSlider.Location = new System.Drawing.Point(136, 319);
            this.wearSlider.Margin = new System.Windows.Forms.Padding(6);
            this.wearSlider.Maximum = 95;
            this.wearSlider.Minimum = 1;
            this.wearSlider.Name = "wearSlider";
            this.wearSlider.Size = new System.Drawing.Size(370, 90);
            this.wearSlider.TabIndex = 44;
            this.wearSlider.Value = 1;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(4, 319);
            this.materialLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(93, 37);
            this.materialLabel14.TabIndex = 43;
            this.materialLabel14.Text = "Wear:";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(4, 181);
            this.materialLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(91, 37);
            this.materialLabel13.TabIndex = 42;
            this.materialLabel13.Text = "Seed:";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(4, 112);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(81, 37);
            this.materialLabel12.TabIndex = 41;
            this.materialLabel12.Text = "Skin:";
            // 
            // skinSelector
            // 
            this.skinSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinSelector.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinSelector.FormattingEnabled = true;
            this.skinSelector.Location = new System.Drawing.Point(136, 112);
            this.skinSelector.Margin = new System.Windows.Forms.Padding(6);
            this.skinSelector.Name = "skinSelector";
            this.skinSelector.Size = new System.Drawing.Size(366, 33);
            this.skinSelector.TabIndex = 40;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(2, 44);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(134, 37);
            this.materialLabel11.TabIndex = 39;
            this.materialLabel11.Text = "Weapon:";
            // 
            // weaponSelector
            // 
            this.weaponSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.weaponSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weaponSelector.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.weaponSelector.FormattingEnabled = true;
            this.weaponSelector.Location = new System.Drawing.Point(136, 44);
            this.weaponSelector.Margin = new System.Windows.Forms.Padding(6);
            this.weaponSelector.Name = "weaponSelector";
            this.weaponSelector.Size = new System.Drawing.Size(366, 33);
            this.weaponSelector.TabIndex = 38;
            // 
            // skinChangerButton
            // 
            this.skinChangerButton.AutoSize = true;
            this.skinChangerButton.BackColor = System.Drawing.Color.Maroon;
            this.skinChangerButton.Depth = 0;
            this.skinChangerButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.skinChangerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skinChangerButton.Location = new System.Drawing.Point(614, 77);
            this.skinChangerButton.Margin = new System.Windows.Forms.Padding(0);
            this.skinChangerButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.skinChangerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.skinChangerButton.Name = "skinChangerButton";
            this.skinChangerButton.Ripple = true;
            this.skinChangerButton.Size = new System.Drawing.Size(200, 30);
            this.skinChangerButton.TabIndex = 37;
            this.skinChangerButton.Text = "Skin-Changer";
            this.skinChangerButton.UseVisualStyleBackColor = false;
            this.skinChangerButton.CheckedChanged += new System.EventHandler(this.skinChangerButton_CheckedChanged);
            // 
            // knifeChangerButton
            // 
            this.knifeChangerButton.AutoSize = true;
            this.knifeChangerButton.BackColor = System.Drawing.Color.Maroon;
            this.knifeChangerButton.Depth = 0;
            this.knifeChangerButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.knifeChangerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.knifeChangerButton.Location = new System.Drawing.Point(614, 206);
            this.knifeChangerButton.Margin = new System.Windows.Forms.Padding(0);
            this.knifeChangerButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.knifeChangerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.knifeChangerButton.Name = "knifeChangerButton";
            this.knifeChangerButton.Ripple = true;
            this.knifeChangerButton.Size = new System.Drawing.Size(209, 30);
            this.knifeChangerButton.TabIndex = 36;
            this.knifeChangerButton.Text = "Knife Changer";
            this.knifeChangerButton.UseVisualStyleBackColor = false;
            this.knifeChangerButton.CheckedChanged += new System.EventHandler(this.knifeChangerButton_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialLabel8);
            this.tabPage5.Controls.Add(this.materialLabel7);
            this.tabPage5.Controls.Add(this.materialLabel20);
            this.tabPage5.Controls.Add(this.materialLabel19);
            this.tabPage5.Controls.Add(this.materialLabel18);
            this.tabPage5.Controls.Add(this.materialLabel17);
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1150, 499);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "About";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(62, 90);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(1001, 148);
            this.materialLabel8.TabIndex = 11;
            this.materialLabel8.Text = resources.GetString("materialLabel8.Text");
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(474, 19);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(193, 37);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "AqHax-CSGO";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(314, 433);
            this.materialLabel20.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(522, 37);
            this.materialLabel20.TabIndex = 9;
            this.materialLabel20.Text = "Copyright © 2019 All Rights Reserved.";
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(368, 396);
            this.materialLabel19.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(401, 37);
            this.materialLabel19.TabIndex = 8;
            this.materialLabel19.Text = "Made By: KRXDevelops-Kaan";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(314, 338);
            this.materialLabel18.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(511, 37);
            this.materialLabel18.TabIndex = 7;
            this.materialLabel18.Text = "I\'m not resposible for any kind of ban.";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(474, 302);
            this.materialLabel17.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(195, 37);
            this.materialLabel17.TabIndex = 6;
            this.materialLabel17.Text = "DISCLAIMER:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.saveButton);
            this.tabPage6.Controls.Add(this.keyButton);
            this.tabPage6.Controls.Add(this.materialLabel10);
            this.tabPage6.Controls.Add(this.usagePowerSlider);
            this.tabPage6.Controls.Add(this.materialLabel9);
            this.tabPage6.Controls.Add(this.bunnySlider);
            this.tabPage6.Controls.Add(this.materialLabel6);
            this.tabPage6.Controls.Add(this.idlePowerSlider);
            this.tabPage6.Controls.Add(this.materialLabel5);
            this.tabPage6.Location = new System.Drawing.Point(8, 39);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1150, 499);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Settings";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Depth = 0;
            this.saveButton.Location = new System.Drawing.Point(884, 190);
            this.saveButton.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Primary = false;
            this.saveButton.Size = new System.Drawing.Size(201, 36);
            this.saveButton.TabIndex = 44;
            this.saveButton.Text = "Apply & Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // keyButton
            // 
            this.keyButton.BackColor = System.Drawing.Color.Transparent;
            this.keyButton.Depth = 0;
            this.keyButton.Location = new System.Drawing.Point(74, 235);
            this.keyButton.Margin = new System.Windows.Forms.Padding(6);
            this.keyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.keyButton.Name = "keyButton";
            this.keyButton.Primary = true;
            this.keyButton.Size = new System.Drawing.Size(224, 44);
            this.keyButton.TabIndex = 43;
            this.keyButton.Text = "Press";
            this.keyButton.UseVisualStyleBackColor = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(66, 171);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(233, 37);
            this.materialLabel10.TabIndex = 42;
            this.materialLabel10.Text = "Aim/Trigger Key";
            // 
            // usagePowerSlider
            // 
            this.usagePowerSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.usagePowerSlider.Location = new System.Drawing.Point(372, 213);
            this.usagePowerSlider.Margin = new System.Windows.Forms.Padding(6);
            this.usagePowerSlider.Maximum = 4;
            this.usagePowerSlider.Name = "usagePowerSlider";
            this.usagePowerSlider.Size = new System.Drawing.Size(420, 90);
            this.usagePowerSlider.TabIndex = 41;
            this.usagePowerSlider.Value = 4;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(386, 171);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(391, 37);
            this.materialLabel9.TabIndex = 40;
            this.materialLabel9.Text = "Power Consumption On Use";
            // 
            // bunnySlider
            // 
            this.bunnySlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunnySlider.Location = new System.Drawing.Point(372, 365);
            this.bunnySlider.Margin = new System.Windows.Forms.Padding(6);
            this.bunnySlider.Maximum = 4;
            this.bunnySlider.Name = "bunnySlider";
            this.bunnySlider.Size = new System.Drawing.Size(420, 90);
            this.bunnySlider.TabIndex = 39;
            this.bunnySlider.Value = 4;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(472, 323);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(233, 37);
            this.materialLabel6.TabIndex = 38;
            this.materialLabel6.Text = "Bunny Accuracy";
            // 
            // idlePowerSlider
            // 
            this.idlePowerSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.idlePowerSlider.Location = new System.Drawing.Point(372, 63);
            this.idlePowerSlider.Margin = new System.Windows.Forms.Padding(6);
            this.idlePowerSlider.Maximum = 4;
            this.idlePowerSlider.Name = "idlePowerSlider";
            this.idlePowerSlider.Size = new System.Drawing.Size(420, 90);
            this.idlePowerSlider.TabIndex = 37;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(410, 21);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(344, 37);
            this.materialLabel5.TabIndex = 36;
            this.materialLabel5.Text = "Idle Power Consumption";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(4, 4);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(193, 37);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "AqHax-CSGO";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabController;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 48);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(6);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1166, 73);
            this.materialTabSelector1.TabIndex = 7;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 667);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.materialTabSelector1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 48, 0, 0);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AqHax-CSGO";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyEvent);
            this.tabController.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renderBrightnessSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullBloomSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctColor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wearSlider)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usagePowerSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idlePowerSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tabController;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialCheckBox wallCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox renderColorCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox radarCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox fullCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox enemyCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox fresnelCheckBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private System.Windows.Forms.PictureBox ctColor;
        private System.Windows.Forms.PictureBox tColor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.PictureBox rColor;
        private MaterialSkin.Controls.MaterialCheckBox recoilControlCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox shootOnCollideCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox aimCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox holdForTriggerCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox triggerBotCheckBox;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialCheckBox aimAssistCheckBox;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialCheckBox bunnyHopCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox antiFlashCheckBox;
        private MaterialSkin.Controls.MaterialDivider materialDivider6;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialCheckBox knifeAnimationFixerButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private System.Windows.Forms.ComboBox knifeSelectionBox;
        private System.Windows.Forms.TextBox seedTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton skinSaveButton;
        private MaterialSkin.Controls.MaterialCheckBox manualLoadButton;
        private System.Windows.Forms.TextBox tagTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private System.Windows.Forms.TrackBar wearSlider;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.ComboBox skinSelector;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.ComboBox weaponSelector;
        private MaterialSkin.Controls.MaterialCheckBox skinChangerButton;
        private MaterialSkin.Controls.MaterialCheckBox knifeChangerButton;
        private MaterialSkin.Controls.MaterialFlatButton saveButton;
        private MaterialSkin.Controls.MaterialRaisedButton keyButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.TrackBar usagePowerSlider;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.TrackBar bunnySlider;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TrackBar idlePowerSlider;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TrackBar fullBloomSlider;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private System.Windows.Forms.TrackBar renderBrightnessSlider;
    }
}

