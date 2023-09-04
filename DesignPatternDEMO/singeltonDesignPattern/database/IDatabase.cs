using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.singeltonDesignPattern.database
{
    public  interface IDatabase
    {
        string connection();
        string databaseName();
       
        string databaseType();

        string databasePassword();
        string databaseUsername();
    }
}
