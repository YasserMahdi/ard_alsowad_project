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
    public partial class Expenses : MetroFramework.Forms.MetroForm
    {
        BL.Expenses exp = new BL.Expenses();
        BL.Report rpt = new BL.Report();
        public int seasonID;
        public string name;
        public Expenses()
        {
            InitializeComponent();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                exp.insSalary(txtName.Text, Convert.ToDouble(txtSal.Text), dateTimePicker1.Value);
                MessageBox.Show("تم العملية بنجاح", "الرواتب", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rpt.set_seasonal_disbursements_invo_sal_dis(Convert.ToDouble(txtSal.Text));
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEpxSave_Click(object sender, EventArgs e)
        {
            try
            {
                exp.insExpenses(txtFor.Text, Convert.ToDouble(txtAmount.Text), dateTimePicker2.Value);
                MessageBox.Show("تم العملية بنجاح", "الرواتب", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                rpt.set_seasonal_disbursements_invo_sal_dis(Convert.ToDouble(txtSal.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.listCurrentSeasons frm = new listCurrentSeasons();
            //this.textBox1.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
            frm.ShowDialog();
            try
            {
                this.txtSeasonName.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.seasonID = Convert.ToInt32(frm.dataGridView1.CurrentRow.Cells[0].Value);
                this.name =frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.txtSeasonName.Text != string.Empty) {
                if (MessageBox.Show("هل تريد اضافة صرفيات لهذا الموسم" + " " + txtSeasonName.Text + " " + "لقد تم اختيار الموس  ", "صرفيات"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PL.OneSeasonsDisbursements frm = new OneSeasonsDisbursements();
                    frm.txtID.Text = seasonID.ToString();
                    frm.txtName.Text = name;
                    frm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("الرجاء اختيار موسم", "تنلبه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
