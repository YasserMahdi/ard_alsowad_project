using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.CashBox
{
    class BoxInsertion
    {
        public void SetCash(int amount, string type,DateTime dat,string id,string mnthid)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@amount", SqlDbType.Int);
            param[0].Value = amount;

            param[1] = new SqlParameter("@typ", SqlDbType.NVarChar,50);
            param[1].Value = type;

            param[2] = new SqlParameter("@dat", SqlDbType.DateTime);
            param[2].Value = dat;

            param[3] = new SqlParameter("@id", SqlDbType.BigInt);
            param[3].Value = Convert.ToInt64(id);


            param[4] = new SqlParameter("@mnthid", SqlDbType.Int);
            param[4].Value = Convert.ToInt32(mnthid);

          



            accessobject.open();


            accessobject.Executecmd("set_cash", param);
            accessobject.close();


        }

        public void SetCash(int amount, string type, DateTime dat, string mnthid)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@amount", SqlDbType.Int);
            param[0].Value = amount;

            param[1] = new SqlParameter("@typ", SqlDbType.NVarChar, 50);
            param[1].Value = type;

            param[2] = new SqlParameter("@dat", SqlDbType.DateTime);
            param[2].Value = dat;

            
            param[3] = new SqlParameter("@mnthid", SqlDbType.Int);
            param[3].Value = Convert.ToInt32(mnthid);





            accessobject.open();


            accessobject.Executecmd("set_cash_form_rep", param);
            accessobject.close();


        }
    }
}
