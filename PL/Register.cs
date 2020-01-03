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
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        string UserType;
        string FullName; string UserName; string PassCode; string state; string UserID;
        string cTime;

        BL.Register.AddUser AddUser = new BL.Register.AddUser();
        BL.Register.Update Update = new BL.Register.Update();
        public Register()
        {
            InitializeComponent();
            state = "add";
        }

        public Register(string UserID, string FullName, string UserName, string PassCode)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.TxtFullName.Text = FullName; this.TxtUserName.Text = UserName; this.TxtPassCode.Text = PassCode;
            state = "update";
            this.BtnRegister.ButtonText = "تحديث";
        }

        public Register(string UserType)
        {
            InitializeComponent();
            this.UserType = UserType;
            try
            {
                this.ComboUserType.Enabled = false;
                this.BtnRegister.ButtonText = "اضافة مدير للنظام";
                cTime = "1";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
            BL.Register.LoadRoleTable role = new BL.Register.LoadRoleTable();
            int check = role.CheckRole();
            if(check == 0)
            {
                // then insert dafault role
                BL.Login.InsertDefaultRole DefRole = new BL.Login.InsertDefaultRole();
                DefRole.InsDefRole("1", "admin");
                DefRole.InsDefRole("2", "seller");
            }
            BL.Register.LoadRoleTable LoadRole = new BL.Register.LoadRoleTable();
            this.ComboUserType.DisplayMember = "role_name";
            this.ComboUserType.ValueMember = "role_id";
            this.ComboUserType.DataSource = LoadRole.SelectRole();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (state == "add")
                {
                    AddUser.InsertUser(this.TxtFullName.Text, this.TxtUserName.Text, this.TxtPassCode.Text, this.ComboUserType.SelectedValue.ToString());
                    MessageBox.Show("تمت الاضافة بنجاح ", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if(state == "update")
                {
                    Update.UpdateUser(this.TxtFullName.Text, this.TxtUserName.Text, this.TxtPassCode.Text, this.UserID);
                    MessageBox.Show("تمت التحديث بنجاح ", " التحديث", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if(cTime == "1")
                {
                    AddUser.InsertUser(this.TxtFullName.Text, this.TxtUserName.Text, this.TxtPassCode.Text,"1");
                    MessageBox.Show("تمت الاضافة بنجاح ", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
