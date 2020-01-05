using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IFarmer.PL.admin
{
    public partial class Users : MetroFramework.Forms.MetroForm
    {
        BL.admin.SelectUser selectusr = new BL.admin.SelectUser();
        BL.admin.DeleteUser DeleteUser = new BL.admin.DeleteUser();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = selectusr.SelUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Users", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            PL.Register frm = new Register();
            frm.ShowDialog();
            try
            {
                this.dataGridView1.DataSource = selectusr.SelUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Users", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد الحذف فعلا", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    DeleteUser.DeleteUsr(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تم الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dataGridView1.DataSource = selectusr.SelUsers();


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

        private void BtnUpdateUserInfo_Click(object sender, EventArgs e)
        {
            try
            {
                PL.Register frm = new Register(this.dataGridView1.CurrentRow.Cells[0].Value.ToString(), this.dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                 this.dataGridView1.CurrentRow.Cells[2].Value.ToString(), this.dataGridView1.CurrentRow.Cells[3].Value.ToString()
                  );
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
