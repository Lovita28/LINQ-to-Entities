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
    class QueryJoin
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1.Group Join 1
        //public void GroupI()
        //{
        //    var orders = con.SalesOrderHeader;
        //    var details = con.SalesOrderDetail;

        //    var query = from order in orders
        //                join detail in details
        //                on order.SalesOrderID equals detail.SalesOrderID
        //                into orderGroup
        //                select new
        //                {
        //                    CustomerID = order.CustomerID,
        //                    OrderGroup = orderGroup.Count()
        //                };
        //    foreach (var order in query)
        //    {
        //        Console.WriteLine("Customer ID : {0} Order Count : {1}",
        //            order.CustomerID, order.OrderGroup);
        //    }
        //}

        //2. Goup Join 2
        //public void GroupII()
        //{
        //    var contacts = con.Customer;
        //    var orders = con.SalesOrderHeader;

        //    var query =
        //        from contact in contacts
        //        join order in orders
        //        on contact.CustomerID
        //        equals order.CustomerID into contactGroup
        //        select new
        //        {
        //            ContactID = contact.CustomerID,
        //            OrderCount = contactGroup.Count(),
        //            Orders = contactGroup
        //        };

        //    foreach (var group in query)
        //    {
        //        Console.WriteLine("ContactID: {0}", group.ContactID);
        //        Console.WriteLine("Order count: {0}", group.OrderCount);
        //        foreach (var orderInfo in group.Orders)
        //        {
        //            Console.WriteLine("   Sale ID: {0}", orderInfo.SalesOrderID);
        //        }
        //        Console.WriteLine("");
        //    }
        //}

        //3. Group Join 3
        //public void GroupIII()
        //{
        //    var contacts = con.Customer;
        //    var orders = con.SalesOrderHeader;

        //    var query =
        //        from contact in contacts
        //        join order in orders
        //        on contact.CustomerID
        //        equals order.CustomerID into contactGroup
        //        select new
        //        {
        //            ContactID = contact.CustomerID,
        //            OrderCount = contactGroup.Count(),
        //            Orders = contactGroup
        //        };

        //    foreach (var group in query)
        //    {
        //        Console.WriteLine("ContactID: {0}", group.ContactID);
        //        Console.WriteLine("Order count: {0}", group.OrderCount);
        //        foreach (var orderInfo in group.Orders)
        //        {
        //            Console.WriteLine("   Sale ID: {0}", orderInfo.SalesOrderID);
        //        }
        //        Console.WriteLine("");
        //    }
        //}

        //4.Join 
        //public void JoinD()
        //{
        //    var orders = con.SalesOrderHeader;
        //    var details = con.SalesOrderDetail;

        //    var query = from order in orders
        //                join detail in details
        //                on order.SalesOrderID equals detail.SalesOrderID
        //                where order.OnlineOrderFlag == true && order.OrderDate.Month == 8
        //                select new
        //                {
        //                    SalesOrderID = order.SalesOrderID,
        //                    SalesOrderDetailID = detail.SalesOrderDetailID,
        //                    OrderDate = order.OrderDate,
        //                    ProductID = detail.ProductID
        //                };
        //    foreach (var order in query)
        //    {
        //        Console.WriteLine("{0}\t{1}\t{2:d}\t{3}",
        //            order.SalesOrderID, order.SalesOrderDetailID, order.OrderDate, order.ProductID);
        //    }
        //}
    }
}
