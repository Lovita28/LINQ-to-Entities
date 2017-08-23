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
    class Relationship
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1.Example
        //public void Exx()
        //{
        //    string lastname = "Zhou";

        //    IQueryable<PersonCreditCard> order = con.Person.Where(c => c.LastName == lastname)
        //        .SelectMany(c => c.PersonCreditCard);

        //    foreach (var ord in order)
        //    {
        //        Console.WriteLine("Business ID : {0} Creadit card ID : {1} Modified Date : {2:d}",
        //            ord.BusinessEntityID, ord.CreditCardID, ord.ModifiedDate);
        //    }
        //}

        //2.Example 
        //public void exxi()
        //{
        //    var cusor = con.Customer.Where(c => c.CustomerID >= 1000)
        //        .Select(c => new
        //        {
        //            CustomerID = c.CustomerID,
        //            Total = c.SalesOrderHeader.Sum(o => o.TotalDue)
        //        });
        //    foreach (var cuss in cusor)
        //    {
        //        Console.WriteLine("Customer ID : {0} Total Due : {1}",
        //            cuss.CustomerID, cuss.Total);
        //    }
        //}

        //3.Example
        //public void exxii()
        //{

        //    var query = con.Customer.Where(c => c.CustomerID >= 1000)
        //        .Select(c => new { CustomerID = c.CustomerID, Orders = c.SalesOrderHeader });

        //    foreach(var gr in query)
        //    {
        //        Console.WriteLine("Customer ID : {0}", gr.CustomerID);
        //        foreach (SalesOrderHeader sale in gr.Orders)
        //        {
        //            Console.WriteLine("Order ID : {0} Order Date : {1} Total Due : {2}",
        //                sale.SalesOrderID, sale.OrderDate, sale.TotalDue);
        //        }
        //    }
        //}

        //4.Example
        //public void exxiii()
        //{
        //    string city = "Seattle";

        //    var query = con.SalesOrderHeader.Where(s => s.Address.City == city)
        //        .Select(o => new
        //        {
        //            LastName = o.Customer.Person.LastName,
        //            Firstname = o.Customer.Person.FirstName,
        //            Streetadres = o.Address.AddressLine1,
        //            OrderNumber = o.SalesOrderNumber,
        //            Total = o.TotalDue
        //        });
        //    foreach (var gr in query)
        //    {
        //        Console.WriteLine("Name : {0} {1}", gr.LastName, gr.Firstname);
        //        Console.WriteLine("Street Address : {0}", gr.Streetadres);
        //        Console.WriteLine("Order Number : {0}", gr.OrderNumber);
        //        Console.WriteLine("Total : {0}", gr.Total);
        //        Console.WriteLine("");
        //    }

        //}

        //5. Example 
        public void exxiiii()
        {
            IQueryable<SalesOrderHeader> query =
                from order in con.SalesOrderHeader
                where order.OrderDate >= new DateTime(2003, 12, 1)
                select order;
            Console.WriteLine("order that were made after December 1, 12:");
            foreach (SalesOrderHeader order in query)
            {
                Console.WriteLine("Order id : {0} Order Date : {1:d}",
                    order.SalesOrderID, order.OrderDate);
                foreach(SalesOrderDetail orderDetail in order.SalesOrderDetail)
                {
                    Console.WriteLine("Product id : {0} Unit Price : {1}",
                        orderDetail.ProductID, orderDetail.UnitPrice);
                }

            }
        }
    }
}
