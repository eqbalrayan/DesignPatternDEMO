using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.factoryDesignPattern.database
{
    public   interface IDatabse
    {
        string connection();
        string qury();
        string update();
        string delete();
    }
}
