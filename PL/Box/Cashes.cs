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
    public partial class Cashes : MetroFramework.Forms.MetroForm
    {
        string id;
        public Cashes()
        {
            InitializeComponent();
        }

        private void Cashes_Load(object sender, EventArgs e)
        {
            BL.CashBox.selection sel = new BL.CashBox.selection();

            try
            {
                this.dataGridView1.DataSource = sel.sel_chas(Convert.ToInt32(id));
                this.TxtTotal.Text = sel.sel_sumation(Convert.ToInt32(id)).Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Cashes(string id)
        {
            InitializeComponent();
            this.id = id;

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(this.dataGridView1.CurrentRow.Cells[3].Value.ToString() == "")
                {
                    MessageBox.Show("هذا المبلغ هو مبلغ سداد و ليس مبلغ واصل من الفواتير");
                }
                else
                {
                    PL.updateInvoice frm = new updateInvoice(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    frm.id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value);
                    frm.ShowDialog();
                }

                 


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
