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
    public partial class Companies : MetroFramework.Forms.MetroForm
    {
        BL.CompaniesClass comp = new BL.CompaniesClass();
        public Companies()
        {
            InitializeComponent();
            try
            {
                this.dataGridView1.DataSource = comp.fetchCompanyNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = comp.searchInComp(txtSearch.Text);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            PL.insCompanies frm = new insCompanies();
            frm.state = "add";
            frm.ShowDialog();
            this.dataGridView1.DataSource = comp.fetchCompanyNames();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            PL.CompanyProfile frm = new CompanyProfile();
            
            frm.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            

            BL.debtClass dbt = new BL.debtClass();
            try
            {
                frm.txtTotalDebt.Text = dbt.fetchCompaniesDebts(dataGridView1.CurrentRow.Cells[1].Value.ToString()).Rows[0][0].ToString();
            }
            catch 
            {
                
            }

            frm.ShowDialog();
        }

        private void Companies_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                PL.insCompanies frm = new insCompanies();
                frm.state = "update";
                frm.id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                frm.txtInsComp.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.ShowDialog();
                this.dataGridView1.DataSource = comp.fetchCompanyNames();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
