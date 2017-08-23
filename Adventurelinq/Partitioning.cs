using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurelinq
{
    class Partitioning
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1.Skip
        //public void Skip()
        //{
        //    IOrderedQueryable<Product> products = con.Product.OrderBy(p => p.ListPrice);

        //    IQueryable<Product> allButFirst3Product = products.Skip(3);

        //    Console.WriteLine("All but First 3 Product:");
        //    foreach(Product prod in allButFirst3Product)
        //    {
        //        Console.WriteLine("Name : {0} \t ID : {1}",
        //            prod.Name, prod.ProductID);
        //    }
        //}

        //2. SKIP II
        //public void SkipII()
        //{
        //    var adress = con.Address;
        //    var order = con.SalesOrderHeader;

        //    var query = (from adres in adress
        //                 from ord in order
        //                 where adres.AddressID == ord.Address.AddressID && adres.City == "Seattle"
        //                 orderby ord.SalesOrderID
        //                 select new
        //                 {
        //                     City = adres.City,
        //                     OrderId = ord.SalesOrderID,
        //                     OrderDate = ord.OrderDate
        //                 }).Skip(2);
        //    Console.WriteLine("All but first 2 orders in Seattle:");
        //    foreach(var orr in query)
        //    {
        //        Console.WriteLine(" City : {0} Order ID :{1} Order Date : {2:d}",
        //            orr.City, orr.OrderId, orr.OrderDate);
        //    }
        //}

        //3.Take 
        //public void Take()
        //{
        //    IQueryable<Person> first5pers = con.Person.Take(5);

        //    Console.WriteLine("First 5 Contact : ");
        //    foreach (Person pers in first5pers)
        //    {
        //        Console.WriteLine("Title = {0} \t First Name = {1} \t Last Name = {2}",
        //            pers.Title, pers.FirstName, pers.LastName);
        //    }
        //}

        //4. Take Address
        public void TakeAdres()
        {
            String city = "Seattle";
            var adress = con.Address;
            var order = con.SalesOrderHeader;

            var query = (
                        from address in adress
                        from orde in order
                        where address.AddressID == orde.Address.AddressID
                             && address.City == city
                        select new
                        {
                            City = address.City,
                            OrderID = orde.SalesOrderID,
                            OrderDate = orde.OrderDate
                        }).Take(3);
            Console.WriteLine("First 3 order in Seattle :");
            foreach (var ordres in query)
            {
                Console.WriteLine(" City : {0} Order ID : {1} Total Due : {2:d}",
                    ordres.City, ordres.OrderID, ordres.OrderDate);
            }
        }
    }
}
