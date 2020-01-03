using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.Login
{
    class checking
    {
        BL.admin.SelectUser selusr = new admin.SelectUser();
        public int IfUsersTableEqToNull()
        {
            DataTable Dt = selusr.SelUsers();
            if (Dt.Rows.Count<1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
