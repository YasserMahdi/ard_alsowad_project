namespace IFarmer.PL
{
    partial class InsertNewDebt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertNewDebt));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtMoney = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNote = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cacheddebt1 = new IFarmer.Report.Cacheddebt();
            this.DateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "المبلغ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "الملاحظات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "اسم الزبون";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "الرقم التعريفي";
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "حفظ";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.White;
            this.btnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(251, 309);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 41);
            this.btnSave.TabIndex = 31;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoney.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMoney.HintForeColor = System.Drawing.Color.Empty;
            this.txtMoney.HintText = "";
            this.txtMoney.isPassword = false;
            this.txtMoney.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMoney.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMoney.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMoney.LineThickness = 3;
            this.txtMoney.Location = new System.Drawing.Point(161, 256);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(370, 44);
            this.txtMoney.TabIndex = 30;
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNote
            // 
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNote.HintForeColor = System.Drawing.Color.Empty;
            this.txtNote.HintText = "";
            this.txtNote.isPassword = false;
            this.txtNote.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNote.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNote.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNote.LineThickness = 3;
            this.txtNote.Location = new System.Drawing.Point(161, 204);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(370, 44);
            this.txtNote.TabIndex = 29;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtName.Location = new System.Drawing.Point(161, 152);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(370, 44);
            this.txtName.TabIndex = 28;
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
            this.txtID.Location = new System.Drawing.Point(161, 100);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(370, 44);
            this.txtID.TabIndex = 27;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DateTime2
            // 
            this.DateTime2.Location = new System.Drawing.Point(161, 73);
            this.DateTime2.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateTime2.Name = "DateTime2";
            this.DateTime2.Size = new System.Drawing.Size(370, 30);
            this.DateTime2.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "التاريخ";
            // 
            // InsertNewDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateTime2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Name = "InsertNewDebt";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "ادخال دين جديد";
            this.Load += new System.EventHandler(this.InsertNewDebt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtMoney;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtNote;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private Report.Cacheddebt cacheddebt1;
        private MetroFramework.Controls.MetroDateTime DateTime2;
        private System.Windows.Forms.Label label5;
    }
}