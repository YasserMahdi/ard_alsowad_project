using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.invoices
{
    class Checking
    {
        public DataTable verifyQte(string MatName, string qte)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@mat_name", SqlDbType.NVarChar,50);
            param[0].Value = MatName;

            param[1] = new SqlParameter("@qte_enterd", SqlDbType.Decimal);
            param[1].Value = Convert.ToDecimal(qte);

            dt = DAL.selectData("verifyQte", param);
            DAL.close();
            return dt;
        }
    }
}
