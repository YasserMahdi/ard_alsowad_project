using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.invoices
{
    class UpdateDebtsAffterDeleteOrderMat
    {
        //public void UpdateDebts(string CustomerId, string NewTotal, string NewReceived , string OldTotal,string OldRec)
        //{
        //    DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

        //    SqlParameter[] param = new SqlParameter[3];

        //    param[0] = new SqlParameter("@customer_id", SqlDbType.NVarChar, 50);
        //    param[0].Value = CustomerId;


        //    param[1] = new SqlParameter("@new_total", SqlDbType.NVarChar, 50);
        //    param[1].Value = NewTotal;


        //    param[2] = new SqlParameter("@new_received", SqlDbType.NVarChar, 50);
        //    param[2].Value = NewReceived;

        //    param[3] = new SqlParameter("@old_total", SqlDbType.NVarChar, 50);
        //    param[3].Value = OldTotal;


        //    param[4] = new SqlParameter("@old_received", SqlDbType.NVarChar, 50);
        //    param[4].Value =OldRec;


        //    accessobject.Executecmd("delete_debts_on_update_invoice", param);
        //    accessobject.close();



        //}

        public void UpdateDebts(string CustomerId, string OrderID,  string debt_value ,Double MoneyOf ,DateTime Dt)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@customer_id", SqlDbType.NVarChar, 50);
            param[0].Value = CustomerId;


            param[1] = new SqlParameter("@order_id", SqlDbType.NVarChar, 50);
            param[1].Value = OrderID;


            param[2] = new SqlParameter("@debt_value", SqlDbType.NVarChar, 50);
            param[2].Value = debt_value;

            param[3] = new SqlParameter("@moneyOf", SqlDbType.Money);
            param[3].Value = MoneyOf;

            param[4] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[4].Value = Dt;




            accessobject.open();
            accessobject.Executecmd("delete_debts_on_update_invoice", param);
            accessobject.close();



        }
    }
}
