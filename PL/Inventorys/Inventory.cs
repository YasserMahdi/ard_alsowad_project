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
    public partial class Inventory : MetroFramework.Forms.MetroForm
    {
        BL.categories cat = new BL.categories();
        BL.inputClass InPut = new BL.inputClass();
        BL.CatClass Categorie = new BL.CatClass();
        BL.StoresaMnagement StoreMng = new BL.StoresaMnagement();
        public Inventory()
        {
            InitializeComponent();
            
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            PL.DataEntry frm = new DataEntry();
            frm.ShowDialog();
            this.bunifuCustomDataGrid1.DataSource = cat.getCategoriesInfo("1");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            PL.DisplayMaterials frm = new DisplayMaterials(this.bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString(), comboBox1.SelectedValue.ToString());
            frm.ShowDialog();
       
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                PL.updateTypes frm = new updateTypes();
                frm.txtCatName.Text = this.bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
                frm.typeID = Convert.ToInt32(this.bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                this.bunifuCustomDataGrid1.DataSource = cat.getCategoriesInfo("1");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void seedAndMaterialForm_Load(object sender, EventArgs e)
        {

            try
            {
                this.comboBox1.DisplayMember = "store";
                this.comboBox1.ValueMember = "id";
                this.comboBox1.DataSource = StoreMng.selectStore();
                this.bunifuCustomDataGrid1.DataSource = cat.getCategoriesInfo(comboBox1.SelectedValue.ToString());
            }
            catch
            {

            }

        }

     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.bunifuCustomDataGrid1.DataSource = cat.getCategoriesInfo(comboBox1.SelectedValue.ToString());
             
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد الحذف فعلا", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Categorie.DeleteCat(this.bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString());
                    MessageBox.Show("تم الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.bunifuCustomDataGrid1.DataSource = cat.getCategoriesInfo(comboBox1.SelectedValue.ToString());


                }
                else
                {
                    MessageBox.Show("تم الغاء عمليةالحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnModify_Click_1(object sender, EventArgs e)
        {
            PL.updateTypes frm = new updateTypes();
            frm.txtCatName.Text = this.bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            frm.OldName = this.bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString();
            frm.typeID = Convert.ToInt32(this.bunifuCustomDataGrid1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            this.bunifuCustomDataGrid1.DataSource = cat.getCategoriesInfo(comboBox1.SelectedValue.ToString());
        }

        private void BtnStoreManagement_Click(object sender, EventArgs e)
        {
            PL.stores frm = new stores();
            frm.ShowDialog();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            BL.store.Search srch = new BL.store.Search();
            this.bunifuCustomDataGrid1.DataSource = srch.SearchInCat(this.bunifuMaterialTextbox1.Text,this.comboBox1.SelectedValue.ToString());
        }
    }
}
