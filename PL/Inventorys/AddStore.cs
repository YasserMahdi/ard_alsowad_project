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
    public partial class UpdateStore : MetroFramework.Forms.MetroForm
    {
        public UpdateStore()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BL.StoresaMnagement sm = new BL.StoresaMnagement();
                sm.InsertStore(this.TxtName.Text);
                MessageBox.Show("تمت الاظافة", "الحفظ", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateStore_Load(object sender, EventArgs e)
        {

        }
    }
}
