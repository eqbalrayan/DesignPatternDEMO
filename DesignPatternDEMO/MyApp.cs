using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DesignPatternDEMO.singeltonDesignPattern;
using DesignPatternDEMO.singeltonDesignPattern.animal;
using DesignPatternDEMO.singeltonDesignPattern.database;

namespace DesignPatternDEMO
{
    public class MyApp
    {


        static void Main(string[] args)
        {

            // Singelton class
            /***
                Animal dog1 = Dog._dog();
                Animal dog2 = Dog._dog();
                Animal dog3= Dog._dog();
                Animal cat1 = Cat.getCat();
                Animal cat2= Cat.getCat();
                Animal cat3= Cat.getCat();

                Console.WriteLine(dog1.GetHashCode()+"  " + dog2.GetHashCode()+"  " + dog3.GetHashCode());
                Console.WriteLine(cat1.GetHashCode()+"  " + cat2.GetHashCode()+"  " + cat3.GetHashCode());
                dog1.run();
                cat1.sleep();
            ***/
            //database singelton class

            IDatabase db1 = MySqlDB.GetMySqlDB();
            IDatabase db2 = MySqlDB.GetMySqlDB();
            IDatabase db3 = new MongoDB();
            IDatabase db4= new MongoDB();

            db1.connection();
            db1.databaseName();
            db3.connection();
            db4.connection();
            db4.databaseName();

            Console.WriteLine(" " +  db1.GetHashCode() + " "+db2.GetHashCode()+" "+ "No Diffrence both are same object  ");
            Console.WriteLine(" " + db3.GetHashCode() + " " + db4.GetHashCode() +" "+ "they use different memory address. so both are different object ");

            Console.ReadLine();

            
        }
    }
}
