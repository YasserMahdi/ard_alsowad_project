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
        public void InsDefRole(string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@role_name", SqlDbType.NVarChar, 50);
            param[0].Value = UserType;
            DAL.Executecmd("insert_dafault_role", param);
            DAL.close();
        }
    }
}
