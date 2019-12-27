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
    public partial class insSeason : Form
    {
        BL.Seasons son = new BL.Seasons();
        public string State;
        public int id;
        public insSeason()
        {
            InitializeComponent();
        }

        private void insSeason_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (State == "add")
                {

                    if (txtNameSeason.Text == string.Empty)
                    {
                        MessageBox.Show("الرجاء ادخال اسم الموسم");
                    }
                    else
                    {
                        son.insSeasons(txtNameSeason.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(
                         dateTimePicker2.Text));
                        MessageBox.Show("تمت الاضافة بنحاج", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();

                    }
                }
                else
                {
                 
                    son.updateSeasons(txtNameSeason.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(
                            dateTimePicker2.Text), id);
                    MessageBox.Show("تمت الاضافة بنحاج", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
