using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFarmer.BL.Login
{
    class InsertButtonName
    {
        public void InsertBtnName(MetroFramework.Forms.MetroForm form)
        {
            foreach (var btn in form.Controls.OfType<Bunifu.Framework.UI.BunifuThinButton2>())
            {
                btn.Enabled = false;  
            }
        }
    }
}
