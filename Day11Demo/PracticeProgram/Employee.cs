using System;

namespace PracticeProgram;

public class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public int EmpSalary { get; set; }
    
    public Employee(int empId, string empName, int empSalary)
    {
        EmpId = empId;
        EmpName = empName;
        EmpSalary = empSalary;
    }
    


}
