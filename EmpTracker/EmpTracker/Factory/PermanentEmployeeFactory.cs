using EmployeeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpTracker.Factory
{
    public class PermanentEmployeeFactory : BaseEmpFactory

    {
        public PermanentEmployeeFactory(EmployeeModel emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.annualSalary = manager.GetPay(_emp);
            return manager;
        }
    }
}