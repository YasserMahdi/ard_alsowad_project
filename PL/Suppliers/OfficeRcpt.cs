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
    public partial class OfficeRcpt : MetroFramework.Forms.MetroForm
    {
        BL.CompaniesClass comp = new BL.CompaniesClass();
        BL.debtClass dbt = new BL.debtClass();
        BL.StoresaMnagement StoreMng = new BL.StoresaMnagement();
        BL.CatClass cat = new BL.CatClass();
        BL.inputClass sam = new BL.inputClass();

        DataTable dt = new DataTable();


        void calculateAmount()
        {
            if (txtQte.Text != string.Empty && txtMatPrice.Text != string.Empty)

                try
                {

                    txtAmount.Text = string.Format("{0:n0}", Convert.ToDouble(((Convert.ToDouble(this.txtMatPrice.Text) * Convert.ToDouble(txtQte.Text))).ToString()));
                }
                catch (Exception ex)
                {
                    return;
                }
        }

        void createColumns()
        {
            dt.Columns.Add("Column1");// اسم المادة
            dt.Columns.Add("Column2");//  qte
            dt.Columns.Add("Column3");//  qte
            dt.Columns.Add("Column4");// price
            dt.Columns.Add("Column5");// total amount
            dt.Columns.Add("Column6");// cat


            this.DataGrid1.DataSource = dt;
        }

        void clearBoxes()
        {

            txtMatName.Clear();
            txtMatPrice.Clear();
            txtQte.Clear();
            txtAmount.Clear();
        }

        public OfficeRcpt()
        {
            InitializeComponent();
            createColumns();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CompanyProfile_Load(object sender, EventArgs e)
        {
            try
            {



                this.txtOrderID.Text = comp.getIdForCompOrder().Rows[0][0].ToString();

                this.metroComboBox1.DisplayMember = "store";
                this.metroComboBox1.ValueMember = "id";
                this.metroComboBox1.DataSource = StoreMng.selectStore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            PL.compDeptHistory frm = new PL.compDeptHistory();
            frm.name = txtName.Text;
            frm.ShowDialog();
        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    for (int i = 0; i < DataGrid1.Rows.Count - 1; i++)
                    {
                        if (DataGrid1.Rows[i].Cells[0].Value.ToString() == txtMatName.Text)
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



                r[0] = txtMatName.Text;
                r[1] = Priceformatted;
                r[2] = TxtSale.Text;
                r[3] = Convert.ToDouble(txtQte.Text);
                r[4] = txtAmount.Text;
                r[5] = TxtCat.Text;
                dt.Rows.Add(r);


                DataGrid1.DataSource = dt;
                clearBoxes();



                string totalamount = (from DataGridViewRow row in DataGrid1.Rows
                                      where row.Cells[4].FormattedValue.ToString() != string.Empty
                                      select (Convert.ToDouble(row.Cells[4].FormattedValue))).Sum().ToString();

                // txtTotal.Text = String.Format("{0:n0}", Convert.ToInt32(totalamount));
                txtTotal.Text = totalamount;

            }
        }

        private void txtQte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void txtQte_KeyUp(object sender, KeyEventArgs e)
        {
            calculateAmount();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                //this.txtTotalDebt.Text = dbt.fetchCompaniesDebts(txtName.Text).Rows[0][0].ToString();
                //set order header
                comp.add_comp_order(this.txtName.Text, Convert.ToDouble(this.txtTotal.Text));

                //set order tail
                for (int i = 0; i < DataGrid1.Rows.Count - 1; i++)
                {
                    comp.add_comp_order_detail(Convert.ToInt32(txtOrderID.Text), this.DataGrid1.Rows[i].Cells[0].Value.ToString(),
                       Convert.ToDouble(this.DataGrid1.Rows[i].Cells[2].Value), Convert.ToDouble(this.DataGrid1.Rows[i].Cells[1].Value), Convert.ToDouble(this.DataGrid1.Rows[i].Cells[3].Value));



                }
                //set order debts
                dbt.setCompaniesDebts(Convert.ToInt32(txtOrderID.Text), txtName.Text, Convert.ToDouble(txtTotal.Text));

                //MessageBox.Show(" تم الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //insert Materials in stock

                for (int i = 0; i < this.DataGrid1.Rows.Count - 1; i++)
                {

                    sam.insertMtr(DataGrid1.Rows[i].Cells[0].Value.ToString(), Convert.ToDouble(DataGrid1.Rows[i].Cells[1].Value),
                        Convert.ToDouble(DataGrid1.Rows[i].Cells[2].Value), Convert.ToInt32(DataGrid1.Rows[i].Cells[3].Value),
                        DataGrid1.Rows[i].Cells[5].Value.ToString(), metroComboBox1.SelectedValue.ToString());


                }
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //this.txtTotalDebt.Text = dbt.fetchCompaniesDebts(txtName.Text).Rows[0][0].ToString();

                this.txtOrderID.Text = comp.getIdForCompOrder().Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                PL.compDebtProcess frm = new PL.compDebtProcess();
                frm.state = "dbt";
                frm.name = txtName.Text;
                frm.ShowDialog();
                //this.txtTotalDebt.Text = dbt.fetchCompaniesDebts(txtName.Text).Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            PL.compDebtProcess frm = new PL.compDebtProcess();
            frm.state = "rep";
            frm.name = txtName.Text;
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dtforsuggest = new DataTable();
            try
            {
                if (TxtCat.Text != null)
                {
                    if (TxtCat.Text.Length >= 2)
                    {
                        dtforsuggest = cat.getSuggest(TxtCat.Text, metroComboBox1.SelectedValue.ToString());
                        AutoCompleteStringCollection datascurce = new AutoCompleteStringCollection();
                        for (int i = 0; i < dtforsuggest.Rows.Count; i++)
                        {
                            datascurce.Add(dtforsuggest.Rows[i][0].ToString());
                        }
                        this.TxtCat.AutoCompleteCustomSource = datascurce;
                        this.TxtCat.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        this.TxtCat.AutoCompleteMode = AutoCompleteMode.Suggest;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMatPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
