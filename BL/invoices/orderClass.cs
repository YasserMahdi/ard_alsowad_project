using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL
{
    class orderClass
    {

        public DataTable getIDforInvoice()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getIDforInvoice", null);
            accessobject.close();

            return Dt;

        }

        public DataTable getLastInvoiceForPrint()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getLastInvoiceForPrint", null);
            accessobject.close();

            return Dt;

        }

        public DataTable printinvoice( int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@invID", SqlDbType.Int);
            param[0].Value = id;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("printinvoice", param);
            accessobject.close();

            foreach(DataRow row in Dt.Rows)
            {
                row["سعر المفرد"]= String.Format("{0:n0}", Convert.ToDouble(row["سعر المفرد"]));
                row["السعر الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["السعر الكلي"]));
                row["المبلغ الاجمالي"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ الاجمالي"]));
            }

            return Dt;

        }

        public void add_order(int customerID, string inv_no, string note, double total_ammount, double resived,string isCashed, DateTime DateT,string Type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@inv_no", SqlDbType.NVarChar,50);
            param[0].Value = inv_no;

            param[1] = new SqlParameter("@inv_date", SqlDbType.DateTime);
            param[1].Value = DateT;

            param[2] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            param[2].Value = note;

            param[3] = new SqlParameter("@customer_iD", SqlDbType.Int);
            param[3].Value = customerID;

            param[4] = new SqlParameter("@total_amount", SqlDbType.Money);
            param[4].Value = total_ammount;

            param[5] = new SqlParameter("@recived", SqlDbType.Money);
            param[5].Value =resived;

            param[6] = new SqlParameter("@isCashed", SqlDbType.NVarChar,50);
            param[6].Value = isCashed;

            param[7] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            param[7].Value = Type;



            DAL.Executecmd("add_order", param);
            DAL.close();
        }

        public void add_order_detail(int mat_no,string matName, string order_no, int qte, double price, double amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = mat_no;

            param[1] = new SqlParameter("@order_no", SqlDbType.NVarChar,50);
            param[1].Value = order_no;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.Money);
            param[3].Value = price;

            param[4] = new SqlParameter("@amount", SqlDbType.Money);
            param[4].Value = amount;

            param[5] = new SqlParameter("@mat_name", SqlDbType.NVarChar,50);
            param[5].Value = matName;


            DAL.Executecmd("add_order_detail", param);
            DAL.close();
        }

        public DataTable verifyQte(int mat_no, int qte)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = mat_no;

            param[1] = new SqlParameter("@qte_enterd", SqlDbType.Int);
            param[1].Value = qte;

            dt = DAL.selectData("verifyQte", param);
            DAL.close();
            return dt;
        }



        public DataTable notPaidInCash(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("notPaidInCash", param);
            accessobject.close();

            return Dt;

        }

        public DataTable listinvo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("listinvo", null);
            accessobject.close();


            return Dt;
        }






        public DataTable searchinInvo(string reference)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ref", SqlDbType.NVarChar, 64);
            param[0].Value = reference;

            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("searchinInvo", param);
            accessobject.close();

            return Dt;

        }

        public DataTable showInvoice_details(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("showInvoice", param);
            accessobject.close();

            return Dt;

        }

        public DataTable showInvoice_head(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("showInvoice_head", param);
            accessobject.close();

            return Dt;

        }


        public void add_order_detail_update( string matName, string order_no, int qte, double price, double amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@mat_no", SqlDbType.Int);
            param[0].Value = 0;

            param[1] = new SqlParameter("@order_no", SqlDbType.NVarChar, 50);
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
