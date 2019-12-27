﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IFarmer.PL
{
    public partial class services : MetroFramework.Forms.MetroForm
    {
        DataTable dt = new DataTable();
        BL.services.insertion insert = new BL.services.insertion();
        BL.services.selection sel = new BL.services.selection();

        BL.orderClass order = new BL.orderClass();
        int totalMoney;
        void clearBoxes()
        {

            txtMatName.Clear();
            txtMatPrice.Clear();
            txtQte.Clear();
            txtAmount.Clear();
        }

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

        void createColumns()
        {
            dt.Columns.Add("Column1");// اسم المادة
            dt.Columns.Add("Column2");//  qte
            dt.Columns.Add("Column3");// price
            dt.Columns.Add("Column4");// total amount


            this.dataGridView1.DataSource = dt;
        }

        public services()
        {
            InitializeComponent();
        }

        private void txtQte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtMatName.Text)
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

 
                    r[0] = txtMatName.Text;
                    r[1] = Priceformatted;
                    r[2] = txtQte.Text;
                    r[3] = txtAmount.Text;
                    dt.Rows.Add(r);

                    dataGridView1.DataSource = dt;
                    clearBoxes();

                    string totalamount = (from DataGridViewRow row in dataGridView1.Rows
                                          where row.Cells[3].FormattedValue.ToString() != string.Empty
                                          select (Convert.ToDouble(row.Cells[3].FormattedValue))).Sum().ToString();

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

        private void services_Load(object sender, EventArgs e)
        {
            this.bunifuDatepicker1.Value = DateTime.Now;

            txtID.Text = order.getIDforInvoice().Rows[0][0].ToString();
            createColumns();
        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = order.getIDforInvoice().Rows[0][0].ToString();
                int rAmount; int.TryParse(txtAmountReceived.Text, out rAmount);
                int total; int.TryParse(txtTotal.Text, out total);
                if (txtName.Text == string.Empty)
                {
                    MessageBox.Show("الرجاء ادخال اسم الزبون");
                }
                else if (txtAmountReceived.Text == string.Empty)
                {
                    MessageBox.Show("الرجاء ادخال المبلغ الواصل");
                }
                else if ((totalMoney - rAmount) == 0) // If the invoice is paid
                {

                    //insert the informations of invoive
                    order.add_order(Convert.ToInt32(txtCusID.Text), txtID.Text, txtNote.Text, Convert.ToDouble(txtTotal.Text),
                        Convert.ToDouble(rAmount), "YES", bunifuDatepicker1.Value, "Service");

                    //insert the detiles of invoive
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {


                        order.add_order_detail(Convert.ToInt32(0), dataGridView1.Rows[i].Cells[0].Value.ToString(),txtID.Text
                            , Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value)
                            , Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)
                           );

                    }

                    if (MessageBox.Show("تم الحفظ بنجاح هل تريد طباعة الفاتورة ", "الطباعه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Report.invoice rpt = new Report.invoice();
                            Report.ReportForm frm = new Report.ReportForm();
                            rpt.SetDataSource(order.printinvoice(Convert.ToInt32(
                                order.getLastInvoiceForPrint().Rows[0][0])));
                            frm.crystalReportViewer1.ReportSource = rpt;

                            frm.ShowDialog();
                            //frm.crystalReportViewer1.PrintReport();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
                //if there are debt 
                else if ((totalMoney - rAmount) > 1)
                {
                    //insert the informations of invoive
                    order.add_order(Convert.ToInt32(txtCusID.Text), txtID.Text, txtNote.Text, Convert.ToDouble(txtTotal.Text),
                        Convert.ToDouble(rAmount), "NO", bunifuDatepicker1.Value, "Service");

                    //insert the detiles of invoive
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {


                        order.add_order_detail(Convert.ToInt32(0), dataGridView1.Rows[i].Cells[0].Value.ToString(),txtID.Text
                            , Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value)
                            , Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)
                           );

                    }

                    BL.debtClass debt = new BL.debtClass();
                    debt.add_debt_detail( txtID.Text, Convert.ToInt32(txtCusID.Text)
                        , Convert.ToDouble(totalMoney - rAmount));


                    if (MessageBox.Show("تم حفظ الفاتورة و الدين هل تريد طباعة الفاتورة", "الطباعه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Report.invoice rpt = new Report.invoice();
                            Report.ReportForm frm = new Report.ReportForm();
                            rpt.SetDataSource(order.printinvoice(Convert.ToInt32(
                                order.getLastInvoiceForPrint().Rows[0][0])));
                            frm.crystalReportViewer1.ReportSource = rpt;

                            frm.ShowDialog();
                            //frm.crystalReportViewer1.PrintReport();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }



                //// set Seasonal_revenue from invoice

                //rpt.set_Seasonal_revenue_from_invoice(totalMoney);

                //// coumput Prices of articles

                //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                //{

                //    Seasonal_disbursements += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) *
                //        Convert.ToDouble(rpt.get_purchasing_price(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)).Rows[0][0]);

                //}
                //// set Seasonal_disbursements
                //rpt.set_seasonal_disbursements_invo_sal_dis(Seasonal_disbursements);
                //Seasonal_disbursements = 0.0;


                txtID.Text = order.getIDforInvoice().Rows[0][0].ToString();
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
    }
}