using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class ConcreteSalaryFactory: SalaryFactory
    {
        public override Salary GetTypeContract(TypeContract typeContract)
        {
            switch (typeContract)
            {
                case TypeContract.Hourly:
                    return new Hourly();
                case TypeContract.Monthly:
                    return new Monthly();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", typeContract));
            }
        }
    }
}
