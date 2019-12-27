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
    public partial class ServiceList : MetroFramework.Forms.MetroForm
    {
        BL.services.selection select = new BL.services.selection();
        BL.services.searching srch = new BL.services.searching();
        public ServiceList()
        {
            InitializeComponent();
        }

        private void ServiceList_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource= select.GetServList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                PL.ServiceView frm = new ServiceView(this.dataGridView1.CurrentRow.Cells[0].ToString());
                frm.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = srch.searchinServe(this.txtSearch.Text);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
