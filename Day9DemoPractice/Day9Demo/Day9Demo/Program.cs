using System;

namespace Day9Demo
{
    //struct Customer1 // Value type in Csharp which means no memory allocation on heap
    //{
    //    public int ID{ get; set; }
    //    public string Name{ get; set; }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            // Init Customer Object
            //Customer custObj=null; it will give exception as object is not initialised
            Customer custObj = new Customer();
            custObj.CustId = 101;
            custObj.Name = "Alok";
            //Init Shipping Addr
            custObj.ShippingAddr = new Address();
            custObj.ShippingAddr.FlatNo = 1802;
            custObj.ShippingAddr.BuildingName = "Sky Tower";
            custObj.ShippingAddr.Street = "Lane 1";
            custObj.ShippingAddr.Locality = "Wakad";
            custObj.ShippingAddr.City = "Pune";

            //1 Customer-Have-Many-Orders
            custObj.MyOrders = new List<Orders>() // set is protected in MyOrders that is why we cannot use the custObj like this here we have to make
      // a separate class of PrimeCustomers and make primeOrders then encapsulate that in MyOrders. I.e we are allowing only prime members 
            {
                new Orders{ OrderId=1124, OrderDate=new DateTime(2001,12,22), Amount=14000},
                new Orders{ OrderId=5345, OrderDate=new DateTime(2002,10,05), Amount=12000},
                new Orders{ OrderId=2346, OrderDate=new DateTime(2002,02,14), Amount=17000},
                new Orders{ OrderId=6897, OrderDate=new DateTime(2001,09,23), Amount=2000},

            };
        }
    }
}