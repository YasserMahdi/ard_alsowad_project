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
        string CustomerNo;
        
        public statementOfAcount()
        {
            InitializeComponent();
        }

        public statementOfAcount(string Customer_No)
        {
            InitializeComponent();
            this.CustomerNo = Customer_No;
        }

        private void statementOfAcount_Load(object sender, EventArgs e)
        {
            try
            {
                BL.Customer.statementOFAcount soa = new BL.Customer.statementOFAcount();
                this.dataGridView1.DataSource= soa.GetStatement(CustomerNo);
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
                this.dataGridView1.DataSource = soa.GetStatementPeriod(CustomerNo,Convert.ToDateTime(DateTime1.Value), Convert.ToDateTime(DateTime2.Value));
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
            rpt.SetDataSource(FullState.GetStatement(this.CustomerNo));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();

        }

        private void BtnPrintSatatentByDate_Click(object sender, EventArgs e)
        {
            BL.Reports.SearchStatement SearchState = new BL.Reports.SearchStatement();
            //Report.statOdAccByDate rpt = new Report.statOdAccByDate();
            //Report.ReportForm frm = new Report.ReportForm();
            //DataSet ds = new DataSet();
            //ds.Tables.Add(SearchState.GetStatementPeriod(this.CustomerNo, this.DateTime1.Value.Date, this.DateTime2.Value.Date));
            ////ds.Tables[0].Merge(SearchState.GetStatementPeriod(this.CustomerNo, this.DateTime1.Value.Date, this.DateTime2.Value.Date));
            //rpt.SetDataSource(ds.Tables[0]);
            //frm.crystalReportViewer1.ReportSource = rpt;
            //frm.ShowDialog();
            //BL.Reports.SearchStatement SearchState = new BL.Reports.SearchStatement();
            BL.Customer.statementOFAcount soa = new BL.Customer.statementOFAcount();
            Report.SStatement rpt = new Report.SStatement();
            Report.ReportForm frm = new Report.ReportForm();
            //DataSet ds = new DataSet();
            //ds.Tables.Add(SearchState.GetStatementPeriod(this.CustomerNo, this.DateTime1.Value.Date, this.DateTime2.Value.Date));
            //ds.Tables[0].Merge(SearchState.GetStatementPeriod(this.CustomerNo, this.DateTime1.Value.Date, this.DateTime2.Value.Date));
            //rpt.SetDataSource(soa.getOrderOfCustomerP(this.CustomerNo,this.DateTime1.Value,DateTime2.Value));
            rpt.SetDataSource(SearchState.GetStatementPeriod(this.CustomerNo, this.DateTime1.Value, DateTime2.Value));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }
    }
}
