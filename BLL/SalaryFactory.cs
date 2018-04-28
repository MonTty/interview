using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    abstract class SalaryFactory
    {
        public enum TypeContract { Hourly, Monthly }
        public abstract Salary GetTypeContract(TypeContract typeContract);
    }
}
