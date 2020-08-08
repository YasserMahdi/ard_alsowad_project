using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IFarmer.DataGroup
{
    public partial class TwoMonthAgo : MetroFramework.Forms.MetroForm
    {
        DataGroup.NotificationDataGroup notify = new NotificationDataGroup();
        public TwoMonthAgo()
        {
            InitializeComponent();
        }

        private void TwoMonthAgo_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = notify.sel_orders();
        }
    }
}
