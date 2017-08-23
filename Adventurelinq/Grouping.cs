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
    class Grouping
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1. Example 1
        //public void GrooupI()
        //{
        //    var query = con.Address.GroupBy(address => address.PostalCode);
        //    foreach (IGrouping<string, Address> addressGroup in query)
        //    {
        //        Console.WriteLine("Postal Code: {0}", addressGroup.Key);
        //        foreach (Address address in addressGroup)
        //        {
        //            Console.WriteLine("\t" + address.AddressLine1 +
        //            address.AddressLine2);
        //        }
        //    }
        //}

        //2. Example 
        //public void GroupII()
        //{
        //    var query = con.Person
        //                .GroupBy(c => c.LastName.Substring(0, 1))
        //                .OrderBy(c => c.Key);

        //    foreach (IGrouping<string, Person> group in query)
        //    {
        //        Console.WriteLine("Last names that start with the letter '{0}':",
        //            group.Key);
        //        foreach (Person contact in group)
        //        {
        //            Console.WriteLine(contact.LastName);
        //        }

        //    }

        //}

        //3.Example 3
        //public void GroudIII()
        //{
        //    var query = con.SalesOrderHeader.GroupBy(order => order.CustomerID);

        //    foreach (IGrouping<int, SalesOrderHeader> group in query)
        //    {
        //        Console.WriteLine("Customer ID : {0}", group.Key);
        //        Console.WriteLine("Order Count : {0}", group.Count());
        //        foreach(SalesOrderHeader sale in group)
        //        {
        //            Console.WriteLine("  Sale ID : {0}", sale.SalesOrderID);
        //        }
        //        Console.WriteLine("");
        //    }
        //}
    }
}
