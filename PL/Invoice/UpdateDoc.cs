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
    public partial class UpdateDoc : MetroFramework.Forms.MetroForm
    {
        public int docID;
        public int totalMoney;
        DataTable dt = new DataTable();
        BL.DocumentClass doc = new BL.DocumentClass();




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



        public UpdateDoc()
        {
            InitializeComponent();
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
                try
                {
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
                catch(Exception ex)
                {
                    MessageBox.Show("Error in Quantity KeyDown\n"+ex.Message);
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

        private void UpdateDoc_Load(object sender, EventArgs e)
        {
            dt = doc.docTail(docID);
            dataGridView1.DataSource = dt;
            this.txtID.Text = doc.docHead(docID).Rows[0][0].ToString();
            this.txtName.Text = doc.docHead(docID).Rows[0][1].ToString();
            this.txtNote.Text = doc.docHead(docID).Rows[0][2].ToString();
            this.bunifuDatepicker1.Value = Convert.ToDateTime(doc.docHead(docID).Rows[0][3].ToString());
            this.txtTotal.Text = doc.docHead(docID).Rows[0][4].ToString();
            this.txtAmountReceived.Text = doc.docHead(docID).Rows[0][5].ToString();
            this.txtReamining.Text = doc.docHead(docID).Rows[0][6].ToString();
            this.txtSeasonID.Text = doc.docHead(docID).Rows[0][7].ToString();
            this.txtSeasonName.Text = doc.docHead(docID).Rows[0][8].ToString();
            this.dataGridView1.DataSource = doc.docTail(docID);
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
