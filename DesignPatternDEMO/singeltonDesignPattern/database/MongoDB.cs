using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.singeltonDesignPattern.database
{
    public class MongoDB : IDatabase
    {
        // Not a singelton class
        public string connection()
        {
            Console.WriteLine("Connected with MONGODB");
            return "Connected with mongodb";
        }

        public string databaseName()
        {
            Console.WriteLine("mongodb");
            return string.Empty;
        }

        public string databasePassword()
        {
            Console.WriteLine("secured password : pwd1234");
           return string.Empty;
        }

        public string databaseType()
        {
            throw new NotImplementedException();
        }

        public string databaseUsername()
        {
            Console.WriteLine("username : tiger");
            return string.Empty;
        }

       
    }
}
