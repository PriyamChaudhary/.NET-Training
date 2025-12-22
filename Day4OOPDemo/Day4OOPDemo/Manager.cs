using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4OOPDemo
{
    class Manager:Employee
    {
        public int MgrId { get; set; }
        public int Incentive { get; set; }

        public override int CalcSalary(int sal)
        {
            int mySal = 0;
            //net salary=salary+HRA+TA+DA-PF
            mySal = (sal + 35000 + 3000 + 1500 - 8500);
            return mySal;
        }
    }
}
