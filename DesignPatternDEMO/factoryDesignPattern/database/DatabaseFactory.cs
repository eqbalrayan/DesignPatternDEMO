using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.factoryDesignPattern.database
{
    public class DatabaseFactory
    {
        /*  
         *  this class is responsible to create object of the class MySql or Mongodb super type
         *  
         * 
         * 
         * 
         */


        public IDatabse createDatabaseOb(string databaseName)
        {
            switch (databaseName) {

                case "mysql": return new MySQL();
                   
                case "mongodb": return new Mogodb();
                   
                default: return null;
            
            }
        }
    }
}
