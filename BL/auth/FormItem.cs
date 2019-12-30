using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace IFarmer.BL.auth
{
    class FormItem
    {
        public DataTable GetFormItem(string FormName)
        {
            var FormType = Assembly.GetExecutingAssembly().GetTypes()
                .Where(a => a.BaseType == typeof(MetroFramework.Forms.MetroForm) && a.GetType().Name == FormName).FirstOrDefault();

            MetroFramework.Forms.MetroForm f = (MetroFramework.Forms.MetroForm)Activator.CreateInstance(FormType);
            DataTable FormItem = new DataTable();

            var Btn = f.Controls.OfType<Bunifu.Framework.UI.BunifuFlatButton>();
            if(Btn.Count() > 0)
            {
                for(int i = 0; i < Btn.Count(); i++)
                {
                    string name = Btn.ElementAt(i).Name;
                    string Text = Btn.ElementAt(i).Text;
                    String mType = Btn.ElementAt(i).GetType().ToString();

                    FormItem.Rows.Add(f.Name, name, Text, mType);

                }

            }
            return FormItem;
        }

        public void LoadItemToDateBae(string FormName)
        {

            BL.auth.FormItem item = new BL.auth.FormItem();
            BL.auth.Permissions per = new BL.auth.Permissions();
            DataTable dt = new DataTable();
            dt.Merge(item.GetFormItem(FormName));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                per.InsertPer(dt.Rows[i][0].ToString(), dt.Rows[i][0].ToString());
            }
        }
    }
}
