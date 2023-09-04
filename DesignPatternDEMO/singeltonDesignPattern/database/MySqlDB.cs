using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.singeltonDesignPattern.database
{
    public class MySqlDB : IDatabase
    {
        // class is singelton 

        private static MySqlDB instance = null;
        private static readonly object _lock=new object();
        private  MySqlDB() { }

        public static MySqlDB GetMySqlDB()
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new MySqlDB();
                }
            }
            return instance;
        }
        public string connection()
        {
            Console.WriteLine("connected with MySQL");
            return "MYSQL";
        }

        public string databaseName()
        {
            Console.WriteLine("MYSQL DATABASE");
            return "MYSQL";
        }

        public string databasePassword()
        {
            Console.WriteLine("Secured password : pwd123");

            return "secured password";
        }

        public string databaseType()
        {
            Console.WriteLine("RDBMS");
            return "RDBMS";
        }

        public string databaseUsername()
        {
            Console.WriteLine("username : tiger");

            return "tiger";
        }

       
    }
}
