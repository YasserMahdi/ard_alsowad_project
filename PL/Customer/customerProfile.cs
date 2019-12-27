using System;
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
        public int id;
        BL.orderClass order = new BL.orderClass();
        BL.debtClass debt = new BL.debtClass();
        BL.DocumentClass doc = new BL.DocumentClass();

        private void UpDateInfo()
        {
            this.dataGridView1.DataSource = debt.StatementOfAccount(id);


            //this.invoDataGrid1.DataSource = order.notPaidInCash(id);


            //this.docDataGrid2.DataSource = doc.unPaidDoc(id);
            this.txtDebt.Text = string.Format("{0:n0}", (debt.getTotalInvDebt(id)  ));
        }
        public customerProfile()
        {
            InitializeComponent();
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
                frm.txtID.Text = this.id.ToString();
                frm.txtName.Text = this.txtName.Text;
                //frm.OldDebt = (debt.getTotalInvDebt(id) + debt.getTotalDocDebt(id));
                frm.txtOldDept.Text = string.Format("{0:n0}", debt.getTotalInvDebt(id));
                frm.temp = Convert.ToInt32(debt.getTotalInvDebt(id));
                frm.State = "inv";
                frm.ShowDialog();
                UpDateInfo();
            }
            catch(Exception ex)
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
                rpt.SetDataSource(doc.unPaidDoc(Convert.ToInt32(id)));
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
             
        }

        private void BtnDebtsBrows_Click(object sender, EventArgs e)
        {
            try
            {
                PL.customerDebtHistory frm = new customerDebtHistory();
                frm.id = this.id;
                frm.oldDept = Convert.ToDouble(txtDebt.Text);
                frm.ShowDialog();
                this.dataGridView1.DataSource = order.notPaidInCash(id);
                //this.docDataGrid2.DataSource = doc.unPaidDoc(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
