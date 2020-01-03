using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.invoices
{
    class UpdateOrder
    {
        public void DeleteOrder(string Odrer_id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@order_id", SqlDbType.NVarChar, 50);
            param[0].Value = Odrer_id;
            accessobject.Executecmd("delete_order", param);
            accessobject.close();



        }
    }
}
