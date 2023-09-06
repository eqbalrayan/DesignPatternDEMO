using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.factoryDesignPattern.database
{
    public class Mogodb : IDatabse
    {
        public string connection()
        {
            Console.WriteLine("Connected with mongodb");
            return "connected";
        }

        public string delete()
        {
            Console.WriteLine("1 row deleted");

            return "deleted";
        }

        public string qury()
        {

            Console.WriteLine("select * from employee where empno=?");

            return "successful";
            
        }

        public string update()
        {
            Console.WriteLine("1 row updated");
            return "updated";
        }
    }
}
