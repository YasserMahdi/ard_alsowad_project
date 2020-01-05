namespace IFarmer.PL.Customer
{
    partial class statementOfAcount
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.DateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPeriod = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnPrintSatatentByDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(1342, 500);
            this.dataGridView1.TabIndex = 0;
            // 
            // DateTime2
            // 
            this.DateTime2.Location = new System.Drawing.Point(781, 63);
            this.DateTime2.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateTime2.Name = "DateTime2";
            this.DateTime2.Size = new System.Drawing.Size(200, 30);
            this.DateTime2.TabIndex = 1;
            // 
            // DateTime1
            // 
            this.DateTime1.Location = new System.Drawing.Point(1102, 63);
            this.DateTime1.MinimumSize = new System.Drawing.Size(4, 30);
            this.DateTime1.Name = "DateTime1";
            this.DateTime1.Size = new System.Drawing.Size(200, 30);
            this.DateTime1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1309, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "من الفتره";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(987, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "الى الفتره";
            // 
            // searchPeriod
            // 
            this.searchPeriod.Location = new System.Drawing.Point(1102, 99);
            this.searchPeriod.Name = "searchPeriod";
            this.searchPeriod.Size = new System.Drawing.Size(200, 30);
            this.searchPeriod.TabIndex = 5;
            this.searchPeriod.Text = "بحث ضمن الفتره المحددة";
            this.searchPeriod.UseVisualStyleBackColor = true;
            this.searchPeriod.Click += new System.EventHandler(this.searchPeriod_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(736, 659);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "طباعة كشف حساب كامل";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnPrintSatatentByDate
            // 
            this.BtnPrintSatatentByDate.Location = new System.Drawing.Point(515, 659);
            this.BtnPrintSatatentByDate.Name = "BtnPrintSatatentByDate";
            this.BtnPrintSatatentByDate.Size = new System.Drawing.Size(200, 30);
            this.BtnPrintSatatentByDate.TabIndex = 7;
            this.BtnPrintSatatentByDate.Text = "طباعة ضمن الفتره المحدده";
            this.BtnPrintSatatentByDate.UseVisualStyleBackColor = true;
            this.BtnPrintSatatentByDate.Click += new System.EventHandler(this.BtnPrintSatatentByDate_Click);
            // 
            // statementOfAcount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 746);
            this.Controls.Add(this.BtnPrintSatatentByDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTime1);
            this.Controls.Add(this.DateTime2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "statementOfAcount";
            this.Text = "statementOfAcount";
            this.Load += new System.EventHandler(this.statementOfAcount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroDateTime DateTime2;
        private MetroFramework.Controls.MetroDateTime DateTime1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchPeriod;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnPrintSatatentByDate;
    }
}