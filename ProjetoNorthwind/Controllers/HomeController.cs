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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindService _service;

        public HomeController(ILogger<HomeController> logger, NorthwindService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            DropdownList dropdownlist = new DropdownList
            { 
                Customers = _service.GetCustomerList(),
                Employees = _service.GetEmployeeList()
            };

            return View(dropdownlist); // Retorna as informaçoes de Customers e Employees
        }
        public IActionResult List()
        {
            DropdownList dropdownlist = new DropdownList
            {
                Customers = _service.GetCustomerList(),
                Employees = _service.GetEmployeeList()
            };

            return View(dropdownlist); // Retorna as informaçoes de Customers e Employees
        }
        public IActionResult ProcedureRio()
        {
            List<ProceRio> listRio = new List<ProceRio>();


            listRio = _service.GetProcedure();

            return View(listRio); // Retorna as informaçoes de Customers e Employees
        }
    }
}
