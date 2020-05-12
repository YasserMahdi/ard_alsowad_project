namespace IFarmer.PL.Invoice
{
    partial class NurseryDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NurseryDocument));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtReamining = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtAmountReceived = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtTotal = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSelection = new System.Windows.Forms.Button();
            this.txtMatNo = new System.Windows.Forms.TextBox();
            this.txtMatName = new System.Windows.Forms.TextBox();
            this.txtMatPrice = new System.Windows.Forms.TextBox();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtNote = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCusID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReamining
            // 
            this.txtReamining.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtReamining.Location = new System.Drawing.Point(29, 805);
            this.txtReamining.Name = "txtReamining";
            this.txtReamining.Size = new System.Drawing.Size(169, 24);
            this.txtReamining.TabIndex = 44;
            this.txtReamining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtAmountReceived.Location = new System.Drawing.Point(29, 775);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.Size = new System.Drawing.Size(169, 24);
            this.txtAmountReceived.TabIndex = 43;
            this.txtAmountReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountReceived.TextChanged += new System.EventHandler(this.txtAmountReceived_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTotal.Location = new System.Drawing.Point(29, 745);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(169, 24);
            this.txtTotal.TabIndex = 42;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(18, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 22);
            this.label5.TabIndex = 41;
            this.label5.Text = "السعر الكلي";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(245, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "الكمية";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(501, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "سعر المفرد";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(784, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "اسم المنتج";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(1114, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "رقم المنتج";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(1399, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "اختيار";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(1399, 328);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(134, 24);
            this.btnSelection.TabIndex = 33;
            this.btnSelection.Text = "...";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // txtMatNo
            // 
            this.txtMatNo.Location = new System.Drawing.Point(1114, 328);
            this.txtMatNo.Name = "txtMatNo";
            this.txtMatNo.Size = new System.Drawing.Size(266, 24);
            this.txtMatNo.TabIndex = 35;
            this.txtMatNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMatName
            // 
            this.txtMatName.Location = new System.Drawing.Point(784, 328);
            this.txtMatName.Name = "txtMatName";
            this.txtMatName.Size = new System.Drawing.Size(324, 24);
            this.txtMatName.TabIndex = 34;
            this.txtMatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMatPrice
            // 
            this.txtMatPrice.Location = new System.Drawing.Point(501, 328);
            this.txtMatPrice.Name = "txtMatPrice";
            this.txtMatPrice.Size = new System.Drawing.Size(277, 24);
            this.txtMatPrice.TabIndex = 32;
            this.txtMatPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMatPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQte_KeyDown);
            this.txtMatPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQte_KeyPress);
            this.txtMatPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQte_KeyUp);
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(245, 328);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(250, 24);
            this.txtQte.TabIndex = 31;
            this.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQte_KeyDown);
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQte_KeyPress);
            this.txtQte.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQte_KeyUp);
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
            this.btnClose.ButtonText = "خروج";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.White;
            this.btnClose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(465, 775);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 41);
            this.btnClose.TabIndex = 29;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnSave.Location = new System.Drawing.Point(656, 775);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 41);
            this.btnSave.TabIndex = 28;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.ActiveBorderThickness = 1;
            this.btnNew.ActiveCornerRadius = 20;
            this.btnNew.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnNew.ActiveForecolor = System.Drawing.Color.White;
            this.btnNew.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.ButtonText = "جديد";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNew.IdleBorderThickness = 1;
            this.btnNew.IdleCornerRadius = 20;
            this.btnNew.IdleFillColor = System.Drawing.Color.White;
            this.btnNew.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNew.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNew.Location = new System.Drawing.Point(847, 775);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(181, 41);
            this.btnNew.TabIndex = 27;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(18, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1515, 357);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(38, 84);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(372, 44);
            this.bunifuDatepicker1.TabIndex = 1;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 7, 6, 22, 15, 1, 398);
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
            this.txtID.Location = new System.Drawing.Point(38, 32);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(372, 44);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "رقم القائمة";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuDatepicker1);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Location = new System.Drawing.Point(1046, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 190);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات القائمه";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(459, 53);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(44, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
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
            this.txtNote.Location = new System.Drawing.Point(67, 84);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(370, 44);
            this.txtNote.TabIndex = 10;
            this.txtNote.Text = "الملاحظات";
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
            this.txtName.Location = new System.Drawing.Point(65, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(370, 44);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "اسم الزبون";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCusID
            // 
            this.txtCusID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCusID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCusID.HintForeColor = System.Drawing.Color.Empty;
            this.txtCusID.HintText = "";
            this.txtCusID.isPassword = false;
            this.txtCusID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCusID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCusID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCusID.LineThickness = 3;
            this.txtCusID.Location = new System.Drawing.Point(67, 32);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(370, 44);
            this.txtCusID.TabIndex = 12;
            this.txtCusID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(18, 329);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(221, 24);
            this.txtAmount.TabIndex = 30;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCusID);
            this.groupBox1.Location = new System.Drawing.Point(18, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 190);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الزبون";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 748);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "المبلغ الكلي";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 778);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "الواصل";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 808);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "الباقي";
            // 
            // NurseryDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 900);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReamining);
            this.Controls.Add(this.txtAmountReceived);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.txtMatNo);
            this.Controls.Add(this.txtMatName);
            this.Controls.Add(this.txtMatPrice);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.groupBox1);
            this.Name = "NurseryDocument";
            this.Text = "order";
            this.Load += new System.EventHandler(this.NurseryDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtReamining;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtAmountReceived;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.TextBox txtMatNo;
        private System.Windows.Forms.TextBox txtMatName;
        private System.Windows.Forms.TextBox txtMatPrice;
        private System.Windows.Forms.TextBox txtQte;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNew;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowse;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNote;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCusID;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}