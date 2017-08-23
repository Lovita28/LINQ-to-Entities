using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Core.Objects;
using System.Globalization;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;

namespace Adventurelinq
{
    class QueryProjection
    {
        AdventureWorks2014Entities con = new AdventureWorks2014Entities();
        //1. Select 
        //public void selectt()
        //{
        //    IQueryable<Product> prodd = from product in con.Product select product;

        //    Console.WriteLine("Product names : ");
        //    foreach(var print in prodd)
        //    {
        //        Console.WriteLine(print.Name);
        //    }
        //}

        //2. Select by name 
        //public void Name()
        //{
        //    IQueryable<string> prod = from product in con.Product select product.Name;

        //    Console.WriteLine("Product name : ");
        //    foreach (String nam in prod)
        //    {
        //        Console.WriteLine(nam);
        //    }
        //}

        //3. Select by Prod name 
        //public void prodname()
        //{
        //    var query = from product in con.Product
        //                select new
        //                {
        //                    ProductID = product.ProductID,
        //                    ProductName = product.Name
        //                };
        //    Console.WriteLine("Product Info: ");
        //    foreach(var pro in query)
        //    {
        //        Console.WriteLine("Product ID : {0} Product name : {1}",
        //            pro.ProductID, pro.ProductName);
        //    }
        //}

        //4.from..from..
        //public void fromII()
        //{
        //    decimal Totaldue = 500.00M;

        //    var customers = con.Customer;
        //    var orders = con.SalesOrderHeader;

        //    var query = from customer in customers
        //                from order in orders
        //                where customer.CustomerID == order.CustomerID && order.TotalDue < Totaldue
        //                select new
        //                {
        //                    CustomerID = customer.CustomerID,
        //                    LastName = customer.Person.LastName,
        //                    FirstName = customer.Person.FirstName,
        //                    OrderID = order.SalesOrderID,
        //                    Total = order.TotalDue
        //                };
        //    foreach (var small in query)
        //    {
        //        Console.WriteLine(" Customer ID : {0} Name : {1} {2} Order ID : {3} Total : ${4}",
        //            small.CustomerID, small.LastName, small.FirstName, small.OrderID, small.Total);
        //    }

        //}

        //5. from many
        public void frommany()
        {
            decimal Totaldue = 10000.0M;

            var customers = con.Customer;
            var orders = con.SalesOrderHeader;

            var query = from customer in customers
                        from order in orders
                        let total = order.TotalDue
                        where customer.CustomerID == order.CustomerID && total >= Totaldue
                        select new
                        {
                            CustomerID = customer.CustomerID,
                            LastName = customer.Person.LastName,
                            OrderID = order.SalesOrderID,
                            total
                        };
            foreach (var small in query)
            {
                Console.WriteLine(" Customer ID : {0} Name : {1} Order ID : {2} Total : ${3}",
                    small.CustomerID, small.LastName, small.OrderID, small.total);
            }

        }
    }
}
