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
    public partial class showInvoice : MetroFramework.Forms.MetroForm
    {
        BL.orderClass order = new BL.orderClass();
        public int id;






        public showInvoice()
        {
            InitializeComponent();
        }

        private void showInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = order.showInvoice_details(id);
                this.txtID.Text = order.showInvoice_head(id).Rows[0][0].ToString();
                this.txtNote.Text = order.showInvoice_head(id).Rows[0][2].ToString();
                this.txtName.Text = order.showInvoice_head(id).Rows[0][3].ToString();
                this.txtTotal.Text = order.showInvoice_head(id).Rows[0][5].ToString();
                txtAmountReceived.Text = order.showInvoice_head(id).Rows[0][6].ToString();
                this.bunifuDatepicker1.Value = Convert.ToDateTime(order.showInvoice_head(id).Rows[0][1].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                Report.invoice rpt = new Report.invoice();
                Report.ReportForm frm = new Report.ReportForm();
                rpt.SetDataSource(order.printinvoice(Convert.ToInt32(this.txtID.Text)));
                frm.crystalReportViewer1.ReportSource = rpt;

                frm.ShowDialog();
                //frm.crystalReportViewer1.PrintReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
