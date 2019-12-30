using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.admin
{
    class DeleteUser
    {
        public void DeleteUsr(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;


            DAL.Executecmd("delete_user", param);
            DAL.close();
        }
    }
}
