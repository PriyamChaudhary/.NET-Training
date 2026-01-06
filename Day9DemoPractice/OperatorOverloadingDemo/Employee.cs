using System;

namespace OperatorOverloadingDemo;

class Employee
{
    public int EmpId{get; set;}
    public string EmpName { get; set; }
    public int BSalary { get; set; }

    public static Employee operator+(Employee emp1, Employee emp2)
    {
        
        
    }
}
