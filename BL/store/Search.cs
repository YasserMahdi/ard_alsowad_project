using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.store
{
    class Search
    {
        public DataTable SearchInCat(string Value ,string store)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@val", SqlDbType.NVarChar, 50);
            param[0].Value = Value;

            param[1] = new SqlParameter("@str", SqlDbType.NVarChar, 50);
            param[1].Value = store;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("search_in_cat", param);
            accessobject.close();


            return Dt;

        }

        public DataTable SearchInMat(string Value, string store,string cat)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@val", SqlDbType.NVarChar, 50);
            param[0].Value = Value;

            param[1] = new SqlParameter("@str", SqlDbType.NVarChar, 50);
            param[1].Value = store;

            param[2] = new SqlParameter("@cat", SqlDbType.NVarChar, 50);
            param[2].Value = cat;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("search_in_mat", param);
            accessobject.close();


            return Dt;

        }
    }
}
