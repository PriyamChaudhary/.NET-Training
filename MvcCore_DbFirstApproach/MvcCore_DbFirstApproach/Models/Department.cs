using System;
using System.Collections.Generic;

namespace MvcCore_DbFirstApproach.Models;

public partial class Department
{
    public int DeptNo { get; set; }

    public string? Dname { get; set; }

    public string? Location { get; set; }

    public int? NoOfEmp { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
