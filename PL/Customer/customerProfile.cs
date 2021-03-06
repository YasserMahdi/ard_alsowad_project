﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFarmer.PL
{
    public partial class customerProfile : MetroFramework.Forms.MetroForm
    {
        public int CustomerNo;
        BL.orderClass order = new BL.orderClass();
        BL.debtClass debt = new BL.debtClass();
        BL.DocumentClass doc = new BL.DocumentClass();
        string State;
        private void UpDateInfo()
        {
            this.dataGridView1.DataSource = debt.StatementOfAccount(CustomerNo);
            

            //this.invoDataGrid1.DataSource = order.notPaidInCash(id);


            //this.docDataGrid2.DataSource = doc.unPaidDoc(id);
            double ValueOfFinalDebt;
            if (debt.GetFinalValueOfDebt(CustomerNo).Rows.Count > 0)
            {
                ValueOfFinalDebt = Convert.ToDouble(debt.GetFinalValueOfDebt(CustomerNo).Rows[0][0]);
            }
            else
            {
                ValueOfFinalDebt = 0.0;
            }
            this.txtDebt.Text = string.Format("{0:n0}", (ValueOfFinalDebt));
        }
        public customerProfile()
        {
            InitializeComponent();
        }
        // state = RetrievalMaterials
        public customerProfile(string State)
        {
            InitializeComponent();
            this.State = State;
        }

        private void customerProfile_Load(object sender, EventArgs e)
        {

            try
            {
                UpDateInfo();
            }
            catch
            {

            }


        }



        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            //PL.showInvoice frm = new showInvoice();
            PL.updateInvoice frm = new updateInvoice();
            frm.id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnREP_Click(object sender, EventArgs e)
        {
            try
            {
                PL.Pay frm = new Pay();
                frm.txtID.Text = this.CustomerNo.ToString();
                frm.txtName.Text = this.txtName.Text;
                //frm.OldDebt = (debt.getTotalInvDebt(id) + debt.getTotalDocDebt(id));
                frm.txtOldDept.Text = string.Format("{0:n0}", debt.GetFinalValueOfDebt(CustomerNo).Rows[0][0]);
                frm.temp = Convert.ToInt32(debt.GetFinalValueOfDebt(CustomerNo).Rows[0][0]);
                frm.State = "inv";
                frm.ShowDialog();
                UpDateInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Report.UnpaidDocuments rpt = new Report.UnpaidDocuments();
                Report.ReportForm frm = new Report.ReportForm();
                rpt.SetDataSource(doc.unPaidDoc(Convert.ToInt32(CustomerNo)));
                frm.crystalReportViewer1.ReportSource = rpt;

                frm.ShowDialog();
                frm.crystalReportViewer1.PrintReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnInsertNewDebt_Click(object sender, EventArgs e)
        {
            PL.InsertNewDebt frm = new InsertNewDebt(this.CustomerNo,this.txtName.Text);
            frm.ShowDialog();
        }

        private void BtnDebtsBrows_Click(object sender, EventArgs e)
        {
            try
            {
                PL.customerDebtHistory frm = new customerDebtHistory();
                frm.id = this.CustomerNo;
                frm.oldDept = Convert.ToDouble(txtDebt.Text);
                frm.ShowDialog();
                //this.dataGridView1.DataSource = order.notPaidInCash(id);
                //this.docDataGrid2.DataSource = doc.unPaidDoc(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (State == "RetrievalMaterials")
            {

                try
                {
                    PL.updateInvoice frm = new updateInvoice(this.dataGridView1.CurrentRow.Cells[7].Value.ToString());
                    frm.id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                    frm.ShowDialog();
                     
                    UpDateInfo();
                     
                     
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    PL.showInvoice frm = new showInvoice();
                    frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    frm.txtName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    frm.txtNote.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    frm.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    frm.txtTotal.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    frm.txtAmountReceived.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void statementOfAcount_Click(object sender, EventArgs e)
        {
            PL.Customer.statementOfAcount frm = new Customer.statementOfAcount(this.CustomerNo.ToString());
            frm.ShowDialog();
        }
    }
}
