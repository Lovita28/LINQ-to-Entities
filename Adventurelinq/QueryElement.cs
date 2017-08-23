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
    class QueryElement
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1.First
        public void First()
        {
            string firstname = "Brooke";

            var persons = con.Person;

            var query = (from person in persons
                         where person.FirstName == firstname
                         select person).First();
            Console.WriteLine("FirstName :{0}" + query.FirstName);
            Console.WriteLine("LastName : {0}" + query.LastName);
        }
    }
}
