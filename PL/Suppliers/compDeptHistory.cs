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
    public partial class compDeptHistory : MetroFramework.Forms.MetroForm
    {
        public string name;
        BL.debtClass dbt = new BL.debtClass();
        public compDeptHistory()
        {
            InitializeComponent();
        }

        private void compDeptHistory_Load(object sender, EventArgs e)
        {
            
                this.bunifuCustomDataGrid1.DataSource = dbt.compDebtHistory(name);
            
        }

    }
}
