using System;

namespace Q2RealEstateListing;

public class RealEstateApp
{
    private List<IRealEstateListing> listings;
    public RealEstateApp()
    {
        listings=new List<IRealEstateListing>();
    }

    public void AddListing(IRealEstateListing listing)
    {
        listings.Add(listing);
    }
    public void RemoveListing(int listingID)
    {
        var listing=listings.FirstOrDefault(l=>l.ID==listingID);
        if(listing!=null)
        {
            listings.Remove(listing);
        }
        
    }
    public void UpdateListing(IRealEstateListing listing)
    {
        var existingListing=listings.FirstOrDefault(l=>l.ID==listing.ID);
        if(existingListing!=null)
        {
            existingListing.Title=listing.Title;
            existingListing.Description=listing.Description;
            existingListing.Price=listing.Price;
            existingListing.Location=listing.Location;
        }
        
    }
    public List<IRealEstateListing> GetListings()
    {
        return listings;
    }
    public List<IRealEstateListing> GetListingsByLocation(string location)
    {
        return listings.Where(l=>l.Location==location).ToList();
    }
    public List<IRealEstateListing> GetListingsByPriceRange(int minPrice, int maxPrice)
    {
        return listings.Where(l=>l.Price>=minPrice && l.Price<=maxPrice).ToList();
    }


}
