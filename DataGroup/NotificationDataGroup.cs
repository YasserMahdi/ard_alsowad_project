using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.DataGroup
{
    class NotificationDataGroup
    {
        public DataTable sel_orders()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("two_month_ago",null);
            accessobject.close();

            //foreach (DataRow row in Dt.Rows)
            //{
            //    try
            //    {
            //        row["amount"] = String.Format("{0:n0}", Convert.ToDouble(row["amount"]));
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}

            return Dt;

        }
    }
}
