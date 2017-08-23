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
    class QueryOrdering
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1.Order By : Last Name 
        //public void OrLast()
        //{
        //    IQueryable<Person> pers = from perss in con.Person
        //                              orderby perss.LastName
        //                              select perss;
        //    Console.WriteLine("The sorted list by Last Name:");
        //    foreach (Person p in pers)
        //    {
        //        Console.WriteLine(p.LastName);
        //    }
        //}

        //2.Order By : Length Last name 
        //public void LengthLast()
        //{
        //    IQueryable<Person> sorted = from pers in con.Person
        //                                orderby pers.LastName.Length
        //                                select pers;
        //    Console.WriteLine("Sorted name by Length of the Last name :");
        //    foreach (Person n in sorted)
        //    {
        //        Console.WriteLine(n.LastName);    
        //    }

        //}

        //3.Order By Descending
        //public void Ordesc()
        //{
        //    IQueryable<Decimal> desc = from descen in con.Product
        //                               orderby descen.ListPrice descending
        //                               select descen.ListPrice;
        //    Console.WriteLine("the list price from higher to lower:");
        //    foreach (Decimal descc in desc)
        //    {
        //        Console.WriteLine(descc);
        //    }
        //}

        //4. Then by
        //public void Thenby()
        //{
        //    IQueryable<Person> sorted = from sort in con.Person
        //                                orderby sort.LastName, sort.FirstName
        //                                select sort;
        //    Console.WriteLine("The list of person sort by Last Name then by First name :");
        //    foreach (Person nam in sorted)
        //    {
        //        Console.WriteLine(nam.LastName + "," + nam.FirstName);
        //    }
        //}

        //5. Then by Descending
        //public void ThenbyDesc()
        //{
        //    IQueryable<Product> prod = from pr in con.Product
        //                               orderby pr.Name, pr.ListPrice descending
        //                               select pr;
        //    foreach (Product sor in prod)
        //    {
        //        Console.WriteLine("Product ID : {0} Product Name : {1} List Price : {2}",
        //            sor.ProductID, sor.Name, sor.ListPrice);
        //    }
        //}
    }
}
