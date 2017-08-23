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
    class Program
    {
        static void Main(string[] args)
        {
            //1. Filtering
            //Filtering fill = new Filtering();
            // fill.Cetak();
            //fill.Minmax();
            //fill.Warna();
            // fill.tanggal();
            // fill.Termasuk();
            // fill.Ukuran();

            //2. Ordering
            //Ordering ord = new Ordering();
            //ord.OrderThen();
            //ord.Desc();

            //3.Aggregate
            //Aggregate agg = new Aggregate();
            //agg.Average();
            // agg.Avelist();
            //agg.Avtotaldue();
            //agg.AvgById();
            //agg.AvgCon();
            //agg.Count();
            //agg.Countt();
            //agg.LongCount();
            //agg.Max();
            // agg.Min();
            //agg.Sum();

            //4.Partitioning
            //Partitioning part = new Partitioning();
            //part.Skip();
            //part.SkipII();
            //part.Take();
            //part.TakeAdres();

            //5. Conversion
            //Conversion conv = new Conversion();
            //conv.ToArray();
            //conv.ToDicti();
            //conv.ToList();

            //6.Join Operator
            //Join jou = new Join();
            ////jou.GroupJoin
            //jou.Joinn();

            //7.Element Operator
            //Element ell = new Element();
            //ell.First();

            //8. Grouping
            //Grouping grou = new Grouping();
            //grou.GrooupI();
            // grou.GroupII();
            //grou.GroudIII();

            //9.Relationship
            //Relationship relasi = new Relationship();
            //relasi.Exx();
            //relasi.exxi();
            //relasi.exxii();
            //relasi.exxiii();
            //relasi.exxiiii();

            //II Query LINQ to entities
            //1. Projection
            //QueryProjection pro = new QueryProjection();
            //pro.selectt();
            //pro.Name();
            //pro.prodname();
            // pro.fromII();
            // pro.frommany();

            //2. Filtering
            //QueryFiltering filter = new QueryFiltering();
            // filter.whereOnline();
            //filter.Whereminmax();
            //filter.color();
            //filter.date();
            //filter.WhereContain();
            //filter.WhereII();

            //3.Ordering
            //QueryOrdering orderr = new QueryOrdering();
            //orderr.OrLast();
            //orderr.LengthLast();
            //orderr.Ordesc();
            // orderr.Thenby();
            // orderr.ThenbyDesc();

            //4. Aggregate
            //QueryAggregate agre = new QueryAggregate();
            //agre.Average();
            // agre.AverageII();
            //agre.AvgIII();
            // agre.Countt();
            //agre.Countcc();
            //agre.MaxTot();
            //agre.MaxII();
            //agre.Minn();
            //agre.Minnn();
            //agre.Summ();

            //5.Partitioning
            //QueryPartitioning part = new QueryPartitioning();
            //part.Skiip();
            //part.Takke();

            //6. Join
            //QueryJoin joy = new QueryJoin();
            //joy.GroupI();
            //joy.GroupII();
            //joy.GroupIII();
            //joy.JoinD();

            //7.Element
            //QueryElement elle = new QueryElement();
            //elle.First();

            //8. Grouping
            //QueryGrouping goup = new QueryGrouping();
            //goup.ExI();
            //goup.ExII();
            //goup.ExIII();


            //1.Select
            //using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            //{
            //    var query = context.Product
            //        .Select(product => new
            //        {
            //            ProductId = product.ProductID,
            //            ProductName = product.Name
            //        });

            //    Console.WriteLine("Product Info:");
            //    foreach (var productInfo in query)
            //    {
            //        Console.WriteLine("Product Id: {0} Product name: {1} ",
            //            productInfo.ProductId, productInfo.ProductName);
            //    }
            //}

            //2.Select many
            //using (AdventureWorks2014Entities context = new AdventureWorks2014Entities())
            //{
            //    var contacts = context.Customer;
            //    var orders = context.SalesOrderHeader;

            //    var query =
            //    contacts.SelectMany(
            //        contact => orders.Where(order =>
            //            (contact.PersonID == order.CustomerID)
            //                && order.OrderDate >= new DateTime(2002, 10, 1))
            //            .Select(order => new
            //            {
            //                ContactID = contact.CustomerID,
            //                LastName = contact.Person.LastName,
            //                FirstName = contact.Person.FirstName,
            //                OrderID = order.SalesOrderID,
            //                OrderDate = order.OrderDate
            //            }));

            //    foreach (var order in query)
            //    {
            //        Console.WriteLine("Contact ID: {0} Name: {1}, {2} Order ID: {3} Order date: {4:d} ",
            //            order.ContactID, order.LastName, order.FirstName,
            //            order.OrderID, order.OrderDate);
            //    }
            //}
            
                Console.ReadKey();
        }
    }
}
