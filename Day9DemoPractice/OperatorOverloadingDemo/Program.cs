using OperatorOverloadingDemo;

int num1=100;
int num2=200;

int numResult=num1+num2;

System.Console.WriteLine(numResult);

Employee emp1=new Employee();
emp1.EmpId=101;
emp1.EmpName="Alok";
emp1.BSalary=30000;

Employee emp2=new Employee();
emp2.EmpId=102;
emp2.EmpName="Riya";
emp2.BSalary=35000;

Employee empObj=emp1+emp2;
System.Console.WriteLine($"Total Salary paid {empObj.BSalary}");

MyLogic m1=new MyLogic();
