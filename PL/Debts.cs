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
    public partial class Debts : MetroFramework.Forms.MetroForm
    {
        BL.debtClass debt = new BL.debtClass();
        public Debts()
        {
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            PL.customerDebtHistory frm = new customerDebtHistory();
            try
            {
                frm.id = Convert.ToInt32(this.bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);
                frm.oldDept = Convert.ToDouble(this.bunifuCustomDataGrid1.CurrentRow.Cells[2].Value);
                frm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
           this.bunifuCustomDataGrid1.DataSource = debt.searchInDebt(txtSearch.Text);
        }

        private void Debts_Load(object sender, EventArgs e)
        {
            try
            {
                this.bunifuCustomDataGrid1.DataSource = debt.final_status_of_debts();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
