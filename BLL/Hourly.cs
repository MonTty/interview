using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class Hourly: Salary
    {
        public int calculatedAnnualSalary(int salary)
        {
            return 120 * salary * 12;
        }
    }
}
