﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IFarmer.DAL
{
    class DataAccessLayer
    {
        SqlConnection connectobject;
        public DataAccessLayer()
        {
            connectobject = new SqlConnection(@"server=.\SQLEXPRESS;database=blackness;integrated security=true");
            //connectobject = new SqlConnection(@"Data Source = 192.168.56.254\SQLEXPRESS,1433; Initial Catalog = blackness;Integrated Security = False; Connect Timeout = 3; user ID = admin; password = 3331");

        }

        public void open()
        {
            if (connectobject.State != ConnectionState.Open)
            {
                connectobject.Open();
            }
        }
        public void close()
        {
            if (connectobject.State == ConnectionState.Open)
            {
                connectobject.Close();
            }
        }
        private static DataAccessLayer _instance;
        public static DataAccessLayer GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataAccessLayer();
            }
            return _instance;
        }

        // methode to read data from database
        public DataTable selectData(string stored_procedure, SqlParameter[] parametersars)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = connectobject;
            if (parametersars != null)
            {
                for (int i = 0; i < parametersars.Length; ++i)
                {

                    sqlcmd.Parameters.Add(parametersars[i]);
                }

            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        //Methode to Insert , Update and Delet Data from Database
        public void Executecmd(string stored_procedure, SqlParameter[] parametersars)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = connectobject;
            if (parametersars != null)
            {
                for (int i = 0; i < parametersars.Length; ++i)
                {

                    sqlcmd.Parameters.Add(parametersars[i]);
                }
            }
            sqlcmd.ExecuteNonQuery();
        }

    }
}
