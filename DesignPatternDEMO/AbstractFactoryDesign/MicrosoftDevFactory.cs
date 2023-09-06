using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDEMO.AbstractFactoryDesign
{
    public class MicrosoftDevFactory : EmployeeAbstractFactory
    {
        public override IEmployee createEmployee()
        {
            return new MicrosoftDev();
        }
    }
}
