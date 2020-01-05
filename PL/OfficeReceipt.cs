using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IFarmer.PL
{
    public partial class OfficeReceipt : MetroFramework.Forms.MetroForm
    {
        BL.CompaniesClass comp = new BL.CompaniesClass();
        public OfficeReceipt()
        {
            InitializeComponent();
        }

        private void OfficeReceipt_Load(object sender, EventArgs e)
        {

            try
            {
                this.dataGridView1.DataSource = comp.fetchCompanyNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            PL.OfficeRcpt frm = new OfficeRcpt();
            BL.debtClass dbt = new BL.debtClass();
            try
            {
                frm.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //frm.txtTotalDebt.Text = dbt.fetchCompaniesDebts(dataGridView1.CurrentRow.Cells[1].Value.ToString()).Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            frm.ShowDialog();
        }
    }
}
