using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.store
{
    class Updater
    {
        public void UpdaterMtr(string MatId,string nameMtr, Double buyPrice, Double salePrice, int quantity)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@mat_name", SqlDbType.VarChar, 50);
            param[0].Value = nameMtr;

            param[1] = new SqlParameter("@mat_buy_price", SqlDbType.Money);
            param[1].Value = buyPrice;

            param[2] = new SqlParameter("@mat_sale_price", SqlDbType.Money);
            param[2].Value = salePrice;

            param[3] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[3].Value = quantity;

            param[4] = new SqlParameter("@mat_id", SqlDbType.VarChar, 50);
            param[4].Value = MatId;


            DAL.Executecmd("updaterMtr", param);
            DAL.close();
        }

    }
}
