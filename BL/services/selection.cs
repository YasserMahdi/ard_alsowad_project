using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.services
{
    class selection
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public DataTable GetID()
        {
           
            
            DataTable Dt = new DataTable();
            Dt = dal.selectData("get_id_for_service", null);
            dal.close();

            return Dt;
        }

        public DataTable GetServList()
        {
           
            DataTable Dt = new DataTable();
            Dt = dal.selectData("get_service_list", null);
            dal.close();

            return Dt;
        }

        public DataTable GetServHead(string id)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            Dt = dal.selectData("GetServHead", param);
            dal.close();

            return Dt;
        }

        public DataTable GetServTail(string id)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;
            Dt = dal.selectData("GetServTail", param);
            dal.close();

            return Dt;
        }
    }
   
}
