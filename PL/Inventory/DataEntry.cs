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
    public partial class DataEntry : MetroFramework.Forms.MetroForm
    {
        BL.inputClass sam = new BL.inputClass();
        BL.categories cat = new BL.categories();
        BL.StoresaMnagement StoreMng = new BL.StoresaMnagement();
        public DataEntry()
        {
            InitializeComponent();
            
             
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         
 
 
        private void bntCatSave_Click_1(object sender, EventArgs e)
        {
           
        }

        private void DataEntry_Load(object sender, EventArgs e)
        {
            try
            {
                

                this.ComboBox2Store.DisplayMember = "store";
                this.ComboBox2Store.ValueMember = "id";
                this.ComboBox2Store.DataSource = StoreMng.selectStore();

                this.comboBox1.DisplayMember = "cat_name";
                this.comboBox1.ValueMember = "cat_id";
                this.comboBox1.DataSource = cat.getCategoriesInfo(ComboBox2Store.SelectedValue.ToString());

                this.ComboBoxCatStock.DisplayMember = "store";
                this.ComboBoxCatStock.ValueMember = "id";
                this.ComboBoxCatStock.DataSource = StoreMng.selectStore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                sam.insertCat(txtCatName.Text, ComboBoxCatStock.SelectedValue.ToString());
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // for update combo box
                this.comboBox1.DisplayMember = "cat_name";
                this.comboBox1.ValueMember = "cat_id";
                this.comboBox1.DataSource = cat.getCategoriesInfo(ComboBox2Store.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntMatSave_Click(object sender, EventArgs e)
        {
            try
            {
                sam.insertMtr(txtMatName.Text, Convert.ToDouble(txtBprice.Text), Convert.ToDouble(
                txtSprice.Text), Convert.ToInt32(txtQte.Text), comboBox1.GetItemText(comboBox1.SelectedItem), ComboBoxCatStock.SelectedValue.ToString());
                MessageBox.Show("تمت الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox2Store_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox1.DisplayMember = "cat_name";
            this.comboBox1.ValueMember = "cat_id";
            if (cat.getCategoriesInfo(ComboBox2Store.SelectedValue.ToString()).Equals(null)){
                
                comboBox1.DisplayMember = null;
                comboBox1.ValueMember = null;
                this.comboBox1.DataSource = null;
            }
            else
            {
                this.comboBox1.DataSource = cat.getCategoriesInfo(ComboBox2Store.SelectedValue.ToString());
            }
        }
    }
}
