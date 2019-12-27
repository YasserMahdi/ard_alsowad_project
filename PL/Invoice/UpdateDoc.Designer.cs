namespace IFarmer.PL
{
    partial class UpdateDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtReamining = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtAmountReceived = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.oldDept = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCusID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNote = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSeasonID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSeasonName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(210, 752);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(82, 17);
            this.bunifuCustomLabel3.TabIndex = 71;
            this.bunifuCustomLabel3.Text = "المبلغ الباقي";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(210, 692);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(79, 17);
            this.bunifuCustomLabel1.TabIndex = 69;
            this.bunifuCustomLabel1.Text = "المبلغ الكلي";
            // 
            // txtReamining
            // 
            this.txtReamining.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtReamining.Location = new System.Drawing.Point(35, 749);
            this.txtReamining.Name = "txtReamining";
            this.txtReamining.Size = new System.Drawing.Size(169, 24);
            this.txtReamining.TabIndex = 68;
            this.txtReamining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtAmountReceived.Location = new System.Drawing.Point(35, 719);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.Size = new System.Drawing.Size(169, 24);
            this.txtAmountReceived.TabIndex = 67;
            this.txtAmountReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountReceived.TextChanged += new System.EventHandler(this.txtAmountReceived_TextChanged);
            // 
            // oldDept
            // 
            this.oldDept.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldDept.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.oldDept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oldDept.HintForeColor = System.Drawing.Color.Empty;
            this.oldDept.HintText = "";
            this.oldDept.isPassword = false;
            this.oldDept.LineFocusedColor = System.Drawing.Color.Blue;
            this.oldDept.LineIdleColor = System.Drawing.Color.Gray;
            this.oldDept.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.oldDept.LineThickness = 3;
            this.oldDept.Location = new System.Drawing.Point(67, 76);
            this.oldDept.Margin = new System.Windows.Forms.Padding(4);
            this.oldDept.Name = "oldDept";
            this.oldDept.Size = new System.Drawing.Size(370, 44);
            this.oldDept.TabIndex = 13;
            this.oldDept.Text = "الدين السابق";
            this.oldDept.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtCusID.Location = new System.Drawing.Point(67, 24);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(370, 44);
            this.txtCusID.TabIndex = 14;
            this.txtCusID.Text = "اسم الزبون";
            this.txtCusID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnClose.ButtonText = "الغاء";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.White;
            this.btnClose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(498, 692);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 41);
            this.btnClose.TabIndex = 53;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oldDept);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCusID);
            this.groupBox1.Location = new System.Drawing.Point(35, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 248);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الزبون";
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
            this.txtNote.Location = new System.Drawing.Point(67, 128);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(370, 44);
            this.txtNote.TabIndex = 10;
            this.txtNote.Text = "الملاحضات";
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
            this.txtName.Location = new System.Drawing.Point(67, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(370, 44);
            this.txtName.TabIndex = 9;
            this.txtName.Text = "اسم الزبون";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSeasonID
            // 
            this.txtSeasonID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeasonID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSeasonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSeasonID.HintForeColor = System.Drawing.Color.Empty;
            this.txtSeasonID.HintText = "";
            this.txtSeasonID.isPassword = false;
            this.txtSeasonID.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSeasonID.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSeasonID.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSeasonID.LineThickness = 3;
            this.txtSeasonID.Location = new System.Drawing.Point(7, 180);
            this.txtSeasonID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeasonID.Name = "txtSeasonID";
            this.txtSeasonID.Size = new System.Drawing.Size(129, 44);
            this.txtSeasonID.TabIndex = 16;
            this.txtSeasonID.Text = "معرف الموسم";
            this.txtSeasonID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSeasonName
            // 
            this.txtSeasonName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeasonName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSeasonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSeasonName.HintForeColor = System.Drawing.Color.Empty;
            this.txtSeasonName.HintText = "";
            this.txtSeasonName.isPassword = false;
            this.txtSeasonName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSeasonName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSeasonName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSeasonName.LineThickness = 3;
            this.txtSeasonName.Location = new System.Drawing.Point(144, 180);
            this.txtSeasonName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeasonName.Name = "txtSeasonName";
            this.txtSeasonName.Size = new System.Drawing.Size(264, 44);
            this.txtSeasonName.TabIndex = 14;
            this.txtSeasonName.Text = "اختيار المواسم";
            this.txtSeasonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(210, 722);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(83, 17);
            this.bunifuCustomLabel2.TabIndex = 70;
            this.bunifuCustomLabel2.Text = "المبلغ الواصل";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSeasonID);
            this.groupBox2.Controls.Add(this.txtSeasonName);
            this.groupBox2.Controls.Add(this.bunifuDatepicker1);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Location = new System.Drawing.Point(689, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 248);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات القائمه";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(38, 106);
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
            this.txtID.Location = new System.Drawing.Point(38, 24);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(372, 44);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "رقم القائمة";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtTotal.Location = new System.Drawing.Point(35, 689);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(169, 24);
            this.txtTotal.TabIndex = 66;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(35, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 65;
            this.label5.Text = "السعر الكلي";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(197, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 64;
            this.label4.Text = "الكمية";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(359, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 63;
            this.label3.Text = "سعر المفرد";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(521, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 23);
            this.label2.TabIndex = 62;
            this.label2.Text = "اسم المنتج";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(930, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 61;
            this.label1.Text = "رقم المنتج";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(1092, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 23);
            this.label9.TabIndex = 60;
            this.label9.Text = "اختيار";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(1092, 372);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(134, 24);
            this.btnSelection.TabIndex = 56;
            this.btnSelection.Text = "...";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // txtMatNo
            // 
            this.txtMatNo.Location = new System.Drawing.Point(930, 373);
            this.txtMatNo.Name = "txtMatNo";
            this.txtMatNo.Size = new System.Drawing.Size(156, 24);
            this.txtMatNo.TabIndex = 59;
            this.txtMatNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMatName
            // 
            this.txtMatName.Location = new System.Drawing.Point(521, 373);
            this.txtMatName.Name = "txtMatName";
            this.txtMatName.Size = new System.Drawing.Size(403, 24);
            this.txtMatName.TabIndex = 58;
            this.txtMatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMatPrice
            // 
            this.txtMatPrice.Location = new System.Drawing.Point(359, 373);
            this.txtMatPrice.Name = "txtMatPrice";
            this.txtMatPrice.Size = new System.Drawing.Size(156, 24);
            this.txtMatPrice.TabIndex = 57;
            this.txtMatPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(197, 373);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(156, 24);
            this.txtQte.TabIndex = 55;
            this.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQte_KeyDown);
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQte_KeyPress);
            this.txtQte.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQte_KeyUp);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(35, 373);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(156, 24);
            this.txtAmount.TabIndex = 54;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnSave.Location = new System.Drawing.Point(689, 692);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 41);
            this.btnSave.TabIndex = 52;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dataGridView1.Location = new System.Drawing.Point(35, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1191, 272);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // UpdateDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 812);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtReamining);
            this.Controls.Add(this.txtAmountReceived);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.groupBox2);
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
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateDoc";
            this.Text = "تحرير المستند";
            this.Load += new System.EventHandler(this.UpdateDoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtReamining;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtAmountReceived;
        private Bunifu.Framework.UI.BunifuMaterialTextbox oldDept;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCusID;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNote;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSeasonID;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtSeasonName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
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
        private System.Windows.Forms.TextBox txtAmount;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
    }
}