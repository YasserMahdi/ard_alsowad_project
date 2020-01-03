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
    public partial class customerForm : MetroFramework.Forms.MetroForm
    {
        BL.CustomerClass customer = new BL.CustomerClass();
        BL.debtClass debt = new BL.debtClass();
        string State;
        public customerForm()
        {
            InitializeComponent();
        }
        //RetrievalMaterials

        public customerForm(string State)
        {
            InitializeComponent();
            this.State = State;
            this.btnAdd.Hide();
            this.btnModify.Hide();
            this.BtnClose.Hide();
            this.groupBox1.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PL.insertCustomer frm = new insertCustomer();
            frm.state = "add";
            frm.ShowDialog();
            this.metroGrid1.DataSource = customer.getCustomerInfo();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            if (State == "RetrievalMaterials")
            {
                PL.customerProfile frm = new customerProfile(State);
                try
                {
                    frm.txtName.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
                    frm.id = Convert.ToInt32(this.metroGrid1.CurrentRow.Cells[0].Value);

                }
                catch
                {

                }
                frm.ShowDialog();
            }
            else
            {
                PL.customerProfile frm = new customerProfile();
                try
                {
                    frm.txtName.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
                    frm.id = Convert.ToInt32(this.metroGrid1.CurrentRow.Cells[0].Value);

                }
                catch
                {

                }
                frm.ShowDialog();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            PL.insertCustomer frm = new insertCustomer();
            frm.txtName.Text = this.metroGrid1.CurrentRow.Cells[1].Value.ToString();
            frm.txtPhone.Text = this.metroGrid1.CurrentRow.Cells[2].Value.ToString();
            frm.UserID = Convert.ToInt32(this.metroGrid1.CurrentRow.Cells[0].Value);
            frm.state = "update";
            frm.ShowDialog();
            this.metroGrid1.DataSource = customer.getCustomerInfo();
        }

        private void customerForm_Load(object sender, EventArgs e)
        {
            this.metroGrid1.DataSource = customer.getCustomerInfo();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            this.metroGrid1.DataSource = customer.searchINcostumer(this.txtSearch.Text);
        }

      
    }
}
