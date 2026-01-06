using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Demo
{
    class PrimeCustomer:Customer
    {
        public List<Orders> MyPrimeOrders //write only property
        {
            set
            {
                MyOrders= value; //this code is encapsulating Prime Orders
            }
        }
    }
}
