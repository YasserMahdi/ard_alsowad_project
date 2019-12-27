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

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textpath.Text = openFileDialog1.FileName;
            }
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "ALTER Database IFarmer SET OFFLINE WITH ROLLBACK IMMEDIATE ; Restore Database IFarmer from Disk='" + textpath.Text + "'";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("تم استعادة النسخة الاحتياطية");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
