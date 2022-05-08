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
    public class EcommerceController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindService _service;

        public EcommerceController(ILogger<HomeController> logger, NorthwindService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Ecommerce()
        {
            DropdownList dropdownlist = new DropdownList
            { 
                Customers = _service.GetCustomerList(),
                Employees = _service.GetEmployeeList()
            };

            return View(dropdownlist); // Retorna as informaçoes de Customers e Employees
        }
        public IActionResult step_1()
        {
            string clientId = Request.Form["client"].ToString();
            string employeeId = Request.Form["employee"].ToString();

            CustomerList client;
            client = _service.GetClient(clientId);

            EmployeeList employee;

            employee = _service.GetEmployee(employeeId);

            Ecommerce ecommerce = new Ecommerce();
            
            ecommerce.Customer = client;
            ecommerce.Customer.CustomerID = clientId;

            ecommerce.Employee = employee;
            ecommerce.ProductsEcommerceList = _service.GetProductList();

            return View(ecommerce);
   
        }
        public IActionResult AddPedido(string idCliente, string idFunc, string idProduto)
        { 
            OrderViewModel orderView = new OrderViewModel();

            Shipper shipper; 
            CustomerList client;
            EmployeeList employee;
            ProductList product;
            Order order = new Order();

            client = _service.GetClient(idCliente);
            client.CustomerID = idCliente;
            employee = _service.GetEmployee(idFunc);
            employee.EmployeeID = idFunc;
            product = _service.GetProduct(idProduto);
            shipper = _service.GetShipper(_service.getIdShip());
  
            //ano, mês, dia, hora, minuto e segundo
            var date = new DateTime(2022, 5, 4, 10, 30, 52);
            string dateOrder = date.ToString();

            //Criando os dados da Order
            order.OrderID = _service.getIdOrder();
            order.CustomerID = client.CustomerID;
            order.EmployeeID = employee.EmployeeID;
            order.OrderDate = dateOrder;
            order.RequiredDate = dateOrder;
            order.ShipVia = shipper.SupplierID;
            order.Freight = "20";
            order.ShipName = shipper.CompanyName;
            order.ShipAddress = "";
            order.ShipCity = "";

            orderView.client = client;
            orderView.employee = employee;
            orderView.product = product;
            orderView.order = order;

            //crud de order 
            return View(orderView);
        }
        public IActionResult AddOrder(string idOrder, string productName, string idCliente, string idFunc, string OrderDate, string RequiredDate, string ShipVia, string Freight, string ShipName, string ShipAddress, string ShipCity)
        {
            OrderViewModel orderView = new OrderViewModel();
            Order order = new Order();

            var date = new DateTime(2022, 5, 4, 10, 30, 52);
            string dateOrder = date.ToString();

            order.OrderID = idOrder;
            order.CustomerID = idCliente;
            order.EmployeeID = idFunc;
            order.OrderDate = OrderDate;
            order.RequiredDate = dateOrder;
            order.ShipVia = ShipVia;
            order.Freight = Freight;
            order.ShipName = ShipName;
            order.ShipAddress = ShipAddress;
            order.ShipCity = ShipCity;
            order.ShippedDate = dateOrder;


            if (ShipAddress == null && ShipCity == null)
            {
                order.ShipAddress = "Home";
                order.ShipCity = "Rio de Janeiro";
            }

            _service.InsertOrder(order);

            orderView.order = order;

            EcommerceDetails view = new EcommerceDetails();

            view.CompanyName = _service.GetClient(idCliente).ContactName;
            view.FirstName = _service.GetEmployee(idFunc).FirstName;
            view.ProductName = productName;
            return View(view);
        }

        public IActionResult ExibirOrder()
        {
            OrderViewModel orderListView = new OrderViewModel();
            orderListView.orderlist = _service.GetOrderList();

          

            return View(orderListView);
        }
    }
}
