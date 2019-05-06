using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RevenueValuation.Model.ViewModel;
using RevenueValuation.Service.Interfaces.Employee;


namespace RevenueValuation.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService employeeService;
        protected readonly ILogger<EmployeeController> _logger;
        public EmployeeController(IEmployeeService employeeService, ILogger<EmployeeController> _logger)
        {
            this.employeeService = employeeService;
            this._logger = _logger;
        }


        [HttpGet]
        [Produces(typeof(List<EmployeeViewModel>))]
        public ActionResult<IEnumerable<EmployeeViewModel>> Get()
        {
            _logger.LogInformation("Logging started");
            return employeeService.GetActiveEmployees();
        }

        [HttpPost]
        [Produces(typeof(RunInfo))]
        public ActionResult<RunInfo> GetRunInfo(Run run)
        {
            RunInfo info = employeeService.GetRunInfo(run);
            return info;            
        }       
    }
}