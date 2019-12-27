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
    public partial class listInvoice : MetroFramework.Forms.MetroForm
    {
        BL.orderClass order = new BL.orderClass();
        public listInvoice()
        {
            InitializeComponent();
        }

        private void listInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                 dataGridView1.DataSource = order.listinvo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {

            try
            {
                this.dataGridView1.DataSource = order.searchinInvo(txtSearch.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                PL.showInvoice frm = new showInvoice();
                frm.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                frm.txtName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.txtNote.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtTotal.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.txtAmountReceived.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
