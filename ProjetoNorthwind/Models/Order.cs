namespace ProjetoNorthwind.Models
{
    public class Order
    {
        public string OrderID { get; set; }
        public string CustomerID { get; set; }
        public string EmployeeID { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public string ShippedDate { get; set; }
        public string ShipVia { get; set; }
        public string Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }


        /*
         
                                Cliente ID(CustomerID)
    Cliente Nome(front)
                                Funcio ID(EmployeeID)
    Funcio Nome(front)
                                OrderID 
    Product Nome (front)
                                OrderDate.DataTime.now
                                RequiredDate.DataTime.now
                                ShippedDate(DataTime.now + 1 dia)
                                ShipVia.get(SupplierID)
                                ShipName = Supplier.companyName
                                ShipAddress = usuario Diz
                                ShipCity = usuario Diz
     */


        //int               order.OrderID = _service.getIdOrder();
        //nchar(5)          order.CustomerID = client.CustomerID;
        //int               order.EmployeeID = employee.EmployeeID;
        //datetime          order.OrderDate = dateOrder;
        //datetime          order.RequiredDate = dateOrder;
        //datetime          order.ShippedDate = dateOrder;
        //int               order.ShipVia = shipper.SupplierID;
        //money             order.Freight = "20,38";
        //nvarchar(40)      order.ShipName = shipper.CompanyName;
        //nvarchar(60)      order.ShipAddress = "";
        //nvarchar(15)      order.ShipCity = "";
        //nvarchar(15)	    shipRegion
        //nvarchar(10)	    shipPostal
        //nvarchar(15)	    ShipCountry
    }
}
