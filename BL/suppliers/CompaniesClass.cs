using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL
{
    class CompaniesClass
    {
    

        public void insCompanies(string compName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@comp_name", SqlDbType.VarChar, 50);
            param[0].Value = compName;

            DAL.Executecmd("insCompanies", param);
            DAL.close();
        }

        public DataTable fetchCompanyNames()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("fetchCompanyNames", null);
            accessobject.close();


            return Dt;

        }

        public DataTable getIdForCompOrder()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getIdForCompOrder", null);
            accessobject.close();


            return Dt;

        }


        public void add_comp_order(string compName,double amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@comp_name", SqlDbType.NVarChar,50);
            param[0].Value = compName;

            param[1] = new SqlParameter("@amount", SqlDbType.Money);
            param[1].Value = amount;


            DAL.Executecmd("add_comp_order", param);
            DAL.close();
        }

        public void add_comp_order_detail( int order_no,string productName ,double qte, double price, double amount)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@product_name", SqlDbType.NVarChar,50);
            param[0].Value = productName;

            param[1] = new SqlParameter("@order_no", SqlDbType.Int);
            param[1].Value = order_no;

            param[2] = new SqlParameter("@qte", SqlDbType.Decimal);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.Money);
            param[3].Value = price;

            param[4] = new SqlParameter("@amount", SqlDbType.Money);
            param[4].Value = Convert.ToDouble(amount);





            DAL.Executecmd("add_comp_order_detail", param);
            DAL.close();
        }

        public DataTable searchInComp(string txtRef)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ref", SqlDbType.NVarChar, 50);
            param[0].Value = txtRef;

            DataTable dt = new DataTable();
            dt = DAL.selectData("searchInComp", param);
            DAL.close();

            return dt;

        }

        public void updateCompaniesInfo(string compName,int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@comp_name", SqlDbType.VarChar, 50);
            param[0].Value = compName;

            param[1] = new SqlParameter("@id", SqlDbType.Int);
            param[1].Value = id;

            DAL.Executecmd("updateCompaniesInfo", param);
            DAL.close();
        }

    }
}
