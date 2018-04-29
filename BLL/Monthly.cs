using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Monthly: Salary
    {
        public int calculatedAnnualSalary(int salary)
        {
            return salary * 12;
        }
    }
}
