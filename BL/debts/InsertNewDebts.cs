using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.debts
{
    class InsertNewDebts
    {

        public void Add_New_debt(string cusID, string moneyOf,string note,DateTime DateT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
 
            param[0] = new SqlParameter("@cus_id", SqlDbType.NVarChar,50);
            param[0].Value = cusID;

            param[1] = new SqlParameter("@moneyOf", SqlDbType.Money);
            param[1].Value = Convert.ToDouble(moneyOf);

            param[2] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[2].Value = DateT;

            param[3] = new SqlParameter("@note", SqlDbType.NVarChar,50);
            param[3].Value = note;




            DAL.Executecmd("add_new_debt", param);
            DAL.close();
        }
    }
}
