using EmployeeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpTracker.Factory
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetPay(EmployeeModel emp)
        {
            return 120 * emp.hourlySalary * 12;
        }
    }
}