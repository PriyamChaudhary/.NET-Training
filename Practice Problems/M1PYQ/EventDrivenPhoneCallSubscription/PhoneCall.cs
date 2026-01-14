using System;

namespace EventDrivenPhoneCallSubscription;

public delegate void Notify();
public class PhoneCall
{
    public event Notify PhoneCallEvent;
    public string Message{ get; private set;}


    private void OnSubscribe()
    {
        Message="Subscribed to the Call";
    }
    private void OnUnsubscribe()
    {
        Message="Unsubscribed to the Call";
    }

    public void MakeAPhoneCall(bool notify)
    {
        if (notify == true)
        {
            PhoneCallEvent += OnSubscribe;
            
        }
        else if (notify == false)
        {
            PhoneCallEvent += OnUnsubscribe;
            
        }
        else
        {
            Console.WriteLine("Invalid Option");
        }
        PhoneCallEvent.Invoke();
                             
        

    }


    

}
