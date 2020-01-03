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
        string TotalAmount;
        string Recived;
        public int totalMoney;



        //void calculateAmount()
        //{
        //    if (txtQte.Text != string.Empty && txtMatPrice.Text != string.Empty)

        //        try
        //        {

        //            txtAmount.Text = string.Format("{0:n0}", Convert.ToDouble(((Convert.ToDouble(txtMatPrice.Text) * Convert.ToInt32(txtQte.Text))).ToString()));
        //        }
        //        catch (Exception ex)
        //        {
        //            return;
        //        }
        //}



        //void clearBoxes()
        //{

        //    txtMatName.Clear();
        //    txtMatPrice.Clear();
        //    txtQte.Clear();
        //    txtAmount.Clear();
        //}






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
                this.txtCusID.Text = order.showInvoice_head(id).Rows[0][4].ToString();
                this.txtName.Text = order.showInvoice_head(id).Rows[0][3].ToString();
                this.txtNote.Text = order.showInvoice_head(id).Rows[0][2].ToString();
                this.txtID.Text = order.showInvoice_head(id).Rows[0][0].ToString();
                this.txtTotal.Text = order.showInvoice_head(id).Rows[0][5].ToString();
                txtAmountReceived.Text = order.showInvoice_head(id).Rows[0][6].ToString();
                this.bunifuDatepicker1.Value = Convert.ToDateTime(order.showInvoice_head(id).Rows[0][1].ToString());
                TotalAmount = order.showInvoice_head(id).Rows[0][5].ToString();
                Recived = order.showInvoice_head(id).Rows[0][6].ToString();

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
                //try
                //{
                //    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                //    {
                //        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtMatNo.Text)
                //        {
                //            MessageBox.Show("هذا المنتج موجود مسبقاً", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //            return;
                //        }

                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}

                //try
                //{
                //    DataRow r = dt.NewRow();

                //    string Priceformatted = string.Format("{0:n0}", Convert.ToDouble(txtMatPrice.Text));

                //    //r[0] = txtMatNo.Text;
                //    r[0] = txtMatName.Text;
                //    r[1] = Priceformatted;
                //    r[2] = txtQte.Text;
                //    r[3] = txtAmount.Text;
                //    dt.Rows.Add(r);

                //    dataGridView1.DataSource = dt;
                //    clearBoxes();

                //    string totalamount = (from DataGridViewRow row in dataGridView1.Rows
                //                          where row.Cells[3].FormattedValue.ToString() != string.Empty
                //                          select (Convert.ToDouble(row.Cells[3].FormattedValue))).Sum().ToString();

                //    txtTotal.Text = String.Format("{0:n0}", Convert.ToInt32(totalamount));
                //    totalMoney = Convert.ToInt32(totalamount);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}


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
            //calculateAmount();
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            //PL.listMat mat = new listMat();
            //mat.ShowDialog();
            //try
            //{
            //    clearBoxes();
            //    //txtMatNo.Text = mat.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //    txtMatName.Text = mat.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //    txtMatPrice.Text = mat.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //    txtQte.Focus();


            //}
            //catch
            //{
            //    mat.Close();

            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //txtMatNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //    txtMatName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //    txtQte.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //    txtMatPrice.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            //    txtQte.Focus();
            //    calculateAmount();
            //}

            //private void txtAmountReceived_TextChanged(object sender, EventArgs e)
            //{
            //    try
            //    {
            //        if (txtAmountReceived.Text.Equals(""))
            //        {
            //            return;
            //        }
            //        else
            //        {


            //            int rRec; int.TryParse(txtAmountReceived.Text, out rRec);
            //            int rReam = (totalMoney - rRec);
            //            TxtRm.Text = string.Format("{0:n0}", Convert.ToDouble(rReam));

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message + " \n Error in Text changed");
            //    }
            //}

            //private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
            //{
            //    if (e.KeyChar == 8 )
            //    {

            //        try
            //        {
            //            if (MessageBox.Show("هل تريد الحذف فعلا", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //            {
            //                BL.invoices.DeleteMaterials DelMat = new BL.invoices.DeleteMaterials();
            //                DelMat.DeleteOrderMat(this.dataGridView1.CurrentRow.Cells[0].Value.ToString(), this.txtID.Text, this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
            //            }
            //                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            //        }
            //        catch(Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }


            //        string totalamount = (from DataGridViewRow row in dataGridView1.Rows
            //                              where row.Cells[3].FormattedValue.ToString() != string.Empty
            //                              select (Convert.ToDouble(row.Cells[3].FormattedValue))).Sum().ToString();

            //        txtTotal.Text = String.Format("{0:n0}", Convert.ToInt32(totalamount));
            //        totalMoney = Convert.ToInt32(totalamount);

            //    }
            //}


        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                string totalamount = (from DataGridViewRow row in dataGridView1.Rows
                                      where row.Cells[3].FormattedValue.ToString() != string.Empty
                                      select (Convert.ToDouble(row.Cells[3].FormattedValue))).Sum().ToString();

                txtTotal.Text = String.Format("{0:n0}", Convert.ToInt32(totalamount));
                totalMoney = Convert.ToInt32(totalamount);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("هل تريد التحديث فعلا", "التحديث ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int rAmount; int.TryParse(txtAmountReceived.Text, out rAmount);
                    BL.invoices.UpdateOrder update = new BL.invoices.UpdateOrder();
                    update.DeleteOrder(this.txtID.Text);
                    //insert the informations of invoive
                    order.add_order(Convert.ToInt32(txtCusID.Text), txtID.Text, txtNote.Text, Convert.ToDouble(this.txtTotal.Text),
                        Convert.ToDouble(this.txtAmountReceived.Text), "non", bunifuDatepicker1.Value, "Office");

                    //insert the detiles of invoive
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {


                        order.add_order_detail_update(dataGridView1.Rows[i].Cells[0].Value.ToString(), txtID.Text
                            , Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value)
                            , Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)
                           );

                    }
                    string OldDebt = Convert.ToString(Convert.ToDouble(TotalAmount) - Convert.ToDouble(Recived));
                    BL.invoices.UpdateDebtsAffterDeleteOrderMat UpdateDebts = new BL.invoices.UpdateDebtsAffterDeleteOrderMat();
                    UpdateDebts.UpdateDebts(this.txtCusID.Text, this.txtID.Text, OldDebt, Convert.ToDouble(Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtAmountReceived.Text)), this.bunifuDatepicker1.Value);



                    MessageBox.Show("تم التحديث بنجاح", "التحديث", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



                }
                else
                {
                    MessageBox.Show("تم الغاء عملية التحديث", " التحديث  ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
