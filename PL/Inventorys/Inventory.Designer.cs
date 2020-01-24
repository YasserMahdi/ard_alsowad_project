namespace IFarmer.PL
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModify = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.BtnStoreManagement = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 2);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 26;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(1501, 580);
            this.bunifuCustomDataGrid1.TabIndex = 1;
            this.bunifuCustomDataGrid1.DoubleClick += new System.EventHandler(this.bunifuCustomDataGrid1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnModify);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(394, 721);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(775, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العمليات";
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "خروج";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.White;
            this.btnClose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(106, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 41);
            this.btnClose.TabIndex = 6;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnModify
            // 
            this.btnModify.ActiveBorderThickness = 1;
            this.btnModify.ActiveCornerRadius = 20;
            this.btnModify.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnModify.ActiveForecolor = System.Drawing.Color.White;
            this.btnModify.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModify.BackgroundImage")));
            this.btnModify.ButtonText = "تعديل";
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModify.IdleBorderThickness = 1;
            this.btnModify.IdleCornerRadius = 20;
            this.btnModify.IdleFillColor = System.Drawing.Color.White;
            this.btnModify.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnModify.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnModify.Location = new System.Drawing.Point(297, 16);
            this.btnModify.Margin = new System.Windows.Forms.Padding(5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(181, 41);
            this.btnModify.TabIndex = 5;
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "حذف";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnDelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.Location = new System.Drawing.Point(488, 16);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.bunifuCustomDataGrid1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(23, 114);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1504, 586);
            this.bunifuCards1.TabIndex = 3;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(598, 64);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(370, 44);
            this.bunifuMaterialTextbox1.TabIndex = 5;
            this.bunifuMaterialTextbox1.Text = "البحث";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Location = new System.Drawing.Point(1275, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 30);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.UseSelectable = true;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnStoreManagement
            // 
            this.BtnStoreManagement.ActiveBorderThickness = 1;
            this.BtnStoreManagement.ActiveCornerRadius = 20;
            this.BtnStoreManagement.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnStoreManagement.ActiveForecolor = System.Drawing.Color.White;
            this.BtnStoreManagement.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnStoreManagement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnStoreManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnStoreManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStoreManagement.BackgroundImage")));
            this.BtnStoreManagement.ButtonText = "ادارة المخازن";
            this.BtnStoreManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStoreManagement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStoreManagement.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnStoreManagement.IdleBorderThickness = 1;
            this.BtnStoreManagement.IdleCornerRadius = 20;
            this.BtnStoreManagement.IdleFillColor = System.Drawing.Color.White;
            this.BtnStoreManagement.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnStoreManagement.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnStoreManagement.Location = new System.Drawing.Point(1004, 59);
            this.BtnStoreManagement.Margin = new System.Windows.Forms.Padding(5);
            this.BtnStoreManagement.Name = "BtnStoreManagement";
            this.BtnStoreManagement.Size = new System.Drawing.Size(249, 41);
            this.BtnStoreManagement.TabIndex = 7;
            this.BtnStoreManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnStoreManagement.Click += new System.EventHandler(this.BtnStoreManagement_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 850);
            this.Controls.Add(this.BtnStoreManagement);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Inventory";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "البذور و المواد";
            this.Load += new System.EventHandler(this.seedAndMaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModify;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnStoreManagement;
    }
}