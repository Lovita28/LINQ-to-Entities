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
    class QueryFiltering
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1.where
        //public void whereOnline()
        //{
        //    var OnlineOrders = from order in con.SalesOrderHeader
        //                       where order.OnlineOrderFlag == true
        //                       select new
        //                       {
        //                           OrderID = order.SalesOrderID,
        //                           OrderDate = order.OrderDate,
        //                           OrderNumber = order.SalesOrderNumber
        //                       };
        //    foreach (var online in OnlineOrders)
        //    {
        //        Console.WriteLine("Order ID : {0} Order Date : {1:d} Order Number : {2}",
        //            online.OrderID, online.OrderDate, online.OrderNumber);
        //    }

        //}

        //2. where min max
        //public void Whereminmax()
        //{
        //    int min = 2;
        //    int max = 6;

        //    var query =
        //        from order in con.SalesOrderDetail
        //        where order.OrderQty > min && order.OrderQty < max
        //        select new
        //        {
        //            SalesOrderID = order.SalesOrderID,
        //            OrderQty = order.OrderQty
        //        };

        //    foreach (var order in query)
        //    {
        //        Console.WriteLine("Order ID: {0} Order quantity: {1}",
        //            order.SalesOrderID, order.OrderQty);
        //    }
        //}

        //3. color
        //public void color()
        //{
        //    String color = "Red";

        //    var query = from products in con.Product
        //                where products.Color == color
        //                select new
        //                {
        //                    Name = products.Name,
        //                    ProductNum = products.ProductNumber,
        //                    ListPrice = products.ListPrice
        //                };
        //    foreach(var col in query)
        //    {
        //        Console.WriteLine("Name : {0} Product Number : {1} List Price : ${2}",
        //            col.Name, col.ProductNum, col.ListPrice);
        //    }
        //}

        //3. Date 
        //public void date()
        //{
        //    IQueryable<SalesOrderHeader> query = from order in con.SalesOrderHeader
        //                                         where order.OrderDate >= new DateTime(2003, 12, 1)
        //                                         select order;
        //    Console.WriteLine("Orders that were made after December 1st, 2003:");
        //    foreach(SalesOrderHeader order in query)
        //    {
        //        Console.WriteLine("Order ID : {0} Order Date : {1:d}",
        //            order.SalesOrderID, order.OrderDate);
        //        foreach (SalesOrderDetail orderDetail in order.SalesOrderDetail)
        //        {
        //            Console.WriteLine("Product ID : {0} Unit Price : {1}",
        //                orderDetail.ProductID, orderDetail.UnitPrice);
        //        }
        //    }
        //}

        //4. Where contain 
        //public void WhereContain()
        //{
        //    int?[] productModelsID = { 19, 26, 118 };
        //    var query = from p in con.Product
        //                where productModelsID.Contains(p.ProductModelID)
        //                select p;
        //    foreach (var prod in query)
        //    {
        //        Console.WriteLine("{0} : {1}", prod.ProductModelID, prod.ProductID);
        //    }
        //}

        //5. where contain 2
        //public void WhereII()
        //{
        //    var query = from p in con.Product
        //                where (new int?[] { 19, 26, 118 }).Contains(p.ProductModelID) ||
        //                (new string[] { "L", "XL" }).Contains(p.Size)
        //                select p;
        //    foreach (var prod in query)
        //    {
        //        Console.WriteLine("{0} : {1} : {2}", prod.ProductID,
        //            prod.ProductModelID, prod.Size);
        //    }
        //}
    }
}
