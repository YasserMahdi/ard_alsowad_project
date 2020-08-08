using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml.Linq;

namespace IFarmer.DataGroup
{
    class NewXmlClass
    {
        public void CreateXL()
        {
            XDocument xdoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Alert",new XElement("a","Yasser"))
                
            );
            xdoc.Save(@"C:\Users\HP\Documents\UI\data.xml");
        }

        


    }
}
