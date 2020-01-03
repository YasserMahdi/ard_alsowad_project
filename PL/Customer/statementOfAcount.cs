using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IFarmer.PL.Customer
{
    public partial class statementOfAcount : MetroFramework.Forms.MetroForm
    {
        string ID;
        
        public statementOfAcount()
        {
            InitializeComponent();
        }

        public statementOfAcount(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void statementOfAcount_Load(object sender, EventArgs e)
        {
            try
            {
                BL.Customer.statementOFAcount soa = new BL.Customer.statementOFAcount();
                this.dataGridView1.DataSource= soa.GetStatement(ID);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                BL.Customer.statementOFAcount soa = new BL.Customer.statementOFAcount();
                this.dataGridView1.DataSource = soa.GetStatementPeriod(ID,Convert.ToDateTime(DateTime1.Value), Convert.ToDateTime(DateTime2.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BL.Reports.FullStatement FullState = new BL.Reports.FullStatement();
            Report.StatOfAccount rpt = new Report.StatOfAccount();
            Report.ReportForm frm = new Report.ReportForm();
            rpt.SetDataSource(FullState.GetStatement(this.ID));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();

        }

        private void BtnPrintSatatentByDate_Click(object sender, EventArgs e)
        {
            BL.Reports.FullStatement FullState = new BL.Reports.FullStatement();
            Report.StatOfAccount rpt = new Report.StatOfAccount();
            Report.ReportForm frm = new Report.ReportForm();
            rpt.SetDataSource(FullState.GetStatementPeriod(this.ID,this.DateTime1.Value,this.DateTime2.Value));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }
    }
}
