using NUnit.Framework;
using RevenueValuation.Data.Repositories.Interfaces;
using RevenueValuation.Service.Implementation.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevenueValuation.Tests.Service.Employee
{
    [TestFixture]
    public class EmployeeServiceTest
    {
        private readonly EmployeeService _employeeService;
        IEmployeeRepository employeeRepository;//mocked

        public EmployeeServiceTest()
        {
            _employeeService = new EmployeeService(employeeRepository);
        }

        [Test]
        public void GetEmployyeResultTest()
        {
            
        }
    }
}
