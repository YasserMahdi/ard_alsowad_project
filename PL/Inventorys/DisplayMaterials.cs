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
    public partial class DisplayMaterials : MetroFramework.Forms.MetroForm
    {
        BL.inputClass InPut = new BL.inputClass();
        string ClsId;
        string strId;
        public DisplayMaterials()
        {
            InitializeComponent();
        }
        public DisplayMaterials(string ClassName,string StoreIdentity)
        {
            InitializeComponent();
            this.ClsId = ClassName;
            this.strId = StoreIdentity;
        }

        private void DisplayMaterials_Load(object sender, EventArgs e)
        {
            try
            {
                //string cheack = seed.BringSeedsByType(this.bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString()).Rows[0][0].ToString();
                this.dataGridView1.DataSource = InPut.BringSeedsByType(ClsId,strId);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntMatUpdate_Click(object sender, EventArgs e)
        {
            PL.Inventorys.ModifyM frm = new Inventorys.ModifyM(this.dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                this.dataGridView1.CurrentRow.Cells[1].Value.ToString(),this.dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                this.dataGridView1.CurrentRow.Cells[3].Value.ToString(), this.dataGridView1.CurrentRow.Cells[4].Value.ToString());
            frm.ShowDialog();
            try
            {
                //string cheack = seed.BringSeedsByType(this.bunifuCustomDataGrid1.CurrentRow.Cells[1].Value.ToString()).Rows[0][0].ToString();
                this.dataGridView1.DataSource = InPut.BringSeedsByType(ClsId, strId);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
