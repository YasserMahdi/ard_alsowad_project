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
    public partial class CurrentSeasons : Form
    {
        BL.Seasons son = new BL.Seasons();
        public CurrentSeasons()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = son.fetchCurrentSeasons();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = son.searchInCurrentSeasons(txtSearch.Text);
        }

        private void CurrentSeasons_Load(object sender, EventArgs e)
        {

        }
    }
}
