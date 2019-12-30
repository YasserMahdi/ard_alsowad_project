using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.Register
{
    class LoadRoleTable
    {
        public DataTable SelectRole()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

             

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("select_role", null);
            accessobject.close();

            return Dt;
        }
    }
}
