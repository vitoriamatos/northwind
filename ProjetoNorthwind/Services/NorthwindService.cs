using Microsoft.Extensions.Configuration;
using ProjetoNorthwind.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNorthwind.Services
{
    /* Essa Classe NorthwinService faz:
    Obtém a string de conexão no arquivo appsettings.json
    Acessa a tabela Customers e gera uma lista de customers com ID e nome;
    Acessa a tabela Employees e gera uma lista de employees com ID e nome;
    */
    public class NorthwindService
    {
        public IConfigurationRoot GetConnection()
        {
            var builder = new ConfigurationBuilder()
                                  .SetBasePath(Directory.GetCurrentDirectory())
                                  .AddJsonFile("appSettings.json").Build();

            return builder;
        }
        public List<ProceRio> GetProcedure() {

            SqlDataAdapter da;

            var connection = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            SqlConnection con = new SqlConnection(connection);

            SqlCommand cmd = new SqlCommand("sp_RetorneRio", con);
            cmd.CommandType = CommandType.StoredProcedure;
            da = new SqlDataAdapter(cmd);

            
            con.Open();


            SqlDataReader idr = cmd.ExecuteReader();
            List<ProceRio> RioList = new List<ProceRio>();

            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    RioList.Add(new ProceRio
                    {
                        OrderID = Convert.ToString(idr["OrderID"]),
                        CustomerID = Convert.ToString(idr["CustomerID"]),
                        EmployeeID = Convert.ToString(idr["EmployeeID"]),
                        OrderDate = Convert.ToString(idr["OrderDate"]),
                        RequiredDate = Convert.ToString(idr["RequiredDate"]),
                        ShippedDate = Convert.ToString(idr["ShippedDate"]),
                        ShipVia = Convert.ToString(idr["ShipVia"]),
                        Freight = Convert.ToString(idr["Freight"]),
                        ShipName = Convert.ToString(idr["ShipName"]),
                        ShipAddress = Convert.ToString(idr["ShipAddress"]),
                        ShipCity = Convert.ToString(idr["ShipCity"]),
                        ShipRegion = Convert.ToString(idr["ShipRegion"]),
                        ShipPostalCode = Convert.ToString(idr["ShipPostalCode"]),
                        ShipCountry = Convert.ToString(idr["ShipCountry"])
                    });

                }

            }

            con.Close();
            return RioList;

        }
        public List<CustomerList> GetCustomerList()
        {
            var connection = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select CustomerID, ContactName From Customers", con);
            con.Open();

            SqlDataReader idr = cmd.ExecuteReader();
            List<CustomerList> customers = new List<CustomerList>();


            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    customers.Add(new CustomerList
                    {
                        CustomerID = Convert.ToString(idr["CustomerID"]),
                        ContactName = Convert.ToString(idr["ContactName"]),
                    });
                }
            }

            con.Close();
            return customers;
        }
        public List<EmployeeList> GetEmployeeList()
        {

            var connection = GetConnection().GetSection("ConnectionStrings")
                                      .GetSection("DefaultConnection").Value;

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select EmployeeID,FirstName From Employees", con);

            con.Open();
            SqlDataReader idr = cmd.ExecuteReader();
            List<EmployeeList> Employees = new List<EmployeeList>();

            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    Employees.Add(new EmployeeList
                    {
                        EmployeeID = Convert.ToString(idr["EmployeeID"]),
                        FirstName = Convert.ToString(idr["FirstName"]),
                    });
                }
            }
            con.Close();
            return Employees;
        }
        public List<ProductList> GetProductList()
        {

            var connection = GetConnection().GetSection("ConnectionStrings")
                                      .GetSection("DefaultConnection").Value;

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select ProductID, ProductName, QuantityPerUnit, UnitPrice From Products", con);

            con.Open();
            SqlDataReader idr = cmd.ExecuteReader();
            List<ProductList> Products = new List<ProductList>();

            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    Products.Add(new ProductList
                    {
                        ProductID = Convert.ToString(idr["ProductID"]),
                        ProductName = Convert.ToString(idr["ProductName"]),
                        QuantityPerUnit = Convert.ToString(idr["QuantityPerUnit"]),
                        UnitPrice = Convert.ToString(idr["UnitPrice"])
                    });
                }
            }
            con.Close();
            return Products;
        }
        public List<Shipper> GetShipperList()
        {

            var connection = GetConnection().GetSection("ConnectionStrings")
                                      .GetSection("DefaultConnection").Value;

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("select SupplierID, CompanyName, Phone from [dbo].[Suppliers]", con);

            con.Open();
            SqlDataReader idr = cmd.ExecuteReader();
            List<Shipper> shippers = new List<Shipper>();

            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    shippers.Add(new Shipper
                    {
                        SupplierID = Convert.ToString(idr["SupplierID"]),
                        CompanyName = Convert.ToString(idr["CompanyName"]),
                        Phone = Convert.ToString(idr["Phone"])
                    });
                }
            }
            con.Close();
            return shippers;
        }
        public List<Order> GetOrderList()
        {

            var connection = GetConnection().GetSection("ConnectionStrings")
                                      .GetSection("DefaultConnection").Value;

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("select OrderID,CustomerID,EmployeeID,ShipName,ShipAddress,ShipCity from Orders", con);

            con.Open();
            SqlDataReader idr = cmd.ExecuteReader();
            List<Order> orders = new List<Order>();

            //OrderID,CustomerID,EmployeeID,ShipName,ShipAddress,ShipCity
            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    orders.Add(new Order
                    {
                        OrderID = Convert.ToString(idr["OrderID"]),
                        CustomerID = Convert.ToString(idr["CustomerID"]),
                        EmployeeID = Convert.ToString(idr["EmployeeID"]),
                        ShipName = Convert.ToString(idr["ShipName"]),
                        ShipAddress = Convert.ToString(idr["ShipAddress"]),
                        ShipCity = Convert.ToString(idr["ShipCity"])
                    });
                }
            }
            con.Close();
            return orders;
        }
        public string getId()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[4];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString;
        }
        public string getIdOrder()
        {
            int idOrder = 0;
            Random randNum = new Random();

            idOrder = randNum.Next(20000);

            while (GetOrder(idOrder) != 0 && idOrder > 10000)
            {
                idOrder = randNum.Next(20000);
            }
            string id = idOrder.ToString();

            return id;
        }
        public string getIdShip()
        {
            int IdShip = 0;
            Random randNum = new Random();

            IdShip = randNum.Next(30);

           string id = IdShip.ToString();

            return id;
        }
        public void InsertClient(CustomerList client)
        {

            var connection = GetConnection().GetSection("ConnectionStrings")
                                      .GetSection("DefaultConnection").Value;

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Insert into Customers(CustomerID,CompanyName, ContactName, Address, City, Region, PostalCode, Country, Phone) Values ('"+getId()+"','" + client.CompanyName + "','" + client.ContactName + "','" + client.Address + "','" + client.City + "','" + client.Region + "','" + client.PostalCode + "','" + client.Country + "','" + client.Phone + "')", con);
            con.Open();
            SqlDataReader idr = cmd.ExecuteReader();
            con.Close();

        }
        public void UpdateClient(CustomerList client)
        {

            var connection = GetConnection().GetSection("ConnectionStrings")
                                      .GetSection("DefaultConnection").Value;

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("UPDATE Customers SET ContactName = '"+client.ContactName+"', Address = '"+client.Address+"', City = '"+client.City+"', Region = '"+client.Region+ "', PostalCode = '"+client.PostalCode+"', Country = '"+client.Country+"', Phone = '"+client.Phone+"' WHERE CustomerID = '"+client.CustomerID+"'", con);
            con.Open();
            SqlDataReader idr = cmd.ExecuteReader();
            con.Close();

        }
        public void DeleteClient(String id)
        {

            var connection = GetConnection().GetSection("ConnectionStrings")
                                      .GetSection("DefaultConnection").Value;

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Delete From Customers WHERE CustomerID = '"+id+"'", con);
            con.Open();
            SqlDataReader idr = cmd.ExecuteReader();
            con.Close();

        }
        public bool InsertOrder(Order order)
        {
            int IdOrder = int.Parse(order.OrderID);
            int IdEmployee = int.Parse(order.EmployeeID);
            DateTime DateOrder = DateTime.Parse(order.OrderDate);
            DateTime DateRequired = DateTime.Parse(order.RequiredDate);
            DateTime DateShipped = DateTime.Parse(order.ShippedDate);
            int ShipVia = int.Parse(order.ShipVia);
            int Freight = int.Parse(order.Freight);

            var connection = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            SqlConnection con = new SqlConnection(connection);
           
            SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT dbo.Orders ON;Insert into Orders(OrderID,CustomerID,EmployeeID,ShipName,ShipAddress,ShipCity) Values (" + IdOrder +",'" + order.CustomerID + "'," + IdEmployee + ",'" + order.ShipName + "','" + order.ShipAddress + "','" + order.ShipCity + "')", con);
            con.Open();
 
            SqlDataReader idr = cmd.ExecuteReader();
            con.Close();

            return true;
        }
        public CustomerList GetClient(String id)
        {
            var connection = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            string num = id.Trim();

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select CustomerID, CompanyName, ContactName, Address, City, Region, PostalCode, Country, Phone From Customers WHERE CustomerID = '" + num + "'", con);
            con.Open();


            SqlDataReader idr = cmd.ExecuteReader();
            CustomerList customers = new CustomerList();
            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    customers.CustomerID = Convert.ToString(idr["CustomerID"]);
                    customers.ContactName = Convert.ToString(idr["ContactName"]);
                    customers.Address = Convert.ToString(idr["Address"]);
                    customers.City = Convert.ToString(idr["City"]);
                    customers.Region = Convert.ToString(idr["Region"]);
                    customers.PostalCode = Convert.ToString(idr["PostalCode"]);
                    customers.Country = Convert.ToString(idr["Country"]);
                    customers.Phone = Convert.ToString(idr["Phone"]);
                }
            }
            con.Close();
            return customers;
        }
        public EmployeeList GetEmployee(String id)
        {
            var connection = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            int num = Convert.ToInt32(id);

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("Select EmployeeID, FirstName From Employees WHERE EmployeeID = '" + num + "'", con);
            con.Open();


            SqlDataReader idr = cmd.ExecuteReader();
            EmployeeList employee = new EmployeeList();
            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    employee.EmployeeID = Convert.ToString(idr["EmployeeId"]);
                    employee.FirstName = Convert.ToString(idr["FirstName"]);
                }
            }
            con.Close();
            return employee;
        }
        public ProductList GetProduct(String id)
        {
            var connection = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            int num = Convert.ToInt32(id);

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("select ProductID, ProductName,QuantityPerUnit,UnitPrice from Products where ProductID =  '" + num + "'", con);
            con.Open();


            SqlDataReader idr = cmd.ExecuteReader();
            ProductList produto = new ProductList();

            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    produto.ProductID = Convert.ToString(idr["ProductID"]);
                    produto.ProductName = Convert.ToString(idr["ProductName"]);
                    produto.QuantityPerUnit = Convert.ToString(idr["QuantityPerUnit"]);
                    produto.UnitPrice = Convert.ToString(idr["UnitPrice"]);

                }
            }
            con.Close();
            return produto;
        }
        public Shipper GetShipper(String id)
        {
            var connection = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            int num = Convert.ToInt32(id);

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("select SupplierID, CompanyName, Phone from Suppliers where SupplierID = " + num, con);
            con.Open();
            

            SqlDataReader idr = cmd.ExecuteReader();
            Shipper ship = new Shipper();

            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    ship.SupplierID = Convert.ToString(idr["SupplierID"]);
                    ship.CompanyName = Convert.ToString(idr["CompanyName"]);
                    ship.Phone = Convert.ToString(idr["Phone"]);
                }
            }
            con.Close();
            return ship;
        }
        public int GetOrder(int id)
        {
            var connection = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

            string idOrderObj = "0";

            SqlConnection con = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("select [OrderID] from [dbo].[Orders] where [OrderID] = '" + id + "'", con);
            con.Open();


            SqlDataReader idr = cmd.ExecuteReader();
            CustomerList customers = new CustomerList();
            if (idr.HasRows)
            {
                while (idr.Read())
                {
                    idOrderObj = Convert.ToString(idr["OrderID"]);
                }
            }
            con.Close();

            int idOrder = int.Parse(idOrderObj);

            return idOrder;
        }
    }
}
