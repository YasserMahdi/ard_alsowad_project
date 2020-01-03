namespace IFarmer.PL
{
    partial class customerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerProfile));
            this.BtnInsertNewDebt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtDebt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnDebtsBrows = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnREP = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statementOfAcount = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInsertNewDebt
            // 
            this.BtnInsertNewDebt.ActiveBorderThickness = 1;
            this.BtnInsertNewDebt.ActiveCornerRadius = 20;
            this.BtnInsertNewDebt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnInsertNewDebt.ActiveForecolor = System.Drawing.Color.White;
            this.BtnInsertNewDebt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnInsertNewDebt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnInsertNewDebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnInsertNewDebt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInsertNewDebt.BackgroundImage")));
            this.BtnInsertNewDebt.ButtonText = "ادخال دين جديد";
            this.BtnInsertNewDebt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsertNewDebt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsertNewDebt.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnInsertNewDebt.IdleBorderThickness = 1;
            this.BtnInsertNewDebt.IdleCornerRadius = 20;
            this.BtnInsertNewDebt.IdleFillColor = System.Drawing.Color.White;
            this.BtnInsertNewDebt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnInsertNewDebt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnInsertNewDebt.Location = new System.Drawing.Point(796, 701);
            this.BtnInsertNewDebt.Margin = new System.Windows.Forms.Padding(5);
            this.BtnInsertNewDebt.Name = "BtnInsertNewDebt";
            this.BtnInsertNewDebt.Size = new System.Drawing.Size(228, 41);
            this.BtnInsertNewDebt.TabIndex = 40;
            this.BtnInsertNewDebt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnInsertNewDebt.Click += new System.EventHandler(this.BtnInsertNewDebt_Click);
            // 
            // txtDebt
            // 
            this.txtDebt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDebt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDebt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDebt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDebt.HintForeColor = System.Drawing.Color.Empty;
            this.txtDebt.HintText = "";
            this.txtDebt.isPassword = false;
            this.txtDebt.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDebt.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDebt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDebt.LineThickness = 3;
            this.txtDebt.Location = new System.Drawing.Point(1190, 123);
            this.txtDebt.Margin = new System.Windows.Forms.Padding(4);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.Size = new System.Drawing.Size(228, 44);
            this.txtDebt.TabIndex = 37;
            this.txtDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(1427, 150);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(95, 17);
            this.bunifuCustomLabel2.TabIndex = 38;
            this.bunifuCustomLabel2.Text = ": مجموع الديون";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1427, 97);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(80, 17);
            this.bunifuCustomLabel1.TabIndex = 36;
            this.bunifuCustomLabel1.Text = ": اسم الزبون";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(1190, 70);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 44);
            this.txtName.TabIndex = 35;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnDebtsBrows
            // 
            this.BtnDebtsBrows.ActiveBorderThickness = 1;
            this.BtnDebtsBrows.ActiveCornerRadius = 20;
            this.BtnDebtsBrows.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnDebtsBrows.ActiveForecolor = System.Drawing.Color.White;
            this.BtnDebtsBrows.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnDebtsBrows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnDebtsBrows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnDebtsBrows.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDebtsBrows.BackgroundImage")));
            this.BtnDebtsBrows.ButtonText = "استعراض سجل الديون";
            this.BtnDebtsBrows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDebtsBrows.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDebtsBrows.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDebtsBrows.IdleBorderThickness = 1;
            this.BtnDebtsBrows.IdleCornerRadius = 20;
            this.BtnDebtsBrows.IdleFillColor = System.Drawing.Color.White;
            this.BtnDebtsBrows.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnDebtsBrows.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnDebtsBrows.Location = new System.Drawing.Point(558, 701);
            this.BtnDebtsBrows.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDebtsBrows.Name = "BtnDebtsBrows";
            this.BtnDebtsBrows.Size = new System.Drawing.Size(228, 41);
            this.BtnDebtsBrows.TabIndex = 42;
            this.BtnDebtsBrows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDebtsBrows.Click += new System.EventHandler(this.BtnDebtsBrows_Click);
            // 
            // btnREP
            // 
            this.btnREP.ActiveBorderThickness = 1;
            this.btnREP.ActiveCornerRadius = 20;
            this.btnREP.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnREP.ActiveForecolor = System.Drawing.Color.White;
            this.btnREP.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnREP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnREP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnREP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnREP.BackgroundImage")));
            this.btnREP.ButtonText = "سداد";
            this.btnREP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnREP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREP.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnREP.IdleBorderThickness = 1;
            this.btnREP.IdleCornerRadius = 20;
            this.btnREP.IdleFillColor = System.Drawing.Color.White;
            this.btnREP.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnREP.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnREP.Location = new System.Drawing.Point(1034, 701);
            this.btnREP.Margin = new System.Windows.Forms.Padding(5);
            this.btnREP.Name = "btnREP";
            this.btnREP.Size = new System.Drawing.Size(181, 41);
            this.btnREP.TabIndex = 44;
            this.btnREP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnREP.Click += new System.EventHandler(this.btnREP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(23, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1504, 477);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المشتريات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1498, 448);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // statementOfAcount
            // 
            this.statementOfAcount.ActiveBorderThickness = 1;
            this.statementOfAcount.ActiveCornerRadius = 20;
            this.statementOfAcount.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.statementOfAcount.ActiveForecolor = System.Drawing.Color.White;
            this.statementOfAcount.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.statementOfAcount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statementOfAcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statementOfAcount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statementOfAcount.BackgroundImage")));
            this.statementOfAcount.ButtonText = "كشف حساب";
            this.statementOfAcount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statementOfAcount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statementOfAcount.ForeColor = System.Drawing.Color.SeaGreen;
            this.statementOfAcount.IdleBorderThickness = 1;
            this.statementOfAcount.IdleCornerRadius = 20;
            this.statementOfAcount.IdleFillColor = System.Drawing.Color.White;
            this.statementOfAcount.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.statementOfAcount.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.statementOfAcount.Location = new System.Drawing.Point(320, 701);
            this.statementOfAcount.Margin = new System.Windows.Forms.Padding(5);
            this.statementOfAcount.Name = "statementOfAcount";
            this.statementOfAcount.Size = new System.Drawing.Size(228, 41);
            this.statementOfAcount.TabIndex = 45;
            this.statementOfAcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statementOfAcount.Click += new System.EventHandler(this.statementOfAcount_Click);
            // 
            // customerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 900);
            this.Controls.Add(this.statementOfAcount);
            this.Controls.Add(this.btnREP);
            this.Controls.Add(this.BtnDebtsBrows);
            this.Controls.Add(this.BtnInsertNewDebt);
            this.Controls.Add(this.txtDebt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtName);
            this.Name = "customerProfile";
            this.Text = "CustomerProfile";
            this.Load += new System.EventHandler(this.customerProfile_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 BtnInsertNewDebt;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtDebt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnDebtsBrows;
        private Bunifu.Framework.UI.BunifuThinButton2 btnREP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 statementOfAcount;
    }
}