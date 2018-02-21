using EmployeeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpTracker.Factory
{
    public abstract class BaseEmpFactory
    {
        protected EmployeeModel _emp;
        public BaseEmpFactory(EmployeeModel emp)
        {
            _emp = emp;
        }
        public EmployeeModel ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _emp.annualSalary = manager.GetPay(_emp);
            return _emp;
        }
        public abstract IEmployeeManager Create();
    }
}