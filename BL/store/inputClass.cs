using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL
{
    class inputClass
    {
        public void insertMtr(string nameMtr, Double buyPrice, Double salePrice, double quantity, string type ,string storeid)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@mat_name", SqlDbType.VarChar, 50);
            param[0].Value = nameMtr;

            param[1] = new SqlParameter("@mat_buy_price", SqlDbType.Money);
            param[1].Value = buyPrice;

            param[2] = new SqlParameter("@mat_sale_price", SqlDbType.Money);
            param[2].Value = salePrice;

            param[3] = new SqlParameter("@Quantity", SqlDbType.Decimal);
            param[3].Value = quantity;

            param[4] = new SqlParameter("@type_name", SqlDbType.NVarChar, 50);
            param[4].Value = type;

            param[5] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[5].Value = DateTime.Now;

            param[6] = new SqlParameter("@store_id", SqlDbType.NVarChar,50);
            param[6].Value = storeid;

            DAL.Executecmd("insertMatirials", param);
            DAL.close();
        }


        public void insertCat(string catName, string Storeid)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@cat_name", SqlDbType.VarChar, 50);
            param[0].Value = catName;


            param[1] = new SqlParameter("@store_id", SqlDbType.VarChar, 50);
            param[1].Value = Storeid;

            DAL.Executecmd("insertCats", param);
            DAL.close();
        }


        public DataTable getMatirialInfo()
        {

            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getMatirialInfo", null);
            accessobject.close();

            //foreach (DataRow row in Dt.Rows)
            //{
            //    row["purchasing_price"] = String.Format("{0:n0}", Convert.ToDouble(row["purchasing_price"]));
            //    row["selling_price"] = String.Format("{0:n0}", Convert.ToDouble(row["selling_price"]));
                
            //}


            return Dt;

        }

        public DataTable BringSeedsByType(string type_name ,string storid )
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            param[0].Value = type_name;

            param[1] = new SqlParameter("@store_id", SqlDbType.NVarChar, 50);
            param[1].Value = storid;
 
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("BringSeedsByType", param);
            accessobject.close();

            foreach (DataRow row in Dt.Rows)
            {
                row["purchasing_price"] = String.Format("{0:n0}", Convert.ToDouble(row["purchasing_price"]));
                row["selling_price"] = String.Format("{0:n0}", Convert.ToDouble(row["selling_price"]));

            }


            return Dt;


            

        }

  

        public DataTable searchMat(string  name)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ref", SqlDbType.NVarChar, 50);
            param[0].Value =  name;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("searchMat", param);
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
