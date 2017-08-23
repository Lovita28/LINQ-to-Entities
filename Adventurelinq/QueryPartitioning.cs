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
    class QueryPartitioning
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1. SKip
        //public void Skiip()
        //{
        //    var addresss = con.Address;
        //    var orders = con.SalesOrderHeader;

        //    var query = (
        //                 from address in addresss
        //                 from order in orders
        //                 where address.AddressID == order.Address.AddressID
        //                      && address.City == "Seattle"
        //                 orderby order.SalesOrderID
        //                 select new
        //                 {
        //                     City = address.City,
        //                     OrderID = order.SalesOrderID,
        //                     OrderDate = order.OrderDate
        //                 }).Skip(2);
        //    Console.WriteLine("All but First 2 order in Seattle :");
        //    foreach(var orde in query)
        //    {
        //        Console.WriteLine("City : {0} Order ID : {1} Order Date : {2:d}",
        //            orde.City, orde.OrderID, orde.OrderDate);
        //    }

        //2. Take 
        //public void Takke()
        //{
        //    String city = "Seattle";
        //    var adress = con.Address;
        //    var orders = con.SalesOrderHeader;

        //    var query = (from addres in adress
        //                 from order in orders
        //                 where addres.AddressID == order.Address.AddressID
        //                 && addres.City == city
        //                 select new
        //                 {
        //                     City = addres.City,
        //                     OrderID = order.SalesOrderID,
        //                     OrderDate = order.OrderDate
        //                 }).Take(3);
        //    foreach (var orderr in query)
        //    {
        //        Console.WriteLine("City : {0} Order ID : {1} Order Date : {2:d}",
        //           orderr.City, orderr.OrderID, orderr.OrderDate );
        //    }
        //}
   }
}
