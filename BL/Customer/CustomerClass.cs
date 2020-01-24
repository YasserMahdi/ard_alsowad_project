using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace IFarmer.BL
{
    class CustomerClass
    {
        public void InsertCus(string name, string phone,string note)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];


            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            param[1].Value = phone;

            param[2] = new SqlParameter("@note", SqlDbType.NVarChar, 50);
            param[2].Value = note;



            DAL.Executecmd("insertCustomer", param);
            DAL.close();
        }

        public DataTable getCustomerInfo()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getCustomerInfo", null);
            accessobject.close();

            return Dt;

        }

        public DataTable fetchNote(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("fetchNote", param);
            accessobject.close();

            return Dt;


        }

        public void updateCus(string name, string phone ,int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];


            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            param[1].Value = phone;

            param[2] = new SqlParameter("@id", SqlDbType.Int);
            param[2].Value = id;



            DAL.Executecmd("updateUserInfo", param);
            DAL.close();
        }

        public DataTable searchINcostumer(string name)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ref", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("search_in_customer", param);
            accessobject.close();

            //foreach (DataRow row in Dt.Rows)
            //{
            //    //  try
            //    //  {
            //    //    row["سعر الشراء"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر الشراء"]));
            //    //
            //    //       row["سعر البيع"] = String.Format("{0:n0}", Convert.ToDouble(row["سعر البيع"]));
            //    //  }
            //    //   catch (Exception ex)
            //    //  {

            //    //  }
            //}


            return Dt;

        }
    }
}
