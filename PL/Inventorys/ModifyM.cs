using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IFarmer.PL.Inventorys
{
    public partial class ModifyM : MetroFramework.Forms.MetroForm
    {
        string MatId;
        public ModifyM()
        {
            InitializeComponent();
        }
            
        public ModifyM(string MatId, string Name , string Pprice,string Sprice,string Qte )
        {
            InitializeComponent();
            try
            {
                this.txtMatName.Text = Name;
                this.txtPprice.Text = Pprice;
                this.txtSprice.Text = Sprice;
                this.txtQte.Text = Qte;
                this.MatId = MatId;
            }
            catch
            {

            }
        }

        private void ModifyM_Load(object sender, EventArgs e)
        {

        }

        private void bntMatUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                BL.store.Updater Updater = new BL.store.Updater();
                Updater.UpdaterMtr(this.MatId,txtMatName.Text, Convert.ToDouble(txtPprice.Text), Convert.ToDouble(
                txtSprice.Text), Convert.ToInt32(txtQte.Text));
                MessageBox.Show("تم التحديث بنجاح", "عملية التحديث", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
