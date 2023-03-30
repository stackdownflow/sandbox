using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandbox.Framework.DTO
{
    public class EmployeeDTO
    {
        public int EmpId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string RoleName { get; set; }

        public int Salary { get; set; }
    }
}
