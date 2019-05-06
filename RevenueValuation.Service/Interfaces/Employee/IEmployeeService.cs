using RevenueValuation.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RevenueValuation.Service.Interfaces.Employee
{
    public interface IEmployeeService
    {
        List<EmployeeViewModel> GetActiveEmployees();

        RunInfo GetRunInfo(Run run);
    }
}
