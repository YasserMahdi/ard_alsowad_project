using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.services
{
    class insertion
    {

        public void add_serv(int customerID, string inv_no, string note, double total_ammount, double resived, string isCashed, DateTime DateT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@serve_no", SqlDbType.Int);
            param[0].Value = Convert.ToInt32(inv_no);

            param[1] = new SqlParameter("@serve_date", SqlDbType.DateTime);
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



            DAL.Executecmd("add_serv", param);
            DAL.close();
        }

        public void add_serve_detail(string ServeName, int order_no, int qte, double price, double amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
 

            param[0] = new SqlParameter("@serve_no", SqlDbType.Int);
            param[0].Value = order_no;

            param[1] = new SqlParameter("@qte", SqlDbType.Int);
            param[1].Value = qte;

            param[2] = new SqlParameter("@price", SqlDbType.Money);
            param[2].Value = price;

            param[3] = new SqlParameter("@amount", SqlDbType.Money);
            param[3].Value = amount;

            param[4] = new SqlParameter("@serve_name", SqlDbType.NVarChar, 50);
            param[4].Value = ServeName;


            DAL.Executecmd("add_serve_detail", param);
            DAL.close();
        }
    }
}
