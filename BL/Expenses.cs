using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace IFarmer.BL
{
    class Expenses
    {
        public void insSalary(string name , double salary , DateTime dateT) // insertion employee salary for compute Expenses
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@salary", SqlDbType.Money);
            param[1].Value = salary;

            param[2] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[2].Value = dateT; //DateTime.Now;

            DAL.open();
            DAL.Executecmd("insSalary", param);
            DAL.close();


        }
        public void insExpenses(string name, double salary, DateTime dateT) // insertion  Expenses of work
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@amount", SqlDbType.Money);
            param[1].Value = salary;

            param[2] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[2].Value = dateT; //DateTime.Now;

            DAL.open();
            DAL.Executecmd("insExpenses", param);
            DAL.close();


        }

        public DataTable selExpenses() // selection Expenses
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("selExpenses", null);
            accessobject.close();


            return Dt;
        }

        public DataTable selSalary() // selection Salary
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("selSalary", null);
            accessobject.close();


            return Dt;
        }
    }
}
