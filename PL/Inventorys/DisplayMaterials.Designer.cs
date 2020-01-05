namespace IFarmer.PL
{
    partial class DisplayMaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayMaterials));
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bntMatUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(488, 64);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(370, 44);
            this.bunifuMaterialTextbox1.TabIndex = 4;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 472);
            this.dataGridView1.TabIndex = 5;
            // 
            // bntMatUpdate
            // 
            this.bntMatUpdate.ActiveBorderThickness = 1;
            this.bntMatUpdate.ActiveCornerRadius = 20;
            this.bntMatUpdate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bntMatUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.bntMatUpdate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bntMatUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bntMatUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntMatUpdate.BackgroundImage")));
            this.bntMatUpdate.ButtonText = "تعديل";
            this.bntMatUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntMatUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMatUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.bntMatUpdate.IdleBorderThickness = 1;
            this.bntMatUpdate.IdleCornerRadius = 20;
            this.bntMatUpdate.IdleFillColor = System.Drawing.Color.White;
            this.bntMatUpdate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bntMatUpdate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bntMatUpdate.Location = new System.Drawing.Point(525, 593);
            this.bntMatUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.bntMatUpdate.Name = "bntMatUpdate";
            this.bntMatUpdate.Size = new System.Drawing.Size(302, 41);
            this.bntMatUpdate.TabIndex = 12;
            this.bntMatUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntMatUpdate.Click += new System.EventHandler(this.bntMatUpdate_Click);
            // 
            // DisplayMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 659);
            this.Controls.Add(this.bntMatUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Name = "DisplayMaterials";
            this.Text = "DisplayMaterials";
            this.Load += new System.EventHandler(this.DisplayMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 bntMatUpdate;
    }
}