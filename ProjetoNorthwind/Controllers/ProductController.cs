using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoNorthwind.Models;
using ProjetoNorthwind.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNorthwind.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindService _service;

        public ProductController(ILogger<HomeController> logger, NorthwindService service)
        {
            _logger = logger;
            _service = service;
        }
        public IActionResult Product()
        {
            DropdownList dropdownlist = new DropdownList
            {
                Customers = _service.GetCustomerList(),
                Employees = _service.GetEmployeeList(),
                Products = _service.GetProductList()
            };

            return View(dropdownlist); // Retorna as informaçoes de Customers e Employees
        }
    }
}
