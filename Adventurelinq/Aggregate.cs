using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurelinq
{
    class Aggregate
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1. Average
        //public void Average()
        //{
        //    var product = con.Product;

        //    Decimal AvgListPrice = product.Average(prod => prod.ListPrice);

        //    Console.WriteLine("The average list price of all product is ${0}",
        //        AvgListPrice);
        //}

        //2.Average each style
        //public void Avelist()
        //{
        //    var product = con.Product;

        //    var query = from prod in product
        //                group prod by prod.Style into g
        //                select new
        //                {
        //                    Style = g.Key,
        //                    AveListPrice = g.Average(prod => prod.ListPrice)
        //                };
        //    foreach (var pro in query)
        //    {
        //        Console.WriteLine("Product Style : {0} Average List Price : {1}",
        //            pro.Style, pro.AveListPrice);
        //    }
        //}

        //3.Average Total Due
        //public void Avtotaldue()
        //{
        //    var order = con.SalesOrderHeader;

        //    Decimal AvgTotalDue = order.Average(ord => ord.TotalDue);
        //    Console.WriteLine("The Average Total Due is {0}.", AvgTotalDue);
        //}

        //4.Average by ID
        //public void AvgById()
        //{
        //    var orders = con.SalesOrderHeader;

        //    var query = from order in orders
        //                group order by order.SalesPersonID into g
        //                select new
        //                {
        //                    Category = g.Key,
        //                    AvgTotalDue = g.Average(order => order.TotalDue)
        //                };
        //    foreach (var ord in query)
        //    {
        //        Console.WriteLine("Contact ID : {0} \t Average Total Due = {1}",
        //            ord.Category, ord.AvgTotalDue);

        //    }     
        //}

        //5. Avg by Contact 
        //public void AvgCon()
        //{
        //    var orders = con.SalesOrderHeader;

        //    var query = from order in orders
        //                group order by order.SalesPersonID into g
        //                let avgTotalDue = g.Average(order => order.TotalDue)
        //                select new
        //                {
        //                    Category = g.Key,
        //                    CheapesProd = g.Where(order => order.TotalDue == avgTotalDue)
        //                };
        //    foreach (var orde in query)
        //    {
        //        Console.WriteLine("Contact ID : {0}", orde.Category);
        //        foreach (var ord in orde.CheapesProd)
        //        {
        //            Console.WriteLine("Average Total due for Sales OrderID {1} is : {0}",
        //                ord.TotalDue, ord.SalesOrderID);
        //        }
        //        Console.WriteLine("\n");
        //    }
        //}

        //6.Count 
        //public void Count()
        //{
        //    var product = con.Product;

        //    int numProduct = product.Count();

        //    Console.WriteLine("There are {0} products ", numProduct);
        //}

        //7. Cound II
        //public void Countt()
        //{
        //    var product = con.Product;

        //    var query = from prod in product
        //                group prod by prod.Color into g
        //                select new
        //                {
        //                    Color = g.Key,
        //                    ProdCount = g.Count()
        //                };
        //    foreach(var pro in query)
        //    {
        //        Console.WriteLine("Color = {0} \t Product Count = {1}",
        //            pro.Color, pro.ProdCount);

        //    }

        //}

        //8.Long Count 
        //public void LongCount()
        //{
        //    var pers = con.Person;

        //    long number = pers.LongCount();

        //    Console.WriteLine("There are {0} Person", number);

        //}

        //9.MAX 
        //public void Max()
        //{
        //    var order = con.SalesOrderHeader;

        //    Decimal maxTotalDue = order.Max(w => w.TotalDue);
        //    Console.WriteLine("The Maximum Total Due is : {0}", maxTotalDue);

        //}

        //10.Min 
        //public void Min()
        //{
        //    var order = con.SalesOrderHeader;

        //    Decimal smallTotalDue = order.Min(m => m.TotalDue);
        //    Console.WriteLine("The Smallest Total Due is {0}", smallTotalDue);

        //}

        //11.SUM
        //public void Sum()
        //{
        //    var order = con.SalesOrderDetail;

        //    double totalOrder = order.Sum(s => s.OrderQty);
        //    Console.WriteLine("There are total {0} OrderQty", totalOrder);

        //}
    }
}
