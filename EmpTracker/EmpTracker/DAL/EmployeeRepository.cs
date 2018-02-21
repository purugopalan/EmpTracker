using EmployeeTracker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace EmployeeTracker.DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static string 
            baseUrl = "http://masglobaltestapi.azurewebsites.net/api/Employees/"; //To be moved to config.

        public async Task<List<EmployeeModel>> GetEmployeeAsync(int empId)
        { 
            var empString = await GetStringAsync(baseUrl);
            //  Newtonsoft.Json to deserialize JSON string to User object
            var emp = JsonConvert.DeserializeObject<List<EmployeeModel>>(empString);
            return emp;
        }

        private static async Task<string> GetStringAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync(url);
            }
        }

       
    }
}