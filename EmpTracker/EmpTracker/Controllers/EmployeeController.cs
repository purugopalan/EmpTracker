using EmployeeTracker.DAL;
using EmployeeTracker.Models;
using EmpTracker.Factory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmpTracker.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeRepository repository;
        public EmployeeController() { }
        public EmployeeController(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        // GET api/values
        public async System.Threading.Tasks.Task<IEnumerable<EmployeeModel>> GetAsync()
        {
            // Method has to be refactored, implement dependency injection and move out the following logic to differnt class, so that this can be unit testable
           
            try
            {
                EmployeeRepository employee = new EmployeeRepository();


                var empData = await employee.GetEmployeeAsync(1);


                BaseEmpFactory empFactory;
                foreach (var emp in empData)
                {
                    empFactory = new EmployeeManagerFactory().CreateFactory(emp);
                    empFactory.ApplySalary();
                }

                return empData;
                    
            }
            catch(Exception ex)
            {
                Console.Write(ex);
                return new List<EmployeeModel> { };
            }
        }

        // GET api/values/5
        public async System.Threading.Tasks.Task<IEnumerable<EmployeeModel>> GetAsync(int id)
        {
            try
            {

                // Method has to be refactored, implement dependency injection and move out the following logic to differnt class, so that this can be unit testable

                EmployeeRepository employee = new EmployeeRepository();


                var empData = await employee.GetEmployeeAsync(1);
                var selectedEmployee = empData.FirstOrDefault((p) => p.id == id);
                
                BaseEmpFactory empFactory;
               
                empFactory = new EmployeeManagerFactory().CreateFactory(selectedEmployee);
                empFactory.ApplySalary();
                List<EmployeeModel> lstEmpModel = new List<EmployeeModel>();
                lstEmpModel.Add(selectedEmployee);

                return lstEmpModel;

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                return new List<EmployeeModel> { };
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
