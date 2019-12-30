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
    public partial class Cpanel : MetroFramework.Forms.MetroForm
    {
        public Cpanel()
        {
            InitializeComponent();
        }

     

        private void Cpanel_Load(object sender, EventArgs e)
        {

        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            PL.admin.Users frm = new admin.Users();
            frm.ShowDialog();
        }

        private void BtnDebts_Click(object sender, EventArgs e)
        {
            PL.Debts frm = new Debts();
            frm.ShowDialog();
        }

        private void BtnSupliers_Click(object sender, EventArgs e)
        {
            PL.Companies frm = new Companies();
            frm.ShowDialog();
        }
    }
}
