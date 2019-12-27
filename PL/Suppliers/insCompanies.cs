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
    public partial class insCompanies : MetroFramework.Forms.MetroForm
    {
        public string state;
        public int id;
        BL.CompaniesClass comp = new BL.CompaniesClass();
        public insCompanies()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                if (txtInsComp.Text != string.Empty)
                {
                    comp.insCompanies(txtInsComp.Text);
                    MessageBox.Show("تم اضافة الشركة الجديده بنجاح");
                }
                else
                {
                    MessageBox.Show("الرجاء ادخال المعلومات");
                }
            }
            else
            {
                comp.updateCompaniesInfo(txtInsComp.Text, id);
                MessageBox.Show("تم التحديث بنجاح");
            }
        }
    }
}
