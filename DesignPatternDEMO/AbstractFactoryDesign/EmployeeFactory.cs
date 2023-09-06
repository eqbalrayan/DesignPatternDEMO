using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.AbstractFactoryDesign
{
    public  class EmployeeFactory
    {

        public IEmployee GetEmployee(EmployeeAbstractFactory factory)
        {
           return factory.createEmployee();
        }
    }
}
