using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.singeltonDesignPattern.animal
{
    public class Cat : Animal
    {

       public static Animal getCat() { return new Cat(); }
        public void run()
        {
            Console.WriteLine("Cat is running"); 
        }

        public void sleep()
        {
           Console.WriteLine("Cat is sleepping");
        }
    }
}
