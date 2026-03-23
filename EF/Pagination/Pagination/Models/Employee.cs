using System;
using System.Collections.Generic;

namespace Pagination.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }
}
