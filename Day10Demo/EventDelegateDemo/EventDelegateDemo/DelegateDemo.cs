using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateDemo
{
    //Multicast Delegate - when there is no return type(void)
    public delegate void GreetMsg(string msg);

    //Unicast Delegate - when there is some return type
    //public delegate int Calculation(int num1, int num2);

    //creating all the classes in one single file is bad practice, create them in separate files
    class Hindi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Suprabhaat"+userName);
        }
    }
    class Tamil
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Vanakkam" + userName);
        }

    }
    class Telegu
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Namaskaram" + userName);
        }
    }
    class Marathi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Namaskar" + userName);
        }
    }

    public class DelegateDemo
    {
        public static void DelegateDemoMain()
        {
            Tamil tObj=new Tamil();
            GreetMsg GreetInTamil = new GreetMsg(tObj.WelcomeMsg);//GreetInTamil is the fuction pointer pointing towards a named function
                                                                  //this is level of encapsulation
            GreetInTamil("Alok");

        }
    }
}
