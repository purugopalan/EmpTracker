using EmployeeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EmployeeTracker.DAL
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeModel>> GetEmployeeAsync(int empID);
        
    }
}