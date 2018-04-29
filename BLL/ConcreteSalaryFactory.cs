using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using DAL;
using System.Linq;

namespace BLL
{
    public class ConcreteSalaryFactory: SalaryFactory
    {
        public override List<Employee> GetAllEmployees()
        {
            Api api = new Api();
            JArray jEmployees = api.Get("employees");
            return jEmployees.ToObject < List<Employee>>();
        }

        public override Salary GetTypeContract(string typeContract)
        {
            switch (typeContract)
            {
                case "HourlySalaryEmployee":
                    return new Hourly();
                case "MonthlySalaryEmployee":
                    return new Monthly();
                default:
                    throw new ApplicationException(string.Format("Calcualted '{0}' cannot be created", typeContract));
            }
        }
    }
}
