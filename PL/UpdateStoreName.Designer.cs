namespace IFarmer.PL
{
    partial class UpdateStoreName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStoreName));
            this.BtnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.ActiveBorderThickness = 1;
            this.BtnSave.ActiveCornerRadius = 20;
            this.BtnSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.ButtonText = "تحديث";
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.IdleBorderThickness = 1;
            this.BtnSave.IdleCornerRadius = 20;
            this.BtnSave.IdleFillColor = System.Drawing.Color.White;
            this.BtnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Location = new System.Drawing.Point(324, 261);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(211, 50);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم المخزن";
            // 
            // TxtName
            // 
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtName.HintForeColor = System.Drawing.Color.Empty;
            this.TxtName.HintText = "";
            this.TxtName.isPassword = false;
            this.TxtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtName.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtName.LineThickness = 3;
            this.TxtName.Location = new System.Drawing.Point(197, 197);
            this.TxtName.Margin = new System.Windows.Forms.Padding(5);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(432, 54);
            this.TxtName.TabIndex = 7;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UpdateStoreName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 507);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Name = "UpdateStoreName";
            this.Text = "UpdateStoreName";
            this.Load += new System.EventHandler(this.UpdateStoreName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 BtnSave;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtName;
    }
}