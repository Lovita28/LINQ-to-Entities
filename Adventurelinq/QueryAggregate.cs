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
    class QueryAggregate
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1.Average
        public void Average()
        {
            var query = from prod in con.Product
                        group prod by prod.Style into g
                        select new
                        {
                            Style = g.Key,
                            Average = g.Average(product => product.ListPrice)
                        };
            foreach (var avg in query)
            {
                Console.WriteLine("Product Style : {0} Average List Price : {1}",
                    avg.Style, avg.Average);
            }
        }

        //2. AverageII
        public void AverageII()
        {
            var orders = con.SalesOrderHeader;

            var query = from ord in orders
                        group ord by ord.SalesPersonID
                        into g
                        select new
                        {
                            PersonID = g.Key,
                            avgTotalDue = g.Average(order => order.TotalDue)
                        };
            foreach (var order in query)
            {
                Console.WriteLine(" Contact ID : {0} \t Average Total Due : {1}",
                    order.PersonID, order.avgTotalDue);
            }
        }

        //3. AverageIII
        public void AvgIII()
        {
            var orders = con.SalesOrderHeader;

            var query = from ord in orders
                        group ord by ord.SalesPersonID
                        into g
                        let AverageTotalDue = g.Average(order => order.TotalDue)
                        select new
                        {
                            Category = g.Key,
                            CheapestProduct = g.Where(order => order.TotalDue == AverageTotalDue)
                        };
            foreach (var orderGroup in query)
            {
                Console.WriteLine("Contact ID : {0}", orderGroup.Category);
                foreach (var ordd in orderGroup.CheapestProduct)
                {
                    Console.WriteLine("Average Total Due for Sales ID {1} is : {0}",
                        ordd.TotalDue, ordd.SalesOrderID);
                }
            }
        }

       // 4.count
        public void Countt()
        {
            var custom = con.Customer;

            var query = from order in custom
                        select new
                        {
                            CustomerID = order.CustomerID,
                            OrderCount = order.SalesOrderHeader.Count()
                        };
            foreach (var cus in query)
            {
                Console.WriteLine("Customer Id : {0} \t Order Count : {1}",
                    cus.CustomerID, cus.OrderCount);
            }
        }

        //5.Count color
        public void Countcc()
        {
            var products = con.Product;

            var query = from prod in products
                        group prod by prod.Color into g
                        select new { Color = g.Key, ProductCount = g.Count() };
            foreach (var prod in query)
            {
                Console.WriteLine("Color : {0} \t Product Count : {1}",
                    prod.Color, prod.ProductCount);
            }
        }

        //6. MAX
        public void MaxTot()
        {
            var orders = con.SalesOrderHeader;

            var query =
                from order in orders
                group order by order.SalesPersonID into g
                select new
                {
                    Category = g.Key,
                    maxTotalDue =
                        g.Max(order => order.TotalDue)
                };

            foreach (var order in query)
            {
                Console.WriteLine("ContactID = {0} \t Maximum TotalDue = {1}",
                    order.Category, order.maxTotalDue);
            }
        }

        //7. Max each ID
        public void MaxII()
        {
            var orders = con.SalesOrderHeader;

            var query = from order in orders
                        group order by order.CustomerID
                        into g
                        let maxTotalDue = g.Max(orde => orde.TotalDue)
                        select new
                        {
                            Category = g.Key,
                            CheaperstProduct = g.Where(order => order.TotalDue == maxTotalDue)
                        };
            foreach (var ord in query)
            {
                Console.WriteLine("Customer ID : {0}", ord.Category);
                foreach (var order in ord.CheaperstProduct)
                {
                    Console.WriteLine("Max Total Due {0} for Sales Person ID {1}:",
                        order.TotalDue, order.SalesPersonID);
                }
            }
        }

        //8. Min
        public void Minn()
        {
            var orders = con.SalesOrderHeader;

            var query = from order in orders
                        group order by order.SalesPersonID
                        into g
                        select new
                        {
                            Category = g.Key,
                            SmallestProduct = g.Min(order => order.TotalDue)
                        };
            foreach (var small in query)
            {
                Console.WriteLine("Contact ID : {0} \t Minimum Total Due : {1}",
                    small.Category, small.SmallestProduct);
            }
        }

        //9.min each contact
        public void Minnn()
        {
            var orders = con.SalesOrderHeader;

            var query = from order in orders
                        group order by order.CustomerID
                        into g
                        let smallTotalDue = g.Min(order => order.TotalDue)
                        select new
                        {
                            Category = g.Key,
                            MinTotalDue = g.Where(order => order.TotalDue == smallTotalDue)
                        };
            foreach (var ord in query)
            {
                Console.WriteLine("Customer ID : {0}", ord.Category);
                foreach (var order in ord.MinTotalDue)
                {
                    Console.WriteLine("Minimun Total Due {0} for Sales Person ID {1}:",
                        order.TotalDue, order.SalesPersonID);
                }
            }
        }

        //10.Sum
        public void Summ()
        {
            var orders = con.SalesOrderHeader;

            var query = from order in orders
                        group order by order.SalesPersonID
                        into g
                        select new
                        {
                            Category = g.Key,
                            sumTotal = g.Sum(order => order.TotalDue)
                        };
            foreach (var ord in query)
            {
                Console.WriteLine("Contact Id : {0} \t Sum Total Due : {1}",
                    ord.Category, ord.sumTotal);
            }
        }
    }
}
