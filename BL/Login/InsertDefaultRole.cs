using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.Login
{
    class InsertDefaultRole
    {
        public void InsDefRole(string RoleID, string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@role_name", SqlDbType.NVarChar, 50);
            param[0].Value = UserType;

            param[1] = new SqlParameter("@role_id", SqlDbType.NVarChar, 50);
            param[1].Value = RoleID;

            DAL.Executecmd("insert_dafault_role", param);
            DAL.close();
        }
    }
}
