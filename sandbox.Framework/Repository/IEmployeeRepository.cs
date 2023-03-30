using sandbox.Framework.DTO;

namespace sandbox.Framework.Repository
{
    public interface IEmployeeRepository
    {
        public IEnumerable<EmployeeDTO> GetEmployeesV1();
        public IEnumerable<EmployeeDTO> GetEmployeesV2();
        public EmployeeDTO GetEmployeeByEmpIdV1(int EmpId);
        public EmployeeDTO GetEmployeeByEmpIdV2(int EmpId);

    }
}
