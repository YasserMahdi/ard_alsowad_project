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
    public partial class listCurrentSeasons : Form
    {
        BL.Seasons son = new BL.Seasons();
        public listCurrentSeasons()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = son.fetchCurrentSeasons();
        }

        private void listCurrentSeasons_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
