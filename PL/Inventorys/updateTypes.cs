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
    public partial class updateTypes : MetroFramework.Forms.MetroForm
    {
        public int typeID;
        public string OldName;
        BL.CatClass cat = new BL.CatClass();
        public updateTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateTypes_Load(object sender, EventArgs e)
        {

        }

        
        private void bntCatSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                cat.UpdateCatName(txtCatName.Text, typeID, OldName);
                MessageBox.Show("تم التحديث بنجاح", "التحدبث", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
