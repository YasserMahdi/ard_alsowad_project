using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL
{
    class Seasons
    {

        public void insSeasons(string SeasonName , DateTime Start_Date, DateTime Expiry_date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@season_name", SqlDbType.VarChar, 50);
            param[0].Value = SeasonName;

            param[1] = new SqlParameter("@Start_Date", SqlDbType.DateTime);
            param[1].Value = Start_Date;

            param[2] = new SqlParameter("@Expiry_date", SqlDbType.DateTime);
            param[2].Value = Expiry_date;

            DAL.Executecmd("insSeasons", param);
            DAL.close();
        }

        public void updateSeasons(string SeasonName, DateTime Start_Date, DateTime Expiry_date,int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@season_name", SqlDbType.VarChar, 50);
            param[0].Value = SeasonName;

            param[1] = new SqlParameter("@Start_Date", SqlDbType.DateTime);
            param[1].Value = Start_Date;

            param[2] = new SqlParameter("@Expiry_date", SqlDbType.DateTime);
            param[2].Value = Expiry_date;

            param[3] = new SqlParameter("@id", SqlDbType.Int);
            param[3].Value = id;

            DAL.Executecmd("updateSeasons", param);
            DAL.close();
        }

        public DataTable fetchSeasonsNames()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("fetchSeasonsNames", null);
            accessobject.close();


            return Dt;

        }

        public DataTable fetchFinisheSeasons()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cheack", SqlDbType.DateTime);
            param[0].Value = DateTime.Now;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("fetchFinisheSeasons", param);
            accessobject.close();


            return Dt;



        }


        public DataTable fetchCurrentSeasons()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            accessobject.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cheack", SqlDbType.DateTime);
            param[0].Value = DateTime.Now;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("fetchCurrentSeasons", param);
            accessobject.close();


            return Dt;



        }


        public DataTable searchInSeasons(string txtRef)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ref", SqlDbType.NVarChar, 50);
            param[0].Value = txtRef;

            DataTable dt = new DataTable();
            dt = DAL.selectData("searchInSeasons", param);
            DAL.close();

            return dt;

        }


        public DataTable searchInCurrentSeasons(string txtRef)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ref", SqlDbType.NVarChar, 50);
            param[0].Value = txtRef;

            param[1] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[1].Value = DateTime.Now;



            DataTable dt = new DataTable();
            dt = DAL.selectData("searchInCurrentSeasons", param);
            DAL.close();

            return dt;

        }

        public DataTable searchInFinisheSeasons(string txtRef)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ref", SqlDbType.NVarChar, 50);
            param[0].Value = txtRef;

            param[1] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[1].Value = DateTime.Now;



            DataTable dt = new DataTable();
            dt = DAL.selectData("searchInFinisheSeasons", param);
            DAL.close();

            return dt;

        }


    }
}
