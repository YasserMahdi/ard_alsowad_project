using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace IFarmer.BL
{
    class debtClass
    {
        public void add_debt_detail(string order_no, int cusID, double moneyOf)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@order_no", SqlDbType.NVarChar,50);
            param[0].Value = order_no;

            param[1] = new SqlParameter("@cus_id", SqlDbType.Int);
            param[1].Value = cusID;

            param[2] = new SqlParameter("@moneyOf", SqlDbType.Money);
            param[2].Value = moneyOf;

            param[3] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[3].Value = DateTime.Now;





            DAL.Executecmd("add_debt_detail", param);
            DAL.close();
        }

        public DataTable getDebtInfo(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getDebtInfo", param);
            accessobject.close();

            return Dt;

        }


        public void setCompaniesDebts(int order_no, string comp_name, double moneyOf)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];


            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = order_no;

            param[1] = new SqlParameter("@comp_name", SqlDbType.NVarChar, 50);
            param[1].Value = comp_name;

            param[2] = new SqlParameter("@moneyOf", SqlDbType.Money);
            param[2].Value = moneyOf;

            param[3] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[3].Value = DateTime.Now;





            DAL.Executecmd("setCompaniesDebts", param);
            DAL.close();
        }


        public void setDirCompaniesDebts(string comp_name, double moneyOf)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@comp_name", SqlDbType.NVarChar, 50);
            param[0].Value = comp_name;

            param[1] = new SqlParameter("@moneyOf", SqlDbType.Money);
            param[1].Value = moneyOf;

            param[2] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[2].Value = DateTime.Now;


            DAL.Executecmd("setDirCompaniesDebts", param);
            DAL.close();
        }

        public void setDirCompaniesRep(string comp_name, double moneyOf)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@comp_name", SqlDbType.NVarChar, 50);
            param[0].Value = comp_name;

            param[1] = new SqlParameter("@moneyOf", SqlDbType.Money);
            param[1].Value = moneyOf;

            param[2] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[2].Value = DateTime.Now;


            DAL.Executecmd("setDirCompaniesRep", param);
            DAL.close();
        }





        public DataTable fetchCompaniesDebts(string compName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@comp_name", SqlDbType.NVarChar, 50);
            param[0].Value = compName;



            dt = DAL.selectData("fetchCompaniesDebts", param);
            DAL.close();
            return dt;
        }


        public DataTable compDebtHistory(string compName)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@compName", SqlDbType.NVarChar, 50);
            param[0].Value = compName;



            dt = DAL.selectData("compDebtHistory", param);
            DAL.close();
            return dt;
        }


        public DataTable final_status_of_debts()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();



            Dt = DAL.selectData("the_final_status_of_debts", null);
            DAL.close();
            foreach (DataRow row in Dt.Rows)
            {
                try
                {
                    row["monyOf"] = String.Format("{0:n0}", Convert.ToDouble(row["monyOf"]));
                }
                catch
                {

                }
            }
            return Dt;
        }




        public DataTable userTotalDebt(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("userTotalDebt", param);
            accessobject.close();

            return Dt;

        }

        public DataTable searchInDebt(string reference)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@reference", SqlDbType.NVarChar, 50);
            param[0].Value = reference;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("searchInDebt", param);
            accessobject.close();

            return Dt;

        }

        public DataTable getDebtInfo(string name)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("getDebtInfo", param);
            accessobject.close();
 

            return Dt;

        }

        public DataTable fetchOldDebt(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("fetchOldDebt", param);
            accessobject.close();

            return Dt;

        }

        public DataTable sel_nto_paid_doc(int cus_id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = cus_id;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("sel_nto_paid_doc", param);
            accessobject.close();

            return Dt;

        }

        public DataTable DebtRepaymentForDoc(int doc_id, double paid, double rest)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = doc_id;

            param[1] = new SqlParameter("@paid", SqlDbType.Money);
            param[1].Value = paid;

            param[2] = new SqlParameter("@rest", SqlDbType.Money);
            param[2].Value = rest;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("DebtRepaymentForDoc", param);
            accessobject.close();

            return Dt;

        }

        public DataTable set_RepaymentForDoc_in_the_tables(int inv_id, double recived)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = inv_id;

            param[1] = new SqlParameter("@mny", SqlDbType.Money);
            param[1].Value = recived;

            param[2] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[2].Value = DateTime.Now;



            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("set_RepaymentForInvoice_in_the_tables", param);
            accessobject.close();

            return Dt;

        }

        public void processOnDebtRepaymentForDoc(int cus_id, double mny)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            DataTable Dt_not_paid_doc = this.sel_nto_paid_doc(cus_id);



            foreach (DataRow row in Dt_not_paid_doc.Rows)
            {
                double total = Convert.ToDouble(row["total_amount"]);
                double paid = Convert.ToDouble(row["paid"]);
                if ((total - paid) <= mny)
                {
                    row["paid"] = row["total_amount"];
                    row["rest"] = Convert.ToDouble(0.0);
                    mny -= (total - paid);
                }
                else if ((total - paid) > mny && mny > 0)
                {
                    double temp = Convert.ToDouble(row["paid"]);
                    temp += mny;
                    row["paid"] = Convert.ToDouble(temp);
                    row["rest"] = total - temp;
                    mny = 0;
                }
            }


            foreach (DataRow row in Dt_not_paid_doc.Rows)
            {
                //if (Convert.ToDouble( row["rest"]) <= 0)
                //{
                this.DebtRepaymentForDoc(Convert.ToInt32(row["id"]), Convert.ToDouble(row["paid"]),
                    Convert.ToDouble(row["rest"]));
                //}
                //else if (Convert.ToDouble(row["rest"]) > 0 && Convert.ToDouble(row["paid"]) > 0) 
                //{
                //    this.DebtRepaymentForDoc(Convert.ToInt32(row["id"]), Convert.ToDouble(row["paid"]),
                //        Convert.ToDouble(row["rest"]));
                //}
            }


        }

        public DataTable sel_nto_paid_innvoice(int cus_id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = cus_id;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("sel_nto_paid_innvoice", param);
            accessobject.close();

            return Dt;

        }

        public DataTable DebtRepaymentForInvoice(int inv_id, double recived, string isCashed)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = inv_id;

            param[1] = new SqlParameter("@mny", SqlDbType.Money);
            param[1].Value = recived;

            param[2] = new SqlParameter("@isCashed", SqlDbType.NVarChar, 10);
            param[2].Value = isCashed;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("DebtRepaymentForInvoice", param);
            accessobject.close();

            return Dt;

        }

        public DataTable set_RepaymentForInvoice_in_the_tables(int inv_id, double recived)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = inv_id;

            param[1] = new SqlParameter("@mny", SqlDbType.Money);
            param[1].Value = recived;

            param[2] = new SqlParameter("@dateT", SqlDbType.DateTime);
            param[2].Value = DateTime.Now;



            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("set_RepaymentForInvoice_in_the_tables", param);
            accessobject.close();

            return Dt;

        }

        public void processOnDebtRepaymentForInvoice(int cus_id, double mny)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            DataTable Dt_not_paid_invo = this.sel_nto_paid_innvoice(cus_id);



            foreach (DataRow row in Dt_not_paid_invo.Rows)
            {
                double total = Convert.ToDouble(row["total_amount"]);
                double revived = Convert.ToDouble(row["recived"]);
                if ((total - revived) <= mny)
                {
                    row["recived"] = row["total_amount"];
                    row["isCashed"] = "Yes";
                    mny -= (Convert.ToDouble(row["total_amount"]) - Convert.ToDouble(row["recived"]));
                }
                else if ((total - revived) > mny && mny != 0)
                {
                    double temp = Convert.ToDouble(row["recived"]);
                    temp += mny;
                    row["recived"] = Convert.ToDouble(temp);
                    mny = 0;
                }
            }


            foreach (DataRow row in Dt_not_paid_invo.Rows)
            {
                if (row["isCashed"].Equals("Yes"))
                {
                    this.DebtRepaymentForInvoice(Convert.ToInt32(row["inv_id"]), Convert.ToDouble(row["recived"]),
                        Convert.ToString(row["isCashed"]));
                }
                else if (row["isCashed"].Equals("NO") && Convert.ToDouble(row["recived"]) > 0)
                {
                    this.DebtRepaymentForInvoice(Convert.ToInt32(row["inv_id"]), Convert.ToDouble(row["recived"]),
                        Convert.ToString(row["isCashed"]));
                }
            }


        }
        public DataTable DebtRepaymentForDoc(int id, double mny)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@mny", SqlDbType.Money);
            param[1].Value = mny;

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("DebtRepaymentForDoc", param);
            accessobject.close();

            return Dt;

        }

        //public DataTable printDebt(int cus_id)
        //{
        //    DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
      
        //    double totalInv = GetFinalValueOfDebt(cus_id);


        //    SqlParameter[] param = new SqlParameter[1];

        //    param[0] = new SqlParameter("@user_id", SqlDbType.Int);
        //    param[0].Value = cus_id;

        //    DataTable Dt = new DataTable();
        //    Dt = accessobject.selectData("printDebt", param);
        //    accessobject.close();
        //    DataRow r = Dt.NewRow();
        //    //r[1] = string.Format("{0:n0}", (totalInv+totalDoc));
        //    //r[6] = string.Format("{0:n0}", totalDoc.ToString());
        //    r[0] = string.Format("{0:n0}", totalInv.ToString());
        //    Dt.Rows.Add(r);
        //    return Dt;

        //}


        public double getTotalDocDebt(int cus_id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();
            DataTable Dt_not_paid_doc = this.sel_nto_paid_doc(cus_id);


            double total =0 ;
            foreach (DataRow row in Dt_not_paid_doc.Rows)
            {
 
                if (Convert.ToDouble( row["rest"]) > 0.0 && 
                    Convert.ToDouble(row["total_amount"]) != Convert.ToDouble(row["paid"]))
                {
                    total += Convert.ToDouble(row["rest"]);
                }
 
            }
            return total;
        }



        public DataTable GetFinalValueOfDebt(int cus_id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            param[0].Value = cus_id;


            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("get_final_debt", param);
            accessobject.close();

            return Dt;

        }


        public DataTable StatementOfAccount(int id)
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

          
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("statement_of_account", param);
            accessobject.close();

            return Dt;
        }


        public DataTable sel_debt_sumation()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

             
            accessobject.open();
            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("sel_debt_sumation", null);
            accessobject.close();

            foreach (DataRow row in Dt.Rows)
            {
                try
                {
                    row["TotalDebt"] = String.Format("{0:n0}", Convert.ToDouble(row["TotalDebt"]));
                }
                catch
                {

                }
            }

            return Dt;

        }


    }


}
