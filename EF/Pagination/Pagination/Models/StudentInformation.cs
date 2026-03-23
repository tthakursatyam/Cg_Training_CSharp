using System;
using System.Collections.Generic;

namespace Pagination.Models;

public partial class StudentInformation
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? City { get; set; }

    public string? FatherName { get; set; }

    public string? Email { get; set; }

    public string? MobileNumber { get; set; }

    public string? ImagePath { get; set; }
}
