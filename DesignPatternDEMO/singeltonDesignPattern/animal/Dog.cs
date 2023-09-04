using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.singeltonDesignPattern.animal
{
    public class Dog : Animal
    {
        private static Dog dog = null;
        private static readonly object _lock = new object();

        public static Animal _dog()
        {

            lock (_lock)
            {
                if(dog == null)
                {
                    dog = new Dog();
                }
            }
            return dog;

        }
        private Dog() { }
        public void run()
        {
            Console.WriteLine("Dog is running");
        }

        public void sleep()
        {
            Console.WriteLine("Dog is sleepping");   
        }
    }
}
