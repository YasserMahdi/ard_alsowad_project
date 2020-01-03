namespace IFarmer.PL
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.BtnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TxtPassCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtFullName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboUserType = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRegister
            // 
            this.BtnRegister.ActiveBorderThickness = 1;
            this.BtnRegister.ActiveCornerRadius = 20;
            this.BtnRegister.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnRegister.ActiveForecolor = System.Drawing.Color.White;
            this.BtnRegister.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnRegister.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegister.BackgroundImage")));
            this.BtnRegister.ButtonText = "REGISTER";
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnRegister.IdleBorderThickness = 1;
            this.BtnRegister.IdleCornerRadius = 20;
            this.BtnRegister.IdleFillColor = System.Drawing.Color.White;
            this.BtnRegister.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnRegister.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnRegister.Location = new System.Drawing.Point(311, 360);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(5);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(181, 41);
            this.BtnRegister.TabIndex = 3;
            this.BtnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // TxtPassCode
            // 
            this.TxtPassCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.TxtPassCode.Location = new System.Drawing.Point(215, 204);
            this.TxtPassCode.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassCode.Name = "TxtPassCode";
            this.TxtPassCode.Size = new System.Drawing.Size(370, 44);
            this.TxtPassCode.TabIndex = 2;
            this.TxtPassCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.TxtUserName.Location = new System.Drawing.Point(215, 152);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(370, 44);
            this.TxtUserName.TabIndex = 1;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFullName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtFullName.HintForeColor = System.Drawing.Color.Empty;
            this.TxtFullName.HintText = "";
            this.TxtFullName.isPassword = false;
            this.TxtFullName.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtFullName.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtFullName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtFullName.LineThickness = 3;
            this.TxtFullName.Location = new System.Drawing.Point(215, 100);
            this.TxtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(370, 44);
            this.TxtFullName.TabIndex = 0;
            this.TxtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "الاسم الكامل";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم الستخدم";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "كلمة السر";
            // 
            // ComboUserType
            // 
            this.ComboUserType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboUserType.FormattingEnabled = true;
            this.ComboUserType.ItemHeight = 24;
            this.ComboUserType.Location = new System.Drawing.Point(215, 276);
            this.ComboUserType.Name = "ComboUserType";
            this.ComboUserType.Size = new System.Drawing.Size(370, 30);
            this.ComboUserType.TabIndex = 7;
            this.ComboUserType.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "نوع المستخدم";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboUserType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFullName);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.TxtPassCode);
            this.Controls.Add(this.TxtUserName);
            this.Name = "Register";
            this.Text = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 BtnRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPassCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox ComboUserType;
        private System.Windows.Forms.Label label4;
    }
}