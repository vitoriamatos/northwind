using System.Collections.Generic;

namespace ProjetoNorthwind.Models
{
    public class OrderViewModel
    {
        //public Shipper shipper { get; set; }

        public CustomerList client { get; set; }

        public EmployeeList employee { get; set; }

        public ProductList product { get; set; }

        public Order order { get; set; }

        public List<Order> orderlist { get; set; }
    }

}
