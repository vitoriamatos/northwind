using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNorthwind.Models
{
    public class Ecommerce
    {
        public string EcommerceID { get; set; }
        public CustomerList Customer { get; set; } //string
        public EmployeeList Employee { get; set; } //int

        public List<ProductList> ProductsEcommerceList { get; set; }

    }
}
