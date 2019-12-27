namespace IFarmer.PL
{
    partial class Pay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pay));
            this.btnPay = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPay = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtOldDept = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.ActiveBorderThickness = 1;
            this.btnPay.ActiveCornerRadius = 20;
            this.btnPay.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnPay.ActiveForecolor = System.Drawing.Color.White;
            this.btnPay.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPay.BackgroundImage")));
            this.btnPay.ButtonText = "سداد";
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPay.IdleBorderThickness = 1;
            this.btnPay.IdleCornerRadius = 20;
            this.btnPay.IdleFillColor = System.Drawing.Color.White;
            this.btnPay.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnPay.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnPay.Location = new System.Drawing.Point(305, 309);
            this.btnPay.Margin = new System.Windows.Forms.Padding(5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(181, 41);
            this.btnPay.TabIndex = 13;
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtPay
            // 
            this.txtPay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPay.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPay.HintForeColor = System.Drawing.Color.Empty;
            this.txtPay.HintText = "";
            this.txtPay.isPassword = false;
            this.txtPay.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPay.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPay.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPay.LineThickness = 3;
            this.txtPay.Location = new System.Drawing.Point(215, 256);
            this.txtPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(370, 44);
            this.txtPay.TabIndex = 12;
            this.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtOldDept
            // 
            this.txtOldDept.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldDept.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOldDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOldDept.HintForeColor = System.Drawing.Color.Empty;
            this.txtOldDept.HintText = "";
            this.txtOldDept.isPassword = false;
            this.txtOldDept.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtOldDept.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOldDept.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtOldDept.LineThickness = 3;
            this.txtOldDept.Location = new System.Drawing.Point(215, 204);
            this.txtOldDept.Margin = new System.Windows.Forms.Padding(4);
            this.txtOldDept.Name = "txtOldDept";
            this.txtOldDept.Size = new System.Drawing.Size(370, 44);
            this.txtOldDept.TabIndex = 11;
            this.txtOldDept.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
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
            this.txtName.Location = new System.Drawing.Point(215, 152);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(370, 44);
            this.txtName.TabIndex = 10;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.HintForeColor = System.Drawing.Color.Empty;
            this.txtID.HintText = "";
            this.txtID.isPassword = false;
            this.txtID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtID.LineThickness = 3;
            this.txtID.Location = new System.Drawing.Point(215, 100);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(370, 44);
            this.txtID.TabIndex = 9;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "الرقم التعريفي";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "اسم الزبون";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "مجموع الديون";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "قيمة مبلغ السداد";
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.txtOldDept);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Name = "Pay";
            this.Text = "Pay";
            this.Load += new System.EventHandler(this.Pay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuThinButton2 btnPay;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtPay;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtOldDept;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}