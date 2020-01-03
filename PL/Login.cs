using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IFarmer.PL
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public static Login frm;

        static void frm_frmclose(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static Login GetLoginForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Login();
                    frm.FormClosed += new FormClosedEventHandler(frm_frmclose);
                    

                }
                return frm;
            }
        }
        public Login()
        {
            InitializeComponent();
            if(frm == null)
            {
                frm = this;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //this.TxtPassCode.isPassword = true;
            
            try
            {
                //checking if users table equal to null 
                BL.Login.checking checking = new BL.Login.checking();
                int check = checking.IfUsersTableEqToNull();
                
                if (check == 0)
                {
                    
                    
                    // after that Create first Usert as admin
                    PL.Register frm = new Register("admin");
                    frm.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                BL.Login.log log = new BL.Login.log();
                string RoleType;
                RoleType = log.auth(this.TxtUserName.Text, this.TxtPassCode.Text);
                if (RoleType == "woring information")
                {
                    MessageBox.Show(RoleType);
                }
                else
                {
                    PL.MainForm frm = new MainForm(RoleType);
                    this.Hide();
                    frm.ShowDialog();
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
