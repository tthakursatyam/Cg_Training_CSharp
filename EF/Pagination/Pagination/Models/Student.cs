using System;
using System.Collections.Generic;

namespace Pagination.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public float Age { get; set; }

    public string? City { get; set; }
}
