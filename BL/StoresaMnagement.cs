using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace IFarmer.BL
{
    class StoresaMnagement
    {
        public DataTable selectStore()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("selectStores", null);
            accessobject.close();

            return Dt;

        }

        public void InsertStore(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;


            DAL.Executecmd("insertStores", param);
            DAL.close();
        }

        public void DeleteStore(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;


            DAL.Executecmd("deleteStores", param);
            DAL.close();
        }

        public void UpdateStoreName(string id, string NewName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@new_name", SqlDbType.NVarChar, 50);
            param[1].Value = NewName;

            DAL.Executecmd("update_store_name", param);
            DAL.close();
        }
    }
}
