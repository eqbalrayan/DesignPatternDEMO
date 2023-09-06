using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.AbstractFactoryDesign
{
    public class MicrosoftDev : IEmployee
    {
        public string name()
        {
            Console.WriteLine("");
            return "";
        }

        public float salary()
        {
            Console.WriteLine("salary : 34500");
            return 34500;
        }
    }
}
