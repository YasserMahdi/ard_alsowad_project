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
    public partial class updateInvoice : MetroFramework.Forms.MetroForm
    {
        public int id;
        BL.orderClass order = new BL.orderClass();
        DataTable dt = new DataTable();
        public int totalMoney;



        void calculateAmount()
        {
            if (txtQte.Text != string.Empty && txtMatPrice.Text != string.Empty)

                try
                {

                    txtAmount.Text = string.Format("{0:n0}", Convert.ToDouble(((Convert.ToDouble(txtMatPrice.Text) * Convert.ToInt32(txtQte.Text))).ToString()));
                }
                catch (Exception ex)
                {
                    return;
                }
        }

        void clearBoxes()
        {
            txtMatNo.Clear();
            txtMatName.Clear();
            txtMatPrice.Clear();
            txtQte.Clear();
            txtAmount.Clear();
        }






        public updateInvoice()
        {
            InitializeComponent();
        }

        private void updateInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                dt = order.showInvoice_details(id);
                this.dataGridView1.DataSource = dt;
                this.txtName.Text = order.showInvoice_head(id).Rows[0][3].ToString();
                this.txtNote.Text = order.showInvoice_head(id).Rows[0][2].ToString();
                this.txtID.Text = order.showInvoice_head(id).Rows[0][0].ToString();
                this.txtTotal.Text = order.showInvoice_head(id).Rows[0][4].ToString();
                txtAmountReceived.Text = order.showInvoice_head(id).Rows[0][5].ToString();
                this.bunifuDatepicker1.Value = Convert.ToDateTime(order.showInvoice_head(id).Rows[0][1].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtMatNo.Text)
                        {
                            MessageBox.Show("هذا المنتج موجود مسبقاً", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    DataRow r = dt.NewRow();

                    string Priceformatted = string.Format("{0:n0}", Convert.ToDouble(txtMatPrice.Text));

                    r[0] = txtMatNo.Text;
                    r[1] = txtMatName.Text;
                    r[2] = Priceformatted;
                    r[3] = txtQte.Text;
                    r[4] = txtAmount.Text;
                    dt.Rows.Add(r);

                    dataGridView1.DataSource = dt;
                    clearBoxes();

                    string totalamount = (from DataGridViewRow row in dataGridView1.Rows
                                          where row.Cells[4].FormattedValue.ToString() != string.Empty
                                          select (Convert.ToDouble(row.Cells[4].FormattedValue))).Sum().ToString();

                    txtTotal.Text = String.Format("{0:n0}", Convert.ToInt32(totalamount));
                    totalMoney = Convert.ToInt32(totalamount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQte_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            PL.listMat mat = new listMat();
            mat.ShowDialog();
            try
            {
                clearBoxes();
                txtMatNo.Text = mat.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMatName.Text = mat.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtMatPrice.Text = mat.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtQte.Focus();


            }
            catch
            {
                mat.Close();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtMatNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMatName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtQte.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMatPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            txtQte.Focus();
            calculateAmount();
        }
    }
}
