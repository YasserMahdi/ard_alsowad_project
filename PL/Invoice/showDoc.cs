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
    public partial class showDoc : MetroFramework.Forms.MetroForm
    {
        public int docID;
        //BL.DocumentClass doc = new BL.DocumentClass();
        BL.orderClass order = new BL.orderClass();
        public showDoc()
        {
            InitializeComponent();
        }

        private void showDoc_Load(object sender, EventArgs e)
        {
            
            try
            {

                //information of order head
                this.txtName.Text = order.showInvoice_head(docID).Rows[0][3].ToString();
                this.txtNote.Text = order.showInvoice_head(docID).Rows[0][2].ToString();
                this.txtID.Text = order.showInvoice_head(docID).Rows[0][0].ToString();
                this.txtTotal.Text = order.showInvoice_head(docID).Rows[0][4].ToString();
                txtAmountReceived.Text = order.showInvoice_head(docID).Rows[0][5].ToString();
                this.bunifuDatepicker1.Value = Convert.ToDateTime(order.showInvoice_head(docID).Rows[0][1].ToString());

                //information of order Tail
                this.dataGridView1.DataSource = order.showInvoice_details(docID);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
