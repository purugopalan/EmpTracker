using EmployeeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpTracker.Factory
{
    public interface IEmployeeManager
    {
        decimal GetPay(EmployeeModel emp);
    }
}