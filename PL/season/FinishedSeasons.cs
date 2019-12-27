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

    public partial class FinishedSeasons : Form
    {

        BL.Seasons son = new BL.Seasons();
        public FinishedSeasons()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = son.fetchFinisheSeasons();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = son.searchInFinisheSeasons(txtSearch.Text);
        }
    }
}
