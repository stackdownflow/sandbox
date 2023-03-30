using Microsoft.EntityFrameworkCore;
using sandbox.Framework.DTO;
using sandbox.Repository.Context;
using sandbox.Repository.Entities;
using System.Data;

namespace sandbox.Framework.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        protected AppDbContext _appDbContext { get; set; }
        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<EmployeeDTO> GetEmployeesV1()
        {
            List<EmployeeDTO> result = new List<EmployeeDTO>();

            var queryResult = _appDbContext.Set<Employee>().AsNoTracking().Include(x => x.RoleRole);//LINQ Query using LAMBDA Expression

            foreach (var item in queryResult)
            {
                result.Add(new EmployeeDTO()
                {
                    EmpId = item.EmpId,
                    Email = item.Email,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    RoleName = item.RoleRole.RoleName,
                    Salary = item.Salary
                });
            }

            return result;
        }

        public IEnumerable<EmployeeDTO> GetEmployeesV2()
        {
            var result = (from employee in _appDbContext.Set<Employee>() //LINQ Query using SQL Type Syntax
                          join role in _appDbContext.Set<Role>()
                         on employee.RoleRoleId equals role.RoleId
                          select new EmployeeDTO()
                          {
                              EmpId = employee.EmpId,
                              Email = employee.Email,
                              FirstName = employee.FirstName,
                              LastName = employee.LastName,
                              RoleName = role.RoleName,
                              Salary = employee.Salary
                          });

            if (result != null)
                return result;
            else
                return new List<EmployeeDTO>();
        }

        public EmployeeDTO GetEmployeeByEmpIdV1(int EmpId)
        {
            var result = _appDbContext.Set<Employee>().Include(x => x.RoleRole).Where(x => x.EmpId == EmpId).FirstOrDefault(); //LINQ Query using LAMBDA Expression

            if (result != null)
                return new EmployeeDTO()
                {
                    EmpId = result.EmpId,
                    Email = result.Email,
                    FirstName = result.FirstName,
                    LastName = result.LastName,
                    RoleName = result.RoleRole.RoleName,
                    Salary = result.Salary
                };
            else
                return new EmployeeDTO();
        }

        public EmployeeDTO GetEmployeeByEmpIdV2(int EmpId)
        {
            var result = (from employee in _appDbContext.Set<Employee>() //LINQ Query using SQL Type Syntax
                          join role in _appDbContext.Set<Role>()
                         on employee.RoleRoleId equals role.RoleId
                          where employee.EmpId == EmpId
                          select new EmployeeDTO()
                          {
                              EmpId = employee.EmpId,
                              Email = employee.Email,
                              FirstName = employee.FirstName,
                              LastName = employee.LastName,
                              RoleName = role.RoleName,
                              Salary = employee.Salary
                          }).SingleOrDefault();

            if (result != null)
                return result;
            else
                return new EmployeeDTO();
        }
    }
}
