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
    public partial class Pay : MetroFramework.Forms.MetroForm
    {
        BL.debtClass debt = new BL.debtClass();
        public string State;
        public int temp;
        public Pay()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (State == "inv")
                {
 
                    if (temp == 0)
                    {
                        MessageBox.Show("لا يوجد دين", "السداد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (temp < Convert.ToInt32(txtPay.Text))
                    {

                        MessageBox.Show(" تم ادخال مبلغ اكبر من قيمة الدين", "السداد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        debt.processOnDebtRepaymentForInvoice(Convert.ToInt32(txtID.Text), Convert.ToDouble(txtPay.Text));
                        
                        debt.set_RepaymentForInvoice_in_the_tables(Convert.ToInt32(txtID.Text), Convert.ToDouble(txtPay.Text),txtNote.Text);

                        BL.CashBox.Months mnth = new BL.CashBox.Months();
                        mnth.set_new_month();
                        DataTable LastMonth = mnth.sel_last_month();
                        BL.CashBox.BoxInsertion insrt = new BL.CashBox.BoxInsertion();
                        insrt.SetCash(Convert.ToInt32(txtPay.Text), "سداد", DateTime.Now, LastMonth.Rows[0][0].ToString());
                        MessageBox.Show(" تمت العملية بنجاح", "السداد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            // cheack !! 
            //BL.debtClass debt = new BL.debtClass();
            //DataTable Dt_not_paid_invo = debt.processOnDebtRepaymentForInvoice(15, 20000.0);
            //foreach (DataRow row in Dt_not_paid_invo.Rows)
            //{
            //    MessageBox.Show(Convert.ToString(row["recived"]));
            //}
        }
    }
}
