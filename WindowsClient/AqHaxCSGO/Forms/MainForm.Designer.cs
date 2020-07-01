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
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.saveButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.keyButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.usagePowerSlider = new System.Windows.Forms.TrackBar();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.bunnySlider = new System.Windows.Forms.TrackBar();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.idlePowerSlider = new System.Windows.Forms.TrackBar();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabController.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctColor)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wearSlider)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usagePowerSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idlePowerSlider)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabPage1);
            this.tabController.Controls.Add(this.tabPage2);
            this.tabController.Controls.Add(this.tabPage3);
            this.tabController.Controls.Add(this.tabPage6);
            this.tabController.Controls.Add(this.tabPage4);
            this.tabController.Controls.Add(this.tabPage5);
            this.tabController.Depth = 0;
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 63);
            this.tabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(661, 267);
            this.tabController.TabIndex = 1;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(653, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visuals";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(183, 208);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(46, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Color";
            // 
            // rColor
            // 
            this.rColor.BackColor = System.Drawing.Color.Red;
            this.rColor.Location = new System.Drawing.Point(228, 206);
            this.rColor.Name = "rColor";
            this.rColor.Size = new System.Drawing.Size(21, 21);
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
            this.materialLabel2.Location = new System.Drawing.Point(181, 55);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(47, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Team";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(173, 19);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Enemy";
            // 
            // tColor
            // 
            this.tColor.BackColor = System.Drawing.Color.Chartreuse;
            this.tColor.Location = new System.Drawing.Point(228, 53);
            this.tColor.Name = "tColor";
            this.tColor.Size = new System.Drawing.Size(21, 21);
            this.tColor.TabIndex = 9;
            this.tColor.TabStop = false;
            this.tColor.Click += new System.EventHandler(this.tColor_Click);
            // 
            // ctColor
            // 
            this.ctColor.BackColor = System.Drawing.Color.Red;
            this.ctColor.Location = new System.Drawing.Point(228, 17);
            this.ctColor.Name = "ctColor";
            this.ctColor.Size = new System.Drawing.Size(21, 21);
            this.ctColor.TabIndex = 8;
            this.ctColor.TabStop = false;
            this.ctColor.Click += new System.EventHandler(this.ctColor_Click);
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(0, 154);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(260, 23);
            this.materialDivider3.TabIndex = 7;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(0, 95);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(260, 23);
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
            this.fresnelCheckBox.Location = new System.Drawing.Point(28, 63);
            this.fresnelCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.fresnelCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fresnelCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fresnelCheckBox.Name = "fresnelCheckBox";
            this.fresnelCheckBox.Ripple = true;
            this.fresnelCheckBox.Size = new System.Drawing.Size(116, 30);
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
            this.fullCheckBox.Location = new System.Drawing.Point(28, 33);
            this.fullCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.fullCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fullCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fullCheckBox.Name = "fullCheckBox";
            this.fullCheckBox.Ripple = true;
            this.fullCheckBox.Size = new System.Drawing.Size(96, 30);
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
            this.enemyCheckBox.Location = new System.Drawing.Point(28, 212);
            this.enemyCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.enemyCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.enemyCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.enemyCheckBox.Name = "enemyCheckBox";
            this.enemyCheckBox.Ripple = true;
            this.enemyCheckBox.Size = new System.Drawing.Size(102, 30);
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
            this.renderColorCheckBox.Location = new System.Drawing.Point(0, 182);
            this.renderColorCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.renderColorCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.renderColorCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.renderColorCheckBox.Name = "renderColorCheckBox";
            this.renderColorCheckBox.Ripple = true;
            this.renderColorCheckBox.Size = new System.Drawing.Size(165, 30);
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
            this.radarCheckBox.Location = new System.Drawing.Point(0, 121);
            this.radarCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.radarCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radarCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.radarCheckBox.Name = "radarCheckBox";
            this.radarCheckBox.Ripple = true;
            this.radarCheckBox.Size = new System.Drawing.Size(66, 30);
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
            this.wallCheckBox.Location = new System.Drawing.Point(3, 3);
            this.wallCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.wallCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.wallCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.wallCheckBox.Name = "wallCheckBox";
            this.wallCheckBox.Ripple = true;
            this.wallCheckBox.Size = new System.Drawing.Size(93, 30);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(653, 241);
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
            this.aimAssistCheckBox.Location = new System.Drawing.Point(2, 211);
            this.aimAssistCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.aimAssistCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.aimAssistCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.aimAssistCheckBox.Name = "aimAssistCheckBox";
            this.aimAssistCheckBox.Ripple = true;
            this.aimAssistCheckBox.Size = new System.Drawing.Size(98, 30);
            this.aimAssistCheckBox.TabIndex = 13;
            this.aimAssistCheckBox.Text = "Aim-Assist";
            this.aimAssistCheckBox.UseVisualStyleBackColor = false;
            this.aimAssistCheckBox.CheckedChanged += new System.EventHandler(this.aimAssistCheckBox_CheckedChanged);
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(3, 185);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(260, 23);
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
            this.holdForTriggerCheckBox.Location = new System.Drawing.Point(27, 152);
            this.holdForTriggerCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.holdForTriggerCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.holdForTriggerCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.holdForTriggerCheckBox.Name = "holdForTriggerCheckBox";
            this.holdForTriggerCheckBox.Ripple = true;
            this.holdForTriggerCheckBox.Size = new System.Drawing.Size(130, 30);
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
            this.triggerBotCheckBox.Location = new System.Drawing.Point(2, 122);
            this.triggerBotCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.triggerBotCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.triggerBotCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.triggerBotCheckBox.Name = "triggerBotCheckBox";
            this.triggerBotCheckBox.Ripple = true;
            this.triggerBotCheckBox.Size = new System.Drawing.Size(100, 30);
            this.triggerBotCheckBox.TabIndex = 10;
            this.triggerBotCheckBox.Text = "Trigger-Bot";
            this.triggerBotCheckBox.UseVisualStyleBackColor = false;
            this.triggerBotCheckBox.CheckedChanged += new System.EventHandler(this.triggerBotCheckBox_CheckedChanged);
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(-7, 96);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(270, 23);
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
            this.recoilControlCheckBox.Location = new System.Drawing.Point(27, 63);
            this.recoilControlCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.recoilControlCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.recoilControlCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.recoilControlCheckBox.Name = "recoilControlCheckBox";
            this.recoilControlCheckBox.Ripple = true;
            this.recoilControlCheckBox.Size = new System.Drawing.Size(116, 30);
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
            this.shootOnCollideCheckBox.Location = new System.Drawing.Point(27, 33);
            this.shootOnCollideCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.shootOnCollideCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.shootOnCollideCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.shootOnCollideCheckBox.Name = "shootOnCollideCheckBox";
            this.shootOnCollideCheckBox.Ripple = true;
            this.shootOnCollideCheckBox.Size = new System.Drawing.Size(149, 30);
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
            this.aimCheckBox.Location = new System.Drawing.Point(2, 3);
            this.aimCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.aimCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.aimCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.aimCheckBox.Name = "aimCheckBox";
            this.aimCheckBox.Ripple = true;
            this.aimCheckBox.Size = new System.Drawing.Size(87, 30);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(653, 241);
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
            this.bunnyHopCheckBox.Location = new System.Drawing.Point(-2, 74);
            this.bunnyHopCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.bunnyHopCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bunnyHopCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.bunnyHopCheckBox.Name = "bunnyHopCheckBox";
            this.bunnyHopCheckBox.Ripple = true;
            this.bunnyHopCheckBox.Size = new System.Drawing.Size(98, 30);
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
            this.antiFlashCheckBox.Location = new System.Drawing.Point(-2, 133);
            this.antiFlashCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.antiFlashCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.antiFlashCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.antiFlashCheckBox.Name = "antiFlashCheckBox";
            this.antiFlashCheckBox.Ripple = true;
            this.antiFlashCheckBox.Size = new System.Drawing.Size(92, 30);
            this.antiFlashCheckBox.TabIndex = 15;
            this.antiFlashCheckBox.Text = "Anti-Flash";
            this.antiFlashCheckBox.UseVisualStyleBackColor = false;
            this.antiFlashCheckBox.CheckedChanged += new System.EventHandler(this.antiFlashCheckBox_CheckedChanged);
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(-4, 107);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(260, 23);
            this.materialDivider6.TabIndex = 14;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.materialCheckBox1);
            this.tabPage6.Controls.Add(this.materialLabel16);
            this.tabPage6.Controls.Add(this.knifeSelectionBox);
            this.tabPage6.Controls.Add(this.seedTextBox);
            this.tabPage6.Controls.Add(this.skinSaveButton);
            this.tabPage6.Controls.Add(this.manualLoadButton);
            this.tabPage6.Controls.Add(this.tagTextBox);
            this.tabPage6.Controls.Add(this.materialLabel15);
            this.tabPage6.Controls.Add(this.wearSlider);
            this.tabPage6.Controls.Add(this.materialLabel14);
            this.tabPage6.Controls.Add(this.materialLabel13);
            this.tabPage6.Controls.Add(this.materialLabel12);
            this.tabPage6.Controls.Add(this.skinSelector);
            this.tabPage6.Controls.Add(this.materialLabel11);
            this.tabPage6.Controls.Add(this.weaponSelector);
            this.tabPage6.Controls.Add(this.skinChangerButton);
            this.tabPage6.Controls.Add(this.knifeChangerButton);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(653, 241);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Skins";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.BackColor = System.Drawing.Color.Maroon;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialCheckBox1.Location = new System.Drawing.Point(0, 214);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(249, 30);
            this.materialCheckBox1.TabIndex = 35;
            this.materialCheckBox1.Text = "Knife Animation Fixer (CPU HEAVY)";
            this.materialCheckBox1.UseVisualStyleBackColor = false;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(2, 130);
            this.materialLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(47, 19);
            this.materialLabel16.TabIndex = 34;
            this.materialLabel16.Text = "Knife:";
            // 
            // knifeSelectionBox
            // 
            this.knifeSelectionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.knifeSelectionBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.knifeSelectionBox.FormattingEnabled = true;
            this.knifeSelectionBox.Location = new System.Drawing.Point(68, 130);
            this.knifeSelectionBox.Name = "knifeSelectionBox";
            this.knifeSelectionBox.Size = new System.Drawing.Size(185, 21);
            this.knifeSelectionBox.TabIndex = 33;
            this.knifeSelectionBox.SelectedIndexChanged += new System.EventHandler(this.knifeSelectionBox_SelectedIndexChanged);
            // 
            // seedTextBox
            // 
            this.seedTextBox.Location = new System.Drawing.Point(68, 45);
            this.seedTextBox.Name = "seedTextBox";
            this.seedTextBox.Size = new System.Drawing.Size(185, 20);
            this.seedTextBox.TabIndex = 32;
            // 
            // skinSaveButton
            // 
            this.skinSaveButton.BackColor = System.Drawing.Color.Transparent;
            this.skinSaveButton.Depth = 0;
            this.skinSaveButton.ForeColor = System.Drawing.Color.Transparent;
            this.skinSaveButton.Location = new System.Drawing.Point(128, 154);
            this.skinSaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.skinSaveButton.Name = "skinSaveButton";
            this.skinSaveButton.Primary = true;
            this.skinSaveButton.Size = new System.Drawing.Size(121, 30);
            this.skinSaveButton.TabIndex = 31;
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
            this.manualLoadButton.Location = new System.Drawing.Point(128, 184);
            this.manualLoadButton.Margin = new System.Windows.Forms.Padding(0);
            this.manualLoadButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.manualLoadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.manualLoadButton.Name = "manualLoadButton";
            this.manualLoadButton.Ripple = true;
            this.manualLoadButton.Size = new System.Drawing.Size(121, 30);
            this.manualLoadButton.TabIndex = 30;
            this.manualLoadButton.Text = "Manual Reload";
            this.manualLoadButton.UseVisualStyleBackColor = false;
            this.manualLoadButton.CheckedChanged += new System.EventHandler(this.manualLoadButton_CheckedChanged);
            // 
            // tagTextBox
            // 
            this.tagTextBox.Location = new System.Drawing.Point(68, 65);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(185, 20);
            this.tagTextBox.TabIndex = 29;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(2, 65);
            this.materialLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(38, 19);
            this.materialLabel15.TabIndex = 28;
            this.materialLabel15.Text = "Tag:";
            // 
            // wearSlider
            // 
            this.wearSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.wearSlider.Location = new System.Drawing.Point(68, 85);
            this.wearSlider.Maximum = 95;
            this.wearSlider.Minimum = 1;
            this.wearSlider.Name = "wearSlider";
            this.wearSlider.Size = new System.Drawing.Size(185, 45);
            this.wearSlider.TabIndex = 27;
            this.wearSlider.Value = 1;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(2, 85);
            this.materialLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(47, 19);
            this.materialLabel14.TabIndex = 26;
            this.materialLabel14.Text = "Wear:";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(2, 45);
            this.materialLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(46, 19);
            this.materialLabel13.TabIndex = 24;
            this.materialLabel13.Text = "Seed:";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(2, 24);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(42, 19);
            this.materialLabel12.TabIndex = 22;
            this.materialLabel12.Text = "Skin:";
            // 
            // skinSelector
            // 
            this.skinSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.skinSelector.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinSelector.FormattingEnabled = true;
            this.skinSelector.Location = new System.Drawing.Point(68, 24);
            this.skinSelector.Name = "skinSelector";
            this.skinSelector.Size = new System.Drawing.Size(185, 21);
            this.skinSelector.TabIndex = 21;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(1, 3);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(67, 19);
            this.materialLabel11.TabIndex = 20;
            this.materialLabel11.Text = "Weapon:";
            // 
            // weaponSelector
            // 
            this.weaponSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.weaponSelector.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.weaponSelector.FormattingEnabled = true;
            this.weaponSelector.Location = new System.Drawing.Point(68, 3);
            this.weaponSelector.Name = "weaponSelector";
            this.weaponSelector.Size = new System.Drawing.Size(185, 21);
            this.weaponSelector.TabIndex = 19;
            // 
            // skinChangerButton
            // 
            this.skinChangerButton.AutoSize = true;
            this.skinChangerButton.BackColor = System.Drawing.Color.Maroon;
            this.skinChangerButton.Depth = 0;
            this.skinChangerButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.skinChangerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.skinChangerButton.Location = new System.Drawing.Point(2, 154);
            this.skinChangerButton.Margin = new System.Windows.Forms.Padding(0);
            this.skinChangerButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.skinChangerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.skinChangerButton.Name = "skinChangerButton";
            this.skinChangerButton.Ripple = true;
            this.skinChangerButton.Size = new System.Drawing.Size(113, 30);
            this.skinChangerButton.TabIndex = 18;
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
            this.knifeChangerButton.Location = new System.Drawing.Point(2, 184);
            this.knifeChangerButton.Margin = new System.Windows.Forms.Padding(0);
            this.knifeChangerButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.knifeChangerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.knifeChangerButton.Name = "knifeChangerButton";
            this.knifeChangerButton.Ripple = true;
            this.knifeChangerButton.Size = new System.Drawing.Size(117, 30);
            this.knifeChangerButton.TabIndex = 17;
            this.knifeChangerButton.Text = "Knife Changer";
            this.knifeChangerButton.UseVisualStyleBackColor = false;
            this.knifeChangerButton.CheckedChanged += new System.EventHandler(this.knifeChangerButton_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.saveButton);
            this.tabPage4.Controls.Add(this.keyButton);
            this.tabPage4.Controls.Add(this.materialLabel10);
            this.tabPage4.Controls.Add(this.usagePowerSlider);
            this.tabPage4.Controls.Add(this.materialLabel9);
            this.tabPage4.Controls.Add(this.bunnySlider);
            this.tabPage4.Controls.Add(this.materialLabel6);
            this.tabPage4.Controls.Add(this.idlePowerSlider);
            this.tabPage4.Controls.Add(this.materialLabel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(653, 241);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Depth = 0;
            this.saveButton.Location = new System.Drawing.Point(137, 210);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Primary = false;
            this.saveButton.Size = new System.Drawing.Size(104, 36);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Apply & Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // keyButton
            // 
            this.keyButton.BackColor = System.Drawing.Color.Transparent;
            this.keyButton.Depth = 0;
            this.keyButton.Location = new System.Drawing.Point(4, 226);
            this.keyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.keyButton.Name = "keyButton";
            this.keyButton.Primary = true;
            this.keyButton.Size = new System.Drawing.Size(112, 23);
            this.keyButton.TabIndex = 18;
            this.keyButton.Text = "Press";
            this.keyButton.UseVisualStyleBackColor = false;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(3, 206);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(117, 19);
            this.materialLabel10.TabIndex = 17;
            this.materialLabel10.Text = "Aim/Trigger Key";
            // 
            // usagePowerSlider
            // 
            this.usagePowerSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.usagePowerSlider.Location = new System.Drawing.Point(18, 91);
            this.usagePowerSlider.Maximum = 4;
            this.usagePowerSlider.Name = "usagePowerSlider";
            this.usagePowerSlider.Size = new System.Drawing.Size(210, 45);
            this.usagePowerSlider.TabIndex = 16;
            this.usagePowerSlider.Value = 4;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(25, 69);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(197, 19);
            this.materialLabel9.TabIndex = 15;
            this.materialLabel9.Text = "Power Consumption On Use";
            // 
            // bunnySlider
            // 
            this.bunnySlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bunnySlider.Location = new System.Drawing.Point(18, 158);
            this.bunnySlider.Maximum = 4;
            this.bunnySlider.Name = "bunnySlider";
            this.bunnySlider.Size = new System.Drawing.Size(210, 45);
            this.bunnySlider.TabIndex = 14;
            this.bunnySlider.Value = 4;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(68, 136);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(115, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Bunny Accuracy";
            // 
            // idlePowerSlider
            // 
            this.idlePowerSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.idlePowerSlider.Location = new System.Drawing.Point(18, 22);
            this.idlePowerSlider.Maximum = 4;
            this.idlePowerSlider.Name = "idlePowerSlider";
            this.idlePowerSlider.Size = new System.Drawing.Size(210, 45);
            this.idlePowerSlider.TabIndex = 12;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(37, 0);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(173, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Idle Power Consumption";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialLabel8);
            this.tabPage5.Controls.Add(this.materialLabel7);
            this.tabPage5.Controls.Add(this.materialLabel20);
            this.tabPage5.Controls.Add(this.materialLabel19);
            this.tabPage5.Controls.Add(this.materialLabel18);
            this.tabPage5.Controls.Add(this.materialLabel17);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(653, 241);
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
            this.materialLabel8.Location = new System.Drawing.Point(-1, 19);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(267, 133);
            this.materialLabel8.TabIndex = 11;
            this.materialLabel8.Text = resources.GetString("materialLabel8.Text");
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(76, 0);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(97, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "AqHax-CSGO";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel20.Location = new System.Drawing.Point(0, 233);
            this.materialLabel20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(262, 19);
            this.materialLabel20.TabIndex = 9;
            this.materialLabel20.Text = "Copyright © 2019 All Rights Reserved.";
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(27, 214);
            this.materialLabel19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(200, 19);
            this.materialLabel19.TabIndex = 8;
            this.materialLabel19.Text = "Made By: KRXDevelops-Kaan";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(0, 184);
            this.materialLabel18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(261, 19);
            this.materialLabel18.TabIndex = 7;
            this.materialLabel18.Text = "I\'m not resposible for any kind of ban.";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(80, 165);
            this.materialLabel17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(99, 19);
            this.materialLabel17.TabIndex = 6;
            this.materialLabel17.Text = "DISCLAIMER:";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabController;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 25);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(661, 38);
            this.materialTabSelector1.TabIndex = 7;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 330);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.materialTabSelector1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.Sizable = false;
            this.Text = "AQHax";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyEvent);
            this.tabController.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctColor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wearSlider)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usagePowerSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunnySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idlePowerSlider)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TrackBar idlePowerSlider;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TrackBar bunnySlider;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private System.Windows.Forms.TrackBar usagePowerSlider;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialRaisedButton keyButton;
        private MaterialSkin.Controls.MaterialFlatButton saveButton;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialCheckBox skinChangerButton;
        private MaterialSkin.Controls.MaterialCheckBox knifeChangerButton;
        private System.Windows.Forms.ComboBox weaponSelector;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.ComboBox skinSelector;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialCheckBox manualLoadButton;
        private System.Windows.Forms.TextBox tagTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private System.Windows.Forms.TrackBar wearSlider;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialRaisedButton skinSaveButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private System.Windows.Forms.ComboBox knifeSelectionBox;
        private System.Windows.Forms.TextBox seedTextBox;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}

