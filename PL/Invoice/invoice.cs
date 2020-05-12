using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFarmer.PL.Invoice
{
    interface invoice
    {
        void Save();
        void createColumns();
        void clearBoxes();
        void calculateAmount();
 
    }
}
