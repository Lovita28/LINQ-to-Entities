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
    class QueryGrouping
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1.Example 1
        //public void ExI()
        //{
        //    var query = from adress in con.Address
        //                group adress by adress.PostalCode
        //                into AdresGroup
        //                select new
        //                {
        //                    PostalCode = AdresGroup.Key,
        //                    AddressLine = AdresGroup
        //                };
        //    foreach (var adresgr in query)
        //    {
        //        Console.WriteLine("Postal Code {0} : ", adresgr.PostalCode);
        //        foreach (var grouup in adresgr.AddressLine)
        //        {
        //            Console.WriteLine(grouup.AddressLine1 + "," + grouup.AddressLine2);
        //        }
        //    }
        //}

        //2. Example 2
        //public void ExII()
        //{
        //    var query = (from persons in con.Person
        //                group persons by persons.LastName.Substring(0, 1)
        //                into personGroup
        //                select new
        //                {
        //                    FirstLetter = personGroup.Key,
        //                    Names = personGroup,
        //                }).OrderBy(letter => letter.FirstLetter);
        //    foreach (var person in query)
        //    {
        //        Console.WriteLine("Last Name that start with letter {0} : ",person.FirstLetter);
        //        foreach (var conn in person.Names)
        //        {
        //            Console.WriteLine(conn.LastName);
        //        }
        //    }
        //}

        //3.Example 3
        public void ExIII()
        {
            var query = from order in con.SalesOrderHeader
                        group order by order.CustomerID
                        into idGroup
                        select new
                        {
                            CustomerID = idGroup.Key,
                            OrderCount = idGroup.Count(),
                            Sales = idGroup
                        };
            foreach (var orde in query)
            {
                Console.WriteLine("Customer ID : {0}", orde.CustomerID);
                Console.WriteLine("Order Count : {0}", orde.OrderCount);
                foreach (var grroup in orde.Sales)
                {
                    Console.WriteLine("    Sale id : {0}", grroup.SalesOrderID);
                }

                Console.WriteLine("");
            }
        }
    }
}
