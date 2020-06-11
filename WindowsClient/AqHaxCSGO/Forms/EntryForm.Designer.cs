namespace AqHaxCSGO
{
    partial class EntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.launcherButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.initButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.progressOfLaunch = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
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
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "AqHax-CSGO";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 34);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(220, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "CSGO Disconnected/Not Found";
            // 
            // launcherButton
            // 
            this.launcherButton.Depth = 0;
            this.launcherButton.Location = new System.Drawing.Point(55, 152);
            this.launcherButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.launcherButton.Name = "launcherButton";
            this.launcherButton.Primary = true;
            this.launcherButton.Size = new System.Drawing.Size(140, 36);
            this.launcherButton.TabIndex = 9;
            this.launcherButton.Text = "Launch The Game";
            this.launcherButton.UseVisualStyleBackColor = true;
            this.launcherButton.Click += new System.EventHandler(this.launcherButton_Click);
            // 
            // initButton
            // 
            this.initButton.Depth = 0;
            this.initButton.Location = new System.Drawing.Point(18, 218);
            this.initButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.initButton.Name = "initButton";
            this.initButton.Primary = true;
            this.initButton.Size = new System.Drawing.Size(222, 36);
            this.initButton.TabIndex = 10;
            this.initButton.Text = "Connect to launched game";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // progressOfLaunch
            // 
            this.progressOfLaunch.Location = new System.Drawing.Point(12, 326);
            this.progressOfLaunch.Name = "progressOfLaunch";
            this.progressOfLaunch.Size = new System.Drawing.Size(228, 11);
            this.progressOfLaunch.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressOfLaunch.TabIndex = 11;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 349);
            this.Controls.Add(this.progressOfLaunch);
            this.Controls.Add(this.initButton);
            this.Controls.Add(this.launcherButton);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EntryForm";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton launcherButton;
        private MaterialSkin.Controls.MaterialRaisedButton initButton;
        private System.Windows.Forms.ProgressBar progressOfLaunch;
    }
}