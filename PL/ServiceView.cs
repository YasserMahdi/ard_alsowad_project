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
    public partial class ServiceView : MetroFramework.Forms.MetroForm
    {
        BL.services.selection slt = new BL.services.selection();
        string id;
        public ServiceView()
        {
            InitializeComponent();
        }

        public ServiceView(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ServiceView_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtID.Text = slt.GetServHead(id).Rows[0][0].ToString();
                this.bunifuDatepicker1.Value = Convert.ToDateTime(slt.GetServHead(id).Rows[0][1]);
                this.txtNote.Text = slt.GetServHead(id).Rows[0][2].ToString();
                this.txtName.Text = slt.GetServHead(id).Rows[0][3].ToString();
                this.txtTotal.Text = slt.GetServHead(id).Rows[0][4].ToString();
                this.txtAmountReceived.Text = slt.GetServHead(id).Rows[0][4].ToString();
                this.dataGridView1.DataSource = slt.GetServTail(id);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
