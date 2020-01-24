using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IFarmer.PL.Box
{
    public partial class CashBox : MetroFramework.Forms.MetroForm
    {
        public CashBox()
        {
            InitializeComponent();
        }

        private void CashBox_Load(object sender, EventArgs e)
        {
            try
            {
                BL.CashBox.selection sel = new BL.CashBox.selection();
                this.dataGridView1.DataSource = sel.sel_all_month();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            PL.Box.Cashes frm = new Cashes(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
        }
    }
}
