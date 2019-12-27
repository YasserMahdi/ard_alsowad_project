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
    public partial class profit : Form
    {
        BL.Report rpt = new BL.Report();
        public profit()
        {
            InitializeComponent();
        }

        private void profit_Load(object sender, EventArgs e)
        {
            DataTable Dt = rpt.profitcount();
            
            this.metroGrid1.DataSource = Dt;
            
        }
    }
}
