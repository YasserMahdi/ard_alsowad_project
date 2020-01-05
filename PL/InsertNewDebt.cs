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
    public partial class InsertNewDebt : MetroFramework.Forms.MetroForm
    {
        string CustomerId;
        string CustomerName;
        public InsertNewDebt()
        {
            InitializeComponent();
        }

        public InsertNewDebt(int id,string Name)
        {
            InitializeComponent();
            this.CustomerId = Convert.ToString(id);
            this.CustomerName = Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BL.debts.InsertNewDebts ins = new BL.debts.InsertNewDebts();
            ins.Add_New_debt(CustomerId,txtMoney.Text,txtNote.Text,this.DateTime2.Value);
            MessageBox.Show("تم اضافة الدين");
        }

        private void InsertNewDebt_Load(object sender, EventArgs e)
        {
            this.txtID.Text = this.CustomerId;
            this.txtName.Text = this.CustomerName;
            this.DateTime2.Value = DateTime.Now;
        }
    }
}
