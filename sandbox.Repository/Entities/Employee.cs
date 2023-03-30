using System;
using System.Collections.Generic;

namespace sandbox.Repository.Entities;

public partial class Employee
{
    public int EmpId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int RoleRoleId { get; set; }

    public int Salary { get; set; }

    public virtual Role RoleRole { get; set; } = null!;
}
