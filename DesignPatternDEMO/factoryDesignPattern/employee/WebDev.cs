using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.factoryDesignPattern.employee
{
    internal class WebDev : IEmployee
    {
        public float salary()
        {
            Console.WriteLine("WEB APP DEVELOPER");

            return 45000;
        }
    }
}
