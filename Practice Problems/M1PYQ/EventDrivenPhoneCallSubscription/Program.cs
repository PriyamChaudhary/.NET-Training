using System;
namespace EventDrivenPhoneCallSubscription;

class Program
{
    static void Main(string[] args)
    {
        PhoneCall phoneCallObj = new PhoneCall();
        phoneCallObj.MakeAPhoneCall(true);
        Console.WriteLine(phoneCallObj.Message);
        phoneCallObj.MakeAPhoneCall(false);
        Console.WriteLine(phoneCallObj.Message);


      

        
    }
}