using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventurelinq
{
    class Conversion
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1.ToArray
        //public void ToArray()
        //{
        //    var products = con.Product;

        //    Product[] prodArray = (
        //        from prod in products
        //        orderby prod.ListPrice descending
        //        select prod).ToArray();
        //    Console.WriteLine("Every Price from Height to Lowest :");
        //    foreach(var product in prodArray)
        //    {
        //        Console.WriteLine(product.ListPrice);
        //    }
        //}

        //2.ToDictionary
        //public void ToDicti()
        //{
        //    var products = con.Product;

        //    Dictionary<String, Product> scoreRecordDict = products
        //        .ToDictionary(record => record.Name);
        //    Console.WriteLine("Top Tube's ProductID : {0}",
        //        scoreRecordDict["Top Tube"].ProductID);

        //}

        //3. ToList
        //public void ToList()
        //{
        //    var products = con.Product;

        //    List<Product> query =
        //        (from prod in products orderby prod.Name select prod).ToList();
        //    Console.WriteLine("The product list , order by product name : ");
        //    foreach (var produ in query)
        //    {
        //        Console.WriteLine(produ.Name.ToLower(CultureInfo.InvariantCulture));
        //    }
        //}


    }
}
