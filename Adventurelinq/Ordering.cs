using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurelinq
{
    class Ordering
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1.OrderBy and ThenBy
        //public void OrderThen()
        //{
        //    IQueryable<Person> sortedPerson = con.Person
        //        .OrderBy(c => c.LastName)
        //        .ThenBy(c => c.FirstName);

        //    Console.WriteLine("The list of Person sorted by last name then by first name:");
        //    foreach(Person sor in sortedPerson)
        //    {
        //        Console.WriteLine(sor.LastName + " , " + sor.FirstName);
        //    }
        //    Console.ReadKey();
        //}

        //2.ThenBy Descending
        public void Desc()
        {
            IOrderedQueryable<Product> query = con.Product
                .OrderBy(product => product.ListPrice)
                .ThenByDescending(product => product.Name);

            foreach (Product prod in query)
            {
                Console.WriteLine(" Product Id : {0} Product name : {1} List Price : {2}",
                    prod.ProductID, prod.Name, prod.ListPrice);
            }
        }
    }
}
