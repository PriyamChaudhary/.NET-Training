using System;
using System.Collections.Generic;

namespace MvcCore_DbFirstApproach.Models;

public partial class Employee
{
    public int EmpNo { get; set; }

    public string? Ename { get; set; }

    public int? Mgr { get; set; }

    public int? Salary { get; set; }

    public int? DeptNo { get; set; }

    public virtual Department? DeptNoNavigation { get; set; }
}
