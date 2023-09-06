using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.factoryDesignPattern.employee
{
    public class AndroidDev : IEmployee
    {
        public float salary()
        {
            Console.WriteLine("Android Developer ");

            return 42000;
        }
    }
}
