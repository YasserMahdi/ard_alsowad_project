namespace IFarmer.PL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BtnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TxtPassCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.ActiveBorderThickness = 1;
            this.BtnLogin.ActiveCornerRadius = 20;
            this.BtnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.BtnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.BackgroundImage")));
            this.BtnLogin.ButtonText = "LOGIN";
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnLogin.IdleBorderThickness = 1;
            this.BtnLogin.IdleCornerRadius = 20;
            this.BtnLogin.IdleFillColor = System.Drawing.Color.White;
            this.BtnLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnLogin.Location = new System.Drawing.Point(599, 402);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(200, 41);
            this.BtnLogin.TabIndex = 11;
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click_1);
            // 
            // TxtPassCode
            // 
            this.TxtPassCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtPassCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPassCode.HintForeColor = System.Drawing.Color.Empty;
            this.TxtPassCode.HintText = "";
            this.TxtPassCode.isPassword = false;
            this.TxtPassCode.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtPassCode.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtPassCode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtPassCode.LineThickness = 3;
            this.TxtPassCode.Location = new System.Drawing.Point(599, 329);
            this.TxtPassCode.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassCode.Name = "TxtPassCode";
            this.TxtPassCode.Size = new System.Drawing.Size(203, 44);
            this.TxtPassCode.TabIndex = 10;
            this.TxtPassCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUserName.HintForeColor = System.Drawing.Color.Empty;
            this.TxtUserName.HintText = "";
            this.TxtUserName.isPassword = false;
            this.TxtUserName.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtUserName.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtUserName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtUserName.LineThickness = 3;
            this.TxtUserName.Location = new System.Drawing.Point(599, 277);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(203, 44);
            this.TxtUserName.TabIndex = 9;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassCode);
            this.Controls.Add(this.TxtUserName);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 BtnLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPassCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUserName;
    }
}