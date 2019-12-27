using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace IFarmer.BL
{
    class CatClass
    {
        public DataTable getSuggest(string CatName ,string Store_ID)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ref", SqlDbType.NVarChar,50);
            param[0].Value = CatName;

            param[1] = new SqlParameter("@store_id", SqlDbType.NVarChar, 50);
            param[1].Value = Store_ID;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getSuggest", param);
            accessobject.close();

            return Dt;
        }


        public void DeleteCat(string Name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];


            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;


            DAL.Executecmd("delete_cat", param);
            DAL.close();
        }

 

        public void UpdateCatName(string catName, int id,string OldName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@new_name", SqlDbType.VarChar, 50);
            param[0].Value = catName;

            param[1] = new SqlParameter("@id", SqlDbType.Int);
            param[1].Value = id;

            param[2] = new SqlParameter("@old_name", SqlDbType.NVarChar,50);
            param[2].Value = OldName;

            DAL.Executecmd("update_cat_name", param);
            DAL.close();
        }
    }
}
