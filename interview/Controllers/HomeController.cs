using System.Web.Mvc;
using BLL;

namespace interview.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetEmployeeInfo(int? employeeId)
        {
             BLL.SalaryFactory factory = new BLL.ConcreteSalaryFactory();
            var allEmployees = factory.GetAllEmployees();
            if (employeeId != null)
            {
                var SpecificEmployee = allEmployees.Find(x => x.Id == employeeId);
                if (SpecificEmployee != null)
                {
                    Salary getSalary = factory.GetTypeContract(SpecificEmployee.ContractTypeName);
                    if (SpecificEmployee.ContractTypeName == "HourlySalaryEmployee")
                    {
                        SpecificEmployee.AnnualSalary = getSalary.calculatedAnnualSalary(SpecificEmployee.HourlySalary);
                    }
                    else if (SpecificEmployee.ContractTypeName == "MonthlySalaryEmployee")
                    {
                        SpecificEmployee.AnnualSalary = getSalary.calculatedAnnualSalary(SpecificEmployee.MonthlySalary);
                    }
                    return Json(SpecificEmployee);
                } else
                {
                    return Json(false);
                }
            } else
            {
                foreach (var x in allEmployees)
                {
                    Salary getSalary = factory.GetTypeContract(x.ContractTypeName);
                    if (x.ContractTypeName == "HourlySalaryEmployee")
                    {
                        x.AnnualSalary = getSalary.calculatedAnnualSalary(x.HourlySalary);
                    }
                    else if (x.ContractTypeName == "MonthlySalaryEmployee")
                    {
                        x.AnnualSalary = getSalary.calculatedAnnualSalary(x.MonthlySalary);
                    }
                }
                return Json(allEmployees);
            }
        }
    }
}