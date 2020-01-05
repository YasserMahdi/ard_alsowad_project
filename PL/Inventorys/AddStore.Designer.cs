namespace IFarmer.PL
{
    partial class UpdateStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStore));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 5;
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
            this.TxtName.Location = new System.Drawing.Point(210, 250);
            this.TxtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(432, 54);
            this.TxtName.TabIndex = 4;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.BtnSave.ButtonText = "اضافة";
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.IdleBorderThickness = 1;
            this.BtnSave.IdleCornerRadius = 20;
            this.BtnSave.IdleFillColor = System.Drawing.Color.White;
            this.BtnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Location = new System.Drawing.Point(337, 315);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(211, 50);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // UpdateStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateStore";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.Text = "AddStore";
            this.Load += new System.EventHandler(this.UpdateStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtName;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnSave;
    }
}