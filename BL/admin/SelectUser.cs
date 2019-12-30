using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.admin
{
    class SelectUser
    {
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

        public DataTable SelUsers()
        {
            DAL.open();
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("select_users", null);
            DAL.close();

            return Dt;
        }
    }
}
