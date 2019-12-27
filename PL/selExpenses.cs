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
    public partial class selExpenses : Form
    {
        BL.Expenses exp = new BL.Expenses();
        public selExpenses()
        {
            InitializeComponent();
            this.dataGridView1.DataSource =  exp.selExpenses();

        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
