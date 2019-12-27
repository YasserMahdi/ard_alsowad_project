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
    public partial class CompanyProfile : MetroFramework.Forms.MetroForm
    {
        BL.CompaniesClass comp = new BL.CompaniesClass();
        BL.debtClass dbt = new BL.debtClass();

        DataTable dt = new DataTable();


        public CompanyProfile()
        {
            InitializeComponent();

        }
 

        private void CompanyProfile_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = dbt.compDebtHistory(this.txtName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            PL.compDeptHistory frm = new compDeptHistory();
            frm.name = txtName.Text;
            frm.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            PL.compDebtProcess frm = new compDebtProcess();
            frm.state = "dbt";
            frm.name = this.txtName.Text;
            frm.ShowDialog();
            try
            {
                this.dataGridView1.DataSource = dbt.compDebtHistory(this.txtName.Text);
                this.txtTotalDebt.Text = dbt.fetchCompaniesDebts(this.txtName.Text).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            PL.compDebtProcess frm = new compDebtProcess();
            frm.state = "rep";
            frm.name = this.txtName.Text;
            frm.ShowDialog();
            try
            {
                this.dataGridView1.DataSource = dbt.compDebtHistory(this.txtName.Text);
                this.txtTotalDebt.Text = dbt.fetchCompaniesDebts(this.txtName.Text).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
