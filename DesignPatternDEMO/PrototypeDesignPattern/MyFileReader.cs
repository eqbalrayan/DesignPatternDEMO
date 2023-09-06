using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.PrototypeDesignPattern
{
    public class MyFileReader : ICloneable
    {

        public object Clone()
        {
            return  this.MemberwiseClone();
        }

       
        
    }
}
