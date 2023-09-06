using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.factoryDesignPattern.employee
{
    public class EmployeeFactory
    {
        // this class has a resposbillity to reate object 

        public IEmployee createEmployee(string type)
        {
            switch(type)
            {
                case "AndroidDev": return new AndroidDev();
                    break;
                case "WebDev": return new WebDev();
                    break;
                default: return null;

            }
        }
    }
}
