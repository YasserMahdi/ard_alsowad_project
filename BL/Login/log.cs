using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.Login
{
    class log
    {
        public string auth(string UserName, string passcode)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("user_name", SqlDbType.NVarChar, 50);
            param[0].Value = UserName;

            param[1] = new SqlParameter("pass_code", SqlDbType.NVarChar, 50);
            param[1].Value = passcode;
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("auth_user", param);

            try
            {
                if (Dt.Rows[0][0].ToString() == UserName && Dt.Rows[0][1].ToString() == passcode)
                {
                    return Dt.Rows[0][2].ToString();
                }
                else
                {
                    return "woring information";
                }
            }
            catch
            {
                return "woring information";
            }
        }
    }
}
