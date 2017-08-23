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
    class Join
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1.Group Join
        //public void GroupJoin()
        //{
        //    var order = con.SalesOrderHeader;
        //    var detail = con.SalesOrderDetail;

        //    var query = order.GroupJoin(detail,
        //        ordr => ordr.SalesOrderID,
        //        detil => detil.SalesOrderID,
        //        (ordr, ordGroup) => new
        //        {
        //            CostumerID = ordr.SalesOrderID,
        //            OrderCount = ordGroup.Count()
        //        });
        //    foreach(var ordee in query)
        //    {
        //        Console.WriteLine("Customer ID : {0} Order Count : {1}",
        //            ordee.CostumerID, ordee.OrderCount);
        //    }
        //}

        //2. Group Join II
        //public void GroupJoinII()
        //{
        //    var customers = con.Customer;
        //    var orders = con.SalesOrderHeader;

        //    var query = customers.GroupJoin(orders,
        //        pers => pers.CustomerID,
        //        order => order.Customer.CustomerID,
        //        (pers, persGroup) => new
        //        {
        //            ContactID = pers.CustomerID,
        //            OrderCount = persGroup.Count(),
        //            orders = persGroup
        //        });
        //    foreach (var group in query )
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

        //3.Join 
        //public void Joinn()
        //{
        //    var products = con.Product;
        //    var details = con.SalesOrderDetail;

        //    var query = products.Join(
        //        details, detail => detail.ProductID,
        //        product => product.ProductID,
        //        (product, detail) => new
        //        {
        //            ProdID = product.ProductID,
        //            DetailID = detail.SalesOrderDetailID,
        //            ProdName = product.Name,
        //        });

        //    foreach (var group in query)
        //    {
        //            Console.WriteLine("Product ID : {0} Sales detail ID : {1} Product Name :{2}",
        //                group.ProdID, group.DetailID, group.ProdName);  
        //    }
        //}
    }
}
