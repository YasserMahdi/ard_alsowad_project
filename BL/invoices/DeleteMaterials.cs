using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.invoices
{
    class DeleteMaterials
    {
        public void DeleteOrderMat(string name,string Odrer_id,string qte)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@mat_name", SqlDbType.NVarChar,50);
            param[0].Value = name;


            param[1] = new SqlParameter("@order_id", SqlDbType.NVarChar,50);
            param[1].Value = Odrer_id;


            param[2] = new SqlParameter("@qte", SqlDbType.NVarChar,50);
            param[2].Value = qte;


           
            accessobject.Executecmd("delete_mat_from_order", param);
            accessobject.close();

            

        }
    }
}
