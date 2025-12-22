using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4OOPDemo
{
    class Employee
    {
        #region Properties
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        #endregion

        public virtual int CalcSalary(int sal)
        {
            int mySal = 0;
            //net salary=salary+HRA+TA+DA-PF
            mySal = (sal + 15000 + 3000 + 1500 - 2500);
            return mySal;
        }
    }
}
