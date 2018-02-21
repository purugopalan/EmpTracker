using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeTracker.DAL;
using System.Collections.Generic;
using EmployeeTracker.Models;
using EmpTracker.Factory;

namespace EmpTracker.Tests
{
    [TestClass]
    public class EmpTrackerTest
    {
        [TestMethod]
        public void   TestMethod1()
        {

            EmployeeRepository employee = new EmployeeRepository();
            // Assert
            Assert.IsNotNull(employee);
        }

        [TestMethod]
        public void TestMethodForCalculateAnnualSalary()
        {

            //Create test employee object

            EmployeeModel selectedEmployee = new EmployeeModel();
            selectedEmployee.id = 1;
            selectedEmployee.hourlySalary = 80;
            selectedEmployee.contractTypeName = "HourlySalaryEmployee";

            BaseEmpFactory baseEmpFactory; //Instantiate factory class           

            baseEmpFactory = new EmployeeManagerFactory().CreateFactory(selectedEmployee);
            baseEmpFactory.ApplySalary();

            decimal localAnualLogic = 120 * selectedEmployee.hourlySalary * 12;

            // Assert
            Assert.IsNotNull(selectedEmployee);
            Assert.AreEqual(localAnualLogic, actual: selectedEmployee.annualSalary);


        }
    }
}
