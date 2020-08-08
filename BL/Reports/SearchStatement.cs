using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.Reports
{
    class SearchStatement
    {
        public DataTable GetStatementPeriod(string customerIdentity, DateTime start, DateTime end)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            DataTable IdsOfOrder = new DataTable();
            IdsOfOrder = getOrderOfCustomerP(customerIdentity, start, end);
            DataTable result = new DataTable();
            if (IdsOfOrder.Rows.Count > 0)
            {
                for (int i = 0; i <= IdsOfOrder.Rows.Count - 1; i++) 
                {
                    SqlParameter[] param = new SqlParameter[4];
                    String invid = IdsOfOrder.Rows[i][0].ToString();
                    param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                    param[0].Value = invid;

                    param[1] = new SqlParameter("@start", SqlDbType.DateTime);
                    param[1].Value = start;

                    param[2] = new SqlParameter("@end", SqlDbType.DateTime);
                    param[2].Value = end;

                    param[3] = new SqlParameter("@customer_id", SqlDbType.NVarChar,50);
                    param[3].Value = customerIdentity;





                    DataTable Dt = new DataTable();
                    Dt = accessobject.selectData("get_statement_with_date", param);
                    accessobject.close();

                    result.Merge(Dt);
                }
            }

            foreach (DataRow row in result.Rows)
            {
                try
                {
                    row["العسر الاساسي"] = String.Format("{0:n0}", Convert.ToDouble(row["العسر الاساسي"]));
                    row["المبلغ"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ"]));
                    //row["من"] = start;
                    //row["الى"] = end;
                    row["الدين الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["الدين الكلي"]));

                }
                catch  
                {
                    
                }
            }
            return result;

        }


        public DataTable getOrderOfCustomerP(string CustomerNo, DateTime start, DateTime end)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = CustomerNo;

            param[1] = new SqlParameter("@start", SqlDbType.DateTime);
            param[1].Value = start;

            param[2] = new SqlParameter("@end", SqlDbType.DateTime);
            param[2].Value = end;



            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getOrferOfCustomer_p", param);
            accessobject.close();

            return Dt;

        }
    }
}
