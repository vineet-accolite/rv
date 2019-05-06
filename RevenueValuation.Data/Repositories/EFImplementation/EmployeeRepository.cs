using RevenueValuation.Data.Repositories;
using RevenueValuation.Data.Repositories.Interfaces;
using RevenueValuation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevenueValuation.Data.EF.Repositories.EFImplementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAll()
        {
            //omce EF is integrated, it will get data from entity framework instead hard coded one
            return new List<Employee> { new Employee() { EmployeeId=1,FirstName="Vineet",LastName="Kumar",Title="Developer"} ,
            new Employee() { EmployeeId=2,FirstName="Hussam",LastName="Iamail",Title="Manager"} };
        }

        public Employee GetById(int id)
        {
            return new Employee() { EmployeeId = 2, FirstName = "Hussam", LastName = "Iamail", Title = "Manager" };
        }

        public bool Insert(Employee item)
        {
            throw new NotImplementedException();
        }

        public bool InsertMultiple(List<Employee> items)
        {
            throw new NotImplementedException();
        }
    }
}
