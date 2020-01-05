using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IFarmer.PL
{
    public partial class Restore : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS;database=master;integrated security=true");
        SqlCommand cmd;
        public Restore()
        {
            InitializeComponent();
        }

    
 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGO_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("سؤدي الى حذف البيانات الغير مدرجة ضمن ملف النسخ الاحتياطي المحدد", "عملية الاستعادة", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string query = "ALTER Database blackness SET OFFLINE WITH ROLLBACK IMMEDIATE ; Restore Database blackness from Disk='" + textpath.Text + "'";
                    cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("تم استعادة النسخة الاحتياطية");


                } 
                else
                {
                    MessageBox.Show("تم الغاء العملية", "عملية الاستعادة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectPath_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textpath.Text = openFileDialog1.FileName;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
