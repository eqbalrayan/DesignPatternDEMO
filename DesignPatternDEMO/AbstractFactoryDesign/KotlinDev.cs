using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.AbstractFactoryDesign
{
    public class KotlinDev : IEmployee
    {
        public string name()
        {
            Console.WriteLine("KotlinDev");  
            
            return string.Empty;
        }

        public float salary()
        {
            Console.WriteLine("Rs55000");
            return 55000;
        }
    }
}
