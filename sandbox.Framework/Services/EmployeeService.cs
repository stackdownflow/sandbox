using sandbox.Framework.DTO;
using sandbox.Framework.Repository;

namespace sandbox.Framework.Services
{
    public class EmployeeService : IEmployeeService
    {
        protected IEmployeeRepository _employeeRepository { get; set; }
        public EmployeeService(IEmployeeRepository employeeRepository) 
        {
            _employeeRepository = employeeRepository;
        } 
        
        public List<EmployeeDTO> GetEmployeesV1()
        {
           return _employeeRepository.GetEmployeesV1().ToList();
        }

        public List<EmployeeDTO> GetEmployeesV2()
        {
            return _employeeRepository.GetEmployeesV2().ToList();
        }

        public EmployeeDTO GetEmployeeByEmpIdV1(int EmpId)
        {
            return _employeeRepository.GetEmployeeByEmpIdV1(EmpId);
        }

        public EmployeeDTO GetEmployeeByEmpIdV2(int EmpId)
        {
            return _employeeRepository.GetEmployeeByEmpIdV2(EmpId);
        }
    }
}
