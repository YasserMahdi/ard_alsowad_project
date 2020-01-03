using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.Reports
{
    class FullStatement
    {
        public DataTable GetStatement(string CustomerId)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            DataTable IdOfOoder = new DataTable();
            IdOfOoder = getOrferOfCustomer(CustomerId);
            DataTable result = new DataTable();
            if (IdOfOoder.Rows.Count > 0)
            {
                for (int i = 0; i <= IdOfOoder.Rows.Count - 1; i++)
                {
                    SqlParameter[] param = new SqlParameter[2];
                    String invid = IdOfOoder.Rows[i][0].ToString();
                    param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                    param[0].Value = invid;

                    param[1] = new SqlParameter("@customer_id", SqlDbType.NVarChar, 50);
                    param[1].Value = CustomerId;

                    DataTable Dt = new DataTable();
                    Dt = accessobject.selectData("get_statement_for_print", param);
                    accessobject.close();

                    result.Merge(Dt);
                }
            }
            return result;

        }

        public DataTable getOrferOfCustomer(string id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getOrferOfCustomer", param);
            accessobject.close();

            return Dt;

        }

        public DataTable GetStatementPeriod(string id, DateTime start, DateTime end)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            DataTable IdOfOoder = new DataTable();
            IdOfOoder = getOrderOfCustomerP(id, start, end);
            DataTable result = new DataTable();
            if (IdOfOoder.Rows.Count > 0)
            {
                for (int i = 0; i <= IdOfOoder.Rows.Count - 1; i++)
                {
                    SqlParameter[] param = new SqlParameter[1];
                    String invid = IdOfOoder.Rows[i][0].ToString();
                    param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
                    param[0].Value = invid;



                    DataTable Dt = new DataTable();
                    Dt = accessobject.selectData("get_statement", param);
                    accessobject.close();

                    result.Merge(Dt);
                }
            }
            return result;

        }


        public DataTable getOrderOfCustomerP(string id, DateTime start, DateTime end)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            param[0].Value = id;

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
