﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.Register
{
    class AddUser
    {
        public void InsertUser(string FullName,string UserName,string passcode,string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@full_name", SqlDbType.NVarChar, 50);
            param[0].Value = FullName;

            param[1] = new SqlParameter("@user_name", SqlDbType.NVarChar, 50);
            param[1].Value = UserName;

            param[2] = new SqlParameter("@pass_code", SqlDbType.NVarChar, 50);
            param[2].Value = passcode;

            param[3] = new SqlParameter("@user_type", SqlDbType.NVarChar, 50);
            param[3].Value = UserType;



            DAL.Executecmd("Insert_user", param);
            DAL.close();
        }
    }
}
