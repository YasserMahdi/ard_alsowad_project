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
    public partial class insertCustomer : MetroFramework.Forms.MetroForm
    {
        public string state;
        public int UserID;
        public insertCustomer()
        {
            InitializeComponent();
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            BL.CustomerClass obj = new BL.CustomerClass();

            try
            {
                if (state == "add")
                {
                    if (txtName.Text != string.Empty && txtPhone.Text != string.Empty
                        && txtPhone.Text != "رقم الهاتف " && txtName.Text != "اسم الزبون ")
                    {
                        obj.InsertCus(txtName.Text, txtPhone.Text,txtNote.Text);
                        MessageBox.Show("تم الحفظ بنجاح", "عملية الحفظ",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {
                        MessageBox.Show("الرجاء ادخال المعلومات");
                    }
                }
                else
                {
                    if (txtName.Text != string.Empty && txtPhone.Text != string.Empty
                        && txtPhone.Text != "رقم الهاتف " && txtName.Text != "اسم الزبون ")
                    {
                        obj.updateCus(txtName.Text, txtPhone.Text, UserID);
                        MessageBox.Show("تم الحفظ بنجاح", "عملية الحفظ",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {
                        MessageBox.Show("الرجاء ادخال المعلومات");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }
    }
}
