using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace IFarmer.BL
{
    class updateDocument
    {
        public void update_doc_head(int customerID, string id, string note, double total_ammount, double paid, Double rest, int season_id, DateTime dateT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = Convert.ToInt32(id);

            param[1] = new SqlParameter("@doc_date", SqlDbType.DateTime);
            param[1].Value = dateT;

            param[2] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            param[2].Value = note;

            param[3] = new SqlParameter("@customer_iD", SqlDbType.Int);
            param[3].Value = customerID;

            param[4] = new SqlParameter("@total_amount", SqlDbType.Money);
            param[4].Value = total_ammount;

            param[5] = new SqlParameter("@paid", SqlDbType.Money);
            param[5].Value = paid;

            param[6] = new SqlParameter("@rest", SqlDbType.Money);
            param[6].Value = rest;

            param[7] = new SqlParameter("@season_id", SqlDbType.Money);
            param[7].Value = season_id;


            DAL.Executecmd("add_doc", param);
            DAL.close();
        }

        public void update_doc_tail(int mat_no, string mat_name, int order_no, int qte, double price, double amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = mat_no;

            param[1] = new SqlParameter("@doc_no", SqlDbType.Int);
            param[1].Value = order_no;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.Money);
            param[3].Value = price;

            param[4] = new SqlParameter("@amount", SqlDbType.Money);
            param[4].Value = Convert.ToDouble(amount);

            param[5] = new SqlParameter("@mat_name", SqlDbType.NVarChar, 50);
            param[5].Value = mat_name;





            DAL.Executecmd("add_doc_detail", param);
            DAL.close();
        }
    }
}
