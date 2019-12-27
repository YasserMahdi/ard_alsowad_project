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
    public partial class OneSeasonsDisbursements : Form
    {
        BL.Report rpt = new BL.Report();
        public OneSeasonsDisbursements()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                rpt.set_Seasonal_disbursements(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtAmonut.Text));
                MessageBox.Show("تمت الاضافة بنجاح", "الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
