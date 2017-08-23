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
    class Element
    {
        public AdventureWorks2014Entities con = new AdventureWorks2014Entities();

        //1.First
        public void First()
        {
            string name = "caroline";
            var email = con.EmailAddress;

            var query = email.First(em => em.EmailAddress1.StartsWith(name));

            Console.WriteLine("An email address starts with 'Caroline' : {0}", query.EmailAddress1);


        }
    }
}
