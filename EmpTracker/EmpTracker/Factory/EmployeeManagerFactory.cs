using EmployeeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpTracker.Factory
{
    public class EmployeeManagerFactory
    {
        public BaseEmpFactory CreateFactory(EmployeeModel emp)
        {
            BaseEmpFactory returnValue = null;
            if (emp.contractTypeName.Equals("MonthlySalaryEmployee"))
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }
            else if (emp.contractTypeName.Equals("HourlySalaryEmployee"))
            {
                returnValue = new ContractEmployeeFactory(emp);
            }
            return returnValue;
        }
    }

}