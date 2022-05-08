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
    public class ClientController : Controller
    {
        private readonly ILogger<ClientController> _logger;
        private readonly NorthwindService _service;

        public ClientController(ILogger<ClientController> logger, NorthwindService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Client()
        {
  
            return View(); 
        }

        public IActionResult Client_Detail()
        {
            CustomerList client;
            client = _service.GetClient(Request.Form["id"]);
           
            return View(client); 
        }
        public IActionResult Client_Delete()
        {
            CustomerList client;
            Console.WriteLine("AQUI:" + Request.Form["id"]);
            _service.DeleteClient(Request.Form["id"]);
            
            return View(); 
        }
        public IActionResult Client_Register()
        {
            CustomerList client = new CustomerList();

            client.ContactName = Request.Form["name"];
            client.CompanyName = Request.Form["company"];
            client.Address = Request.Form["address"];
            client.City = Request.Form["city"];
            client.Region = Request.Form["region"];
            client.PostalCode = Request.Form["postalCode"];
            client.Country = Request.Form["country"];
            client.Phone = Request.Form["phone"];

            _service.InsertClient(client);
            return View(); 
        }

        public IActionResult Client_Update()
        {
            CustomerList client = new CustomerList();

            client.CustomerID = Request.Form["id"];
            client.ContactName = Request.Form["name"];
            client.CompanyName = Request.Form["company"];
            client.Address = Request.Form["address"];
            client.City = Request.Form["city"];
            client.Region = Request.Form["region"];
            client.PostalCode = Request.Form["postalCode"];
            client.Country = Request.Form["country"];
            client.Phone = Request.Form["phone"];

            _service.UpdateClient(client);
            return View(); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
