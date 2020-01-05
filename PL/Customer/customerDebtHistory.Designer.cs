namespace IFarmer.PL
{
    partial class customerDebtHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerDebtHistory));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BntPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(12, 91);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 26;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(871, 320);
            this.bunifuCustomDataGrid1.TabIndex = 0;
            this.bunifuCustomDataGrid1.DoubleClick += new System.EventHandler(this.bunifuCustomDataGrid1_DoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "الخروج";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.White;
            this.btnClose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(248, 425);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BntPrint
            // 
            this.BntPrint.ActiveBorderThickness = 1;
            this.BntPrint.ActiveCornerRadius = 20;
            this.BntPrint.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BntPrint.ActiveForecolor = System.Drawing.Color.White;
            this.BntPrint.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BntPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BntPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BntPrint.BackgroundImage")));
            this.BntPrint.ButtonText = "طباعة";
            this.BntPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BntPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntPrint.ForeColor = System.Drawing.Color.SeaGreen;
            this.BntPrint.IdleBorderThickness = 1;
            this.BntPrint.IdleCornerRadius = 20;
            this.BntPrint.IdleFillColor = System.Drawing.Color.White;
            this.BntPrint.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BntPrint.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BntPrint.Location = new System.Drawing.Point(439, 425);
            this.BntPrint.Margin = new System.Windows.Forms.Padding(5);
            this.BntPrint.Name = "BntPrint";
            this.BntPrint.Size = new System.Drawing.Size(181, 41);
            this.BntPrint.TabIndex = 4;
            this.BntPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BntPrint.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // customerDebtHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 477);
            this.Controls.Add(this.BntPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "customerDebtHistory";
            this.Text = "CustomerDebtHistory";
            this.Load += new System.EventHandler(this.customerDebtHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 BntPrint;
    }
}