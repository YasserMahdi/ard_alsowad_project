using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.services
{
    class searching
    {
        public DataTable searchinServe(string reference)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ref", SqlDbType.NVarChar, 64);
            param[0].Value = reference;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("searchin_serve", param);
            accessobject.close();

            return Dt;

        }
    }
}
