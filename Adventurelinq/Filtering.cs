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
    class Filtering
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1. Where 
        //public void Cetak()
        //{
        //    var onlineOrders = con.SalesOrderHeader
        //        .Where(order => order.OnlineOrderFlag == true)
        //        .Select(s => new { s.SalesOrderID, s.OrderDate, s.SalesOrderNumber });

        //    foreach (var online in onlineOrders)
        //    {
        //        Console.WriteLine("Order ID : {0} Order Date : {1:d} Order Number : {2}",
        //            online.SalesOrderID, online.OrderDate, online.SalesOrderNumber);
        //    }
        //    Console.ReadKey();
        //}

        //Where
        //public void Minmax()
        //{
        //    int orderQmin = 2;
        //    int orderQmax = 6;

        //    var query = con.SalesOrderDetail
        //        .Where(order => order.OrderQty > orderQmin && order.OrderQty < orderQmax)
        //        .Select(s => new { s.SalesOrderID, s.OrderQty });

        //    foreach (var quan in query)
        //    {
        //        Console.WriteLine("Order Id : {0} Order Quantity : {1}",
        //            quan.SalesOrderID, quan.OrderQty);
        //    }


        //    Console.ReadKey();
        //}

        //where colour
        //public void Warna()
        //{
        //    String color = "Red";

        //    var query = con.Product
        //        .Where(product => product.Color == color)
        //        .Select(p => new { p.Name, p.ProductNumber, p.ListPrice });

        //    foreach (var col in query)
        //    {
        //        Console.WriteLine("Name : {0}", col.Name);
        //        Console.WriteLine("Product Number : {0}", col.ProductNumber);
        //        Console.WriteLine("List Price : ${0}", col.ListPrice);
        //        Console.WriteLine("");
        //    }
        //}

        //public void tanggal()
        //{
        //    IQueryable<SalesOrderHeader> query = con.SalesOrderHeader
        //        .Where(order => order.OrderDate >= new DateTime(2003, 12, 1));

        //    Console.WriteLine("Order that were made after December 1, 2003:");
        //    foreach (SalesOrderHeader order in query)
        //    {
        //        Console.WriteLine("OrderId : {0} Order Date : {1:d}",
        //            order.SalesOrderID, order.OrderDate);
        //        foreach (SalesOrderDetail orderDetail in order.SalesOrderDetail)
        //        {
        //            Console.WriteLine("Product id : {0} Unit Price : {1}",
        //                orderDetail.ProductID, orderDetail.UnitPrice);
        //        }
        //    }

        //    Console.ReadKey();
        //}

        //2. Where Contain 
        //public void Termasuk()
        //{
        //    int?[] productModelIds = { 19, 26, 118 };
        //    var product = con.Product.
        //        Where(p => productModelIds.Contains(p.ProductModelID));

        //    foreach (var prod in product)
        //    {
        //        Console.WriteLine("{0} : {1} ", prod.ProductModelID, prod.ProductID);
        //    }

        //    Console.ReadKey();
        //}

        //public void Ukuran()
        //{
        //    var products = con.Product.
        //        Where(p => (new int?[] { 19, 26, 18 }).Contains(p.ProductModelID) ||
        //       (new string[] { "L", "XL" }).Contains(p.Size));

        //    foreach (var prod in products)
        //    {
        //        Console.WriteLine("{0} : {1},{2}",
        //           prod.ProductID, prod.ProductModelID, prod.Size);
        //    }
        //}


    }
}
