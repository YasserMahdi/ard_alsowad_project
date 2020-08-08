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
    public partial class documens : MetroFramework.Forms.MetroForm
    {
        BL.DocumentClass doc = new BL.DocumentClass();
        BL.CustomerClass customer = new BL.CustomerClass();
        DataTable dt = new DataTable();
        //DataTable dt_Seasonal_disbursements = new DataTable();
        double Seasonal_disbursements = 0.0;
        int totalMoney;
        BL.debtClass debt = new BL.debtClass();
        BL.Report rpt = new BL.Report();


        void calculateAmount()
        {
            if (txtQte.Text != string.Empty && txtMatPrice.Text != string.Empty)

                try
                {

                    txtAmount.Text = string.Format("{0:n0}", Convert.ToDouble(((Convert.ToDouble(txtMatPrice.Text) * Convert.ToInt32(txtQte.Text))).ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        void createColumns()
        {
            dt.Columns.Add("MAT ID"); //رقم المادة
            dt.Columns.Add("NAME");// اسم المادة
            dt.Columns.Add("QTE");//  qte
            dt.Columns.Add("PRICE");// price
            dt.Columns.Add("AMOUNT");// total amount

            


            this.dataGridView1.DataSource = dt;
        }



        public documens()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            PL.listCustomer frm = new listCustomer();
            frm.ShowDialog();

            try
            {

                this.txtCusID.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txtName.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                
            

            }
            catch (Exception)
            {
                return;
            }
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                int remaining = Convert.ToInt32(txtReamining.Text);
                if (txtName.Text == string.Empty || txtName.Text == "اسم الزبون")
                {
                    MessageBox.Show("الرجاء ادخال اسم الزبون");
                }
                else if (txtAmountReceived.Text == string.Empty)
                {
                    MessageBox.Show("الرجاء ادخال المبلغ الواصل");
                }
                 
                else if (remaining <= 0) // If the invoice is paid
                {

                    //insert the informations of invoive
                    doc.add_doc(Convert.ToInt32(txtCusID.Text), txtID.Text, txtNote.Text, Convert.ToDouble(
                        txtTotal.Text), Convert.ToDouble(txtAmountReceived.Text), "YES",bunifuDatepicker1.Value);

                    //insert the detiles of invoive
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        doc.add_doc_detail(Convert.ToInt32(this.dataGridView1.Rows[i].Cells[0].Value),
                            this.dataGridView1.Rows[i].Cells[1].Value.ToString(),
                            Convert.ToInt32(txtID.Text), Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                            Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value),
                            Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value));

                    }

                    MessageBox.Show("تم الحفظ بنجاح   ", "عملية الحفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    

                }
                //if there are debt 
                else if ((remaining) > 0)
                {
                    //insert the informations of invoive
                    doc.add_doc(Convert.ToInt32(txtCusID.Text), txtID.Text, txtNote.Text, Convert.ToDouble(
                        txtTotal.Text), Convert.ToDouble(txtAmountReceived.Text), "NO", bunifuDatepicker1.Value);

                    //insert the detiles of invoive
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {

                        doc.add_doc_detail(Convert.ToInt32(this.dataGridView1.Rows[i].Cells[0].Value),
                            this.dataGridView1.Rows[i].Cells[1].Value.ToString(),
                            Convert.ToInt32(txtID.Text), Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                            Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value),
                            Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value));

                    }

                    debt.add_debt_detail( txtID.Text, Convert.ToInt32(txtCusID.Text), Convert.ToDouble(txtReamining.Text));


                    MessageBox.Show("تم الحفظ بنجاح   ", "عملية الحفظ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }

                

                //// set seasonal_revenue
                //rpt.set_seasonal_revenue(Convert.ToInt32(txtSeasonID.Text), totalMoney);

                

                //// coumput Prices of articles
                //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                //{

                //    Seasonal_disbursements += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) *
                //        Convert.ToDouble(rpt.get_purchasing_price(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)).Rows[0][0]);

                //}
                //// set Seasonal_disbursements
                //rpt.set_Seasonal_disbursements(Convert.ToInt32(txtSeasonID.Text), Seasonal_disbursements);
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

        private void documens_Load(object sender, EventArgs e)
        {
            txtID.Text = doc.getIDforDoc().Rows[0][0].ToString();
            createColumns();
            this.bunifuDatepicker1.Value = DateTime.Now;
        }

        private void txtAmountReceived_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAmountReceived.Text.Equals("المبلغ الواصل"))
                {
                    return;
                }
                else if (txtAmountReceived.Text.Equals(""))
                {
                    return;
                }
                else
                {


                    int rRec; int.TryParse(txtAmountReceived.Text, out rRec);
                    int rReam = (totalMoney - rRec);
                    txtReamining.Text = Convert.ToString(rReam);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " \n Error in Text changed");
            }
        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.oldDept.Text = string.Format("{0:0n}", debt.fetchOldDebt(Convert.ToInt32(this.txtCusID.Text)).Rows[0][0].ToString()); 
            }
            catch
            {
                this.oldDept.Text = null;
            }
            try
            {
                this.txtNote.Text = customer.fetchNote(Convert.ToInt32(this.txtCusID.Text)).Rows[0][0].ToString();
            }
            catch
            {
                this.txtNote.Text = null;
            }
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
