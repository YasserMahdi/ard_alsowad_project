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
    public partial class categoriesQue : Form
    {
        BL.categories cats = new BL.categories();
        public categoriesQue()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = cats.getCategoriesInfo("1");
        }
    }
}
