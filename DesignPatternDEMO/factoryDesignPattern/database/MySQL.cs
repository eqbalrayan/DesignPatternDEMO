using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.factoryDesignPattern.database
{
    public class MySQL : IDatabse
    {
        public string connection()
        {
            Console.WriteLine("MYSql DB");

            return "connected."
        }

        public string delete()
        {
            Console.WriteLine("1 row is deleted");

            return "deleted";
        }

        public string qury()
        {
            Console.WriteLine("select * from employee where ename=?");

            return "employee name";
        }

        public string update()
        {
            Console.WriteLine("1 row updated");
            return "updated";
        }
    }
}
