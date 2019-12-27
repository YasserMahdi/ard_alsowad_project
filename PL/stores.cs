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
    public partial class stores : MetroFramework.Forms.MetroForm
    {
        BL.StoresaMnagement sm = new BL.StoresaMnagement();

        public stores()
        {
            InitializeComponent();
        }

        private void stores_Load(object sender, EventArgs e)
        {
            
            this.dataGridView1.DataSource = sm.selectStore();
        }

        private void BtnAddStore_Click(object sender, EventArgs e)
        {
            PL.UpdateStore frm = new UpdateStore();
            frm.ShowDialog();
            this.dataGridView1.DataSource = sm.selectStore();
        }

        private void BtnUpdateStore_Click(object sender, EventArgs e)
        {
            PL.UpdateStoreName frm = new UpdateStoreName();
            frm.StoreID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.StoreName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.ShowDialog();
            this.dataGridView1.DataSource = sm.selectStore();
        }

        private void BtnDeleteStore_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد الحذف فعلا", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    sm.DeleteStore(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تم الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dataGridView1.DataSource = sm.selectStore();


                }
                else
                {
                    MessageBox.Show("تم الغاء عمليةالحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
    }
}
