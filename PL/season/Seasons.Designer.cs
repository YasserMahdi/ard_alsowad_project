namespace IFarmer.PL
{
    partial class Seasons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seasons));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntEditSeason = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddSeason = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntEditSeason);
            this.groupBox1.Controls.Add(this.btnAddSeason);
            this.groupBox1.Location = new System.Drawing.Point(12, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العمليات الممكن تنفيذها";
            // 
            // bntEditSeason
            // 
            this.bntEditSeason.ActiveBorderThickness = 1;
            this.bntEditSeason.ActiveCornerRadius = 20;
            this.bntEditSeason.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bntEditSeason.ActiveForecolor = System.Drawing.Color.White;
            this.bntEditSeason.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bntEditSeason.BackColor = System.Drawing.SystemColors.Control;
            this.bntEditSeason.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntEditSeason.BackgroundImage")));
            this.bntEditSeason.ButtonText = "تعديل معلومات الموسم";
            this.bntEditSeason.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntEditSeason.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntEditSeason.ForeColor = System.Drawing.Color.SeaGreen;
            this.bntEditSeason.IdleBorderThickness = 1;
            this.bntEditSeason.IdleCornerRadius = 20;
            this.bntEditSeason.IdleFillColor = System.Drawing.Color.White;
            this.bntEditSeason.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bntEditSeason.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bntEditSeason.Location = new System.Drawing.Point(188, 16);
            this.bntEditSeason.Margin = new System.Windows.Forms.Padding(5);
            this.bntEditSeason.Name = "bntEditSeason";
            this.bntEditSeason.Size = new System.Drawing.Size(181, 41);
            this.bntEditSeason.TabIndex = 1;
            this.bntEditSeason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntEditSeason.Click += new System.EventHandler(this.bntEditSeason_Click);
            // 
            // btnAddSeason
            // 
            this.btnAddSeason.ActiveBorderThickness = 1;
            this.btnAddSeason.ActiveCornerRadius = 20;
            this.btnAddSeason.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAddSeason.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddSeason.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddSeason.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddSeason.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSeason.BackgroundImage")));
            this.btnAddSeason.ButtonText = "اضافة موسم جديد";
            this.btnAddSeason.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSeason.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSeason.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddSeason.IdleBorderThickness = 1;
            this.btnAddSeason.IdleCornerRadius = 20;
            this.btnAddSeason.IdleFillColor = System.Drawing.Color.White;
            this.btnAddSeason.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddSeason.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddSeason.Location = new System.Drawing.Point(379, 16);
            this.btnAddSeason.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddSeason.Name = "btnAddSeason";
            this.btnAddSeason.Size = new System.Drawing.Size(181, 41);
            this.btnAddSeason.TabIndex = 0;
            this.btnAddSeason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSeason.Click += new System.EventHandler(this.btnAddSeason_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HintText = "";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(202, 34);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(370, 44);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.OnValueChanged += new System.EventHandler(this.txtSearch_OnValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 251);
            this.dataGridView1.TabIndex = 2;
            // 
            // Seasons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch);
            this.Name = "Seasons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seasons";
            this.Load += new System.EventHandler(this.Seasons_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bntEditSeason;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddSeason;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}