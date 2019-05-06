using RevenueValuation.Data.Repositories.Interfaces;
using RevenueValuation.Model.ViewModel;
using RevenueValuation.Service.Interfaces.Employee;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevenueValuation.Service.Implementation.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public List<EmployeeViewModel> GetActiveEmployees()
        {
            List<RevenueValuation.Model.Entities.Employee> employees =employeeRepository.GetAll();
            List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();
            foreach (var item in employees)
            {
                employeeViewModels.Add(new EmployeeViewModel (){
                EmployeeId = item.EmployeeId,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Title = item.Title
                });
            };
            return employeeViewModels;
        }

        public RunInfo GetRunInfo(Run run)
        {
            return new RunInfo
            {
                Status = "Started"
            };
        }
    }
}
