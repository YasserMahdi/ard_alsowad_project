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
    public partial class Backup : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = new SqlConnection(@"server=.\SQLEXPRESS;database=IFarmer;integrated security=true");
        SqlCommand cmd;
        public Backup()
        {
            InitializeComponent();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textpath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = textpath.Text + "\\BACKUP" + DateTime.Now.ToShortDateString().Replace('/', '-')
                + DateTime.Now.ToLongDateString().Replace('/', '-');
                string query = "Backup Database IFarmer to Disk='" + filename + ".bak'";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("تم انشاء النسخة الاحتياطية");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
