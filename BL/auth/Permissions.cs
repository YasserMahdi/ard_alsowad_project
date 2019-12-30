using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.auth
{
    class Permissions
    {
        public void InsertPer(string FormName, string ItemName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@form_name", SqlDbType.NVarChar, 50);
            param[0].Value = FormName;

            param[1] = new SqlParameter("@item_name", SqlDbType.NVarChar, 50);
            param[1].Value = FormName;


            DAL.Executecmd("insert_permissions", param);
            DAL.close();
        }
    }
}
