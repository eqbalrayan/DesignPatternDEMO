using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.AbstractFactoryDesign
{
     abstract public class EmployeeAbstractFactory
    {
        abstract public IEmployee createEmployee();
    }
}
