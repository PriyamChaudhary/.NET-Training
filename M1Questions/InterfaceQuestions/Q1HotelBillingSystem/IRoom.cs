using System;
using System.ComponentModel;

namespace Q1HotelBillingSystem;

public interface IRoom
{
    public double CalculateTotalBill(int nightsStayed, int joiningYear);
    public int CalculateMembershipYears(int joiningYear);

}
