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
    public partial class UpdateStoreName : MetroFramework.Forms.MetroForm
    {
        BL.StoresaMnagement sm = new BL.StoresaMnagement();
        public string StoreName;
        public string StoreID;
        public UpdateStoreName()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                sm.UpdateStoreName(StoreID, TxtName.Text);
                MessageBox.Show("تم التحديث", "التحديث ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "التحديث", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void UpdateStoreName_Load(object sender, EventArgs e)
        {
            TxtName.Text = StoreName;
        }
    }
}
