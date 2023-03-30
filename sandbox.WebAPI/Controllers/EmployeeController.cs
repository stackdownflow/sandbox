using Microsoft.AspNetCore.Mvc;
using sandbox.Framework.DTO;
using sandbox.Framework.Services;
using sandbox.Repository.Entities;

namespace sandbox.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService; 

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            _employeeService = employeeService;
        }

        [Route("GetEmployeesV1")]
        [HttpGet]
        public IEnumerable<EmployeeDTO> GetEmployeesV1()
        {
           return _employeeService.GetEmployeesV1();
        }

        [Route("GetEmployeesV2")]
        [HttpGet]
        public IEnumerable<EmployeeDTO> GetEmployeesV2()
        {
            return _employeeService.GetEmployeesV2();
        }

        [Route("GetEmployeeByEmpIdV1/{EmpId}/")]
        [HttpGet]
        public EmployeeDTO GetEmployeeByEmpIdV1(int EmpId)
        {
            return _employeeService.GetEmployeeByEmpIdV1(EmpId);
        }

        [Route("GetEmployeeByEmpIdV2/{EmpId}/")]
        [HttpGet]
        public EmployeeDTO GetEmployeeByEmpIdV2(int EmpId)
        {
            return _employeeService.GetEmployeeByEmpIdV2(EmpId);
        }
    }
}