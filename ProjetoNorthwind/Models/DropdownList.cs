using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNorthwind.Models
{
    public class DropdownList
    {
        public List<EmployeeList> Employees { get; set; }
        public List<CustomerList> Customers { get; set; }
        public List<ProductList> Products { get; set; }

        public string EmployeesId { get; set; }
        public string CustomersId { get; set; }

    }
}
