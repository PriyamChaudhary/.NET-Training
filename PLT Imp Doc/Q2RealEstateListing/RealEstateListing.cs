using System;

namespace Q2RealEstateListing;

public class RealEstateListing: IRealEstateListing
{
    public int ID{get;set;}
    public string Title{get;set;}
    public string Description{get;set;}
    public int Price{get;set;}
    public string Location{get;set;}

    public RealEstateListing(int id, string title, string description, int price, string location)
    {
        ID=id;
        Title=title;
        Description=description;
        Price=price;
        Location=location;
    }


}

public interface IRealEstateListing
{
    int ID{get;set;}
    string Title{get;set;}
    string Description{get;set;}
    int Price{get;set;}
    string Location{get;set;}

    
}
