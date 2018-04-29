using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class SalaryFactory
    {
        public string contractTypeName;
        public abstract List<Employee> GetAllEmployees();
        public abstract Salary GetTypeContract(string typeContract);
    }
}
