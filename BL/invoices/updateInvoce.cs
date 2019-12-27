using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL
{
    class updateInvoce
    {
        public void update_inv_head(int customerID, string inv_no, string note, double total_ammount, double resived, string isCashed, DateTime DateT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@inv_no", SqlDbType.Int);
            param[0].Value = Convert.ToInt32(inv_no);

            param[1] = new SqlParameter("@inv_date", SqlDbType.DateTime);
            param[1].Value = DateT;

            param[2] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            param[2].Value = note;

            param[3] = new SqlParameter("@customer_iD", SqlDbType.Int);
            param[3].Value = customerID;

            param[4] = new SqlParameter("@total_amount", SqlDbType.Money);
            param[4].Value = total_ammount;

            param[5] = new SqlParameter("@recived", SqlDbType.Money);
            param[5].Value = resived;

            param[6] = new SqlParameter("@isCashed", SqlDbType.NVarChar, 50);
            param[6].Value = isCashed;



            DAL.Executecmd("add_order", param);
            DAL.close();
        }

        public void update_inv_tail(int mat_no, string matName, int order_no, int qte, double price, double amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = mat_no;

            param[1] = new SqlParameter("@order_no", SqlDbType.Int);
            param[1].Value = order_no;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.Money);
            param[3].Value = price;

            param[4] = new SqlParameter("@amount", SqlDbType.Money);
            param[4].Value = amount;

            param[5] = new SqlParameter("@mat_name", SqlDbType.NVarChar, 50);
            param[5].Value = matName;


            DAL.Executecmd("add_order_detail", param);
            DAL.close();
        }
    }
}
