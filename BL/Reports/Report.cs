using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IFarmer.BL
{
    class Report
    {


        public void set_seasonal_revenue(int season_id, double moneyOf)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@s_id", SqlDbType.Int);
            param[0].Value = season_id;

            param[1] = new SqlParameter("@mon", SqlDbType.Money);
            param[1].Value = moneyOf;




            DAL.Executecmd("set_seasonal_revenue", param);
            DAL.close();
        }

       

        public void set_Seasonal_disbursements(int season_id, double moneyOf)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@s_id", SqlDbType.Int);
            param[0].Value = season_id;

            param[1] = new SqlParameter("@mon", SqlDbType.Money);
            param[1].Value = moneyOf;



            DAL.Executecmd("set_Seasonal_disbursements", param);
            DAL.close();
        }

        public DataTable get_purchasing_price(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("id", SqlDbType.Int);
            param[0].Value = id;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("get_purchasing_price", param);
            accessobject.close();

            return Dt;
        }

        public void set_seasonal_disbursements_invo_sal_dis(double moneyOf)
        {

            BL.Seasons seasons = new Seasons();

            DataTable dt = new DataTable();
            dt = seasons.fetchCurrentSeasons();
            int season_num = 0;
            double result = 0.0;
            try
            {
                season_num = dt.Rows.Count;
                result = (moneyOf / season_num);

            }
            catch
            {

            }
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.set_Seasonal_disbursements(Convert.ToInt32(dt.Rows[i][0]), result);
            }


    

        }


        public void set_Seasonal_revenue_from_invoice(double moneyOf)
        {

            BL.Seasons seasons = new Seasons();

            DataTable dt = new DataTable();
            dt = seasons.fetchCurrentSeasons();
            int season_num;
            double result = 0.0;
            try
            {
                season_num = dt.Rows.Count;
               result = (moneyOf / season_num);
            }
            catch(Exception ex)
            {
                
            }
           
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.set_seasonal_revenue(Convert.ToInt32(dt.Rows[i][0]), result);
                
            }

    

        }


        public DataTable profitcount()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("profitcount", null);
            accessobject.close();
            foreach (DataRow row in Dt.Rows)
            {
               
                row["الايرادات"] = String.Format("{0:n0}", Convert.ToDouble(row["الايرادات"]));
                row["الصرفيات"] = String.Format("{0:n0}", Convert.ToDouble(row["الصرفيات"]));

            }
            return Dt;

        }

    }
}
