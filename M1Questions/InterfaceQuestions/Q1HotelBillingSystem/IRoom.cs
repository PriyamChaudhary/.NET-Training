using System;
using System.ComponentModel;

namespace Q1HotelBillingSystem;

public interface IRoom
{
    double CalculateTotalBill(int nightsStayed, int joiningYear);
    int CalculateMembershipYears(int joiningYear)
    {
        int currentYear=DateTime.Now.Year;
        return currentYear - joiningYear;
    }

}
