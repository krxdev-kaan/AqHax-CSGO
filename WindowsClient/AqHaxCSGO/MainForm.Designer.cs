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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tabChangeRight = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabChangeLeft = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.rColor = new System.Windows.Forms.PictureBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabController.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rColor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tabPage1);
            this.tabController.Controls.Add(this.tabPage2);
            this.tabController.Controls.Add(this.tabPage3);
            this.tabController.Depth = 0;
            this.tabController.Location = new System.Drawing.Point(0, 62);
            this.tabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(257, 268);
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(249, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wall-Hack";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(210, 42);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(18, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "T";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(200, 7);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(28, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "CT";
            // 
            // tColor
            // 
            this.tColor.BackColor = System.Drawing.Color.Chartreuse;
            this.tColor.Location = new System.Drawing.Point(228, 42);
            this.tColor.Name = "tColor";
            this.tColor.Size = new System.Drawing.Size(21, 21);
            this.tColor.TabIndex = 9;
            this.tColor.TabStop = false;
            this.tColor.Click += new System.EventHandler(this.tColor_Click);
            // 
            // ctColor
            // 
            this.ctColor.BackColor = System.Drawing.Color.Red;
            this.ctColor.Location = new System.Drawing.Point(228, 6);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(249, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Aim-Hack";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(249, 242);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Misc";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabLabel
            // 
            this.tabLabel.AutoSize = true;
            this.tabLabel.BackColor = System.Drawing.Color.Transparent;
            this.tabLabel.Depth = 0;
            this.tabLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tabLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabLabel.Location = new System.Drawing.Point(90, 29);
            this.tabLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabLabel.Name = "tabLabel";
            this.tabLabel.Size = new System.Drawing.Size(77, 19);
            this.tabLabel.TabIndex = 2;
            this.tabLabel.Text = "Wall-Hack";
            this.tabLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Cyan;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.materialDivider1.Location = new System.Drawing.Point(72, 51);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(113, 3);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // tabChangeRight
            // 
            this.tabChangeRight.Depth = 0;
            this.tabChangeRight.FlatAppearance.BorderSize = 0;
            this.tabChangeRight.Location = new System.Drawing.Point(191, 26);
            this.tabChangeRight.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabChangeRight.Name = "tabChangeRight";
            this.tabChangeRight.Primary = true;
            this.tabChangeRight.Size = new System.Drawing.Size(35, 35);
            this.tabChangeRight.TabIndex = 4;
            this.tabChangeRight.Text = ">";
            this.tabChangeRight.UseVisualStyleBackColor = true;
            this.tabChangeRight.Click += new System.EventHandler(this.tabChangeRight_Click);
            // 
            // tabChangeLeft
            // 
            this.tabChangeLeft.Depth = 0;
            this.tabChangeLeft.Location = new System.Drawing.Point(31, 26);
            this.tabChangeLeft.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabChangeLeft.Name = "tabChangeLeft";
            this.tabChangeLeft.Primary = true;
            this.tabChangeLeft.Size = new System.Drawing.Size(35, 35);
            this.tabChangeLeft.TabIndex = 5;
            this.tabChangeLeft.Text = "<";
            this.tabChangeLeft.UseVisualStyleBackColor = true;
            this.tabChangeLeft.Click += new System.EventHandler(this.tabChangeLeft_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(182, 206);
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
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(2, 2);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(97, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "AqHax-CSGO";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 330);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.tabChangeLeft);
            this.Controls.Add(this.tabChangeRight);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.tabLabel);
            this.Controls.Add(this.tabController);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabController.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rColor)).EndInit();
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
        private MaterialSkin.Controls.MaterialLabel tabLabel;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton tabChangeRight;
        private MaterialSkin.Controls.MaterialRaisedButton tabChangeLeft;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private System.Windows.Forms.PictureBox ctColor;
        private System.Windows.Forms.PictureBox tColor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.PictureBox rColor;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}

