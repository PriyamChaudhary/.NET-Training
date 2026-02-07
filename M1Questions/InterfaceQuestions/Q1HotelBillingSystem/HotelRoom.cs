using System;

namespace Q1HotelBillingSystem;

public class HotelRoom : IRoom
{
    public string RoomType { get; set; }
    public double RatePerNight{get; set;}
    public string GuestName{get; set;}

    public HotelRoom(string roomtype, double ratePerNight, string guestName)
    {
        RoomType = roomtype;
        RatePerNight = ratePerNight;
        GuestName = guestName; 
    }
    
    public double CalculateTotalBill(int nightsStayed, int joiningYear)
    {
        double totalBill=nightsStayed*RatePerNight;
        IRoom roomObj=this;
        int membershipYears = roomObj.CalculateMembershipYears(joiningYear);
        if (membershipYears > 3)
        {
            totalBill=0.9*totalBill;
        }

        return totalBill;


        
    }
}


   


