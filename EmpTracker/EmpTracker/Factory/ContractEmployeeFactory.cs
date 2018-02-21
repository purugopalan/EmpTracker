using EmployeeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpTracker.Factory
{
    public class ContractEmployeeFactory : BaseEmpFactory
    {
        public ContractEmployeeFactory(EmployeeModel emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.annualSalary = manager.GetPay(_emp);
            return manager;
        }
    }
}