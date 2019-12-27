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
    public partial class compDebtProcess : MetroFramework.Forms.MetroForm
    {
        BL.debtClass debt = new BL.debtClass();
        public string state;
        public string name;
        public compDebtProcess()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(state == "dbt")
            {
                debt.setDirCompaniesDebts(name, Convert.ToDouble(txtMoney.Text));
                MessageBox.Show("تم الاضافة بنجاح", "ادخال دين جديد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if(state == "rep")
            {
                debt.setDirCompaniesRep(name, Convert.ToDouble(txtMoney.Text));
                MessageBox.Show("تم الاضافة بنجاح", "ادخال دين جديد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void compDebtProcess_Load(object sender, EventArgs e)
        {

        }
    }
}
