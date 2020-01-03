using System.Data;


namespace IFarmer.BL.invoices
{
    class SelectionOrder
    {
        public DataTable ListOrders()
        {
            DAL.DataAccessLayer accessobject = new DAL.DataAccessLayer();

            DataTable Dt = new DataTable();
            Dt = accessobject.selectData("list_order", null);
            accessobject.close();


            return Dt;
        }
    }
}
