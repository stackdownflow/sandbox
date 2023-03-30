using sandbox.Framework.DTO;

namespace sandbox.Framework.Services
{
    public interface IEmployeeService
    {
        public List<EmployeeDTO> GetEmployeesV1();
        public List<EmployeeDTO> GetEmployeesV2();
        public EmployeeDTO GetEmployeeByEmpIdV1(int EmpId);    
        public EmployeeDTO GetEmployeeByEmpIdV2(int EmpId);
    }
}
