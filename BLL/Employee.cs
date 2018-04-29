using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Employee
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public string RoleName { get; set; }
        public int HourlySalary { get; set; }
        public int MonthlySalary { get; set; }
        public int AnnualSalary { get; set; }
    }
}
