using EmployeeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpTracker.Factory
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetPay(EmployeeModel emp)
        {
            return emp.monthlySalary * 12;
        }
    }
}