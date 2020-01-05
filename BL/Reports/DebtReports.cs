using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL.Reports
{
    class DebtReports
    {

        public DataTable GetDebtInfoforPrint(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getDebtInfo_for_print", param);
            accessobject.close();


            foreach (DataRow row in Dt.Rows)
            {
                try
                {
                    row["المبلغ"] = String.Format("{0:n0}", Convert.ToDouble(row["المبلغ"]));
                    row["الدين الكلي"] = String.Format("{0:n0}", Convert.ToDouble(row["الدين الكلي"]));
                }
                catch (Exception ex)
                {

                }
            }


            return Dt;

        }

    }
}
