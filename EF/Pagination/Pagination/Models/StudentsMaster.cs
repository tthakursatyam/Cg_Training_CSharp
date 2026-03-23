using System;
using System.Collections.Generic;

namespace Pagination.Models;

public partial class StudentsMaster
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? City { get; set; }
}
