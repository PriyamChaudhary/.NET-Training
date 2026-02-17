using System;
using System.Collections.Generic;
using System.Linq;

namespace PharmacyMedicine;

public class MedicineUtility
{
    private SortedDictionary<int, List<Medicine>> medicines = new SortedDictionary<int, List<Medicine>>();

    public void AddMedicine(Medicine medObj)
    {
        if (medObj.Price <= 0)
        {
            throw new InvalidPriceException("Invalid Price");
        }
        if (medObj.ExpiryYear < DateTime.Now.Year)
        {
            throw new InvalidExpiryYearException("Invalid Expiry Year");
        }
        if (medicines.Values.SelectMany(list => list).Any(m => m.Id == medObj.Id))
        {
            throw new DuplicateMedicineException("Duplicate Medicine");
        }
        if (!medicines.ContainsKey(medObj.ExpiryYear))
        {
            medicines[medObj.ExpiryYear]=new List<Medicine>();

        }
        medicines[medObj.ExpiryYear].Add(medObj);
    }

    public List<Medicine> GetAllMedicines()
    {
        
        return medicines.Values.SelectMany(list=>list).ToList();
    }

    public void UpdateMedicinePrice(string id, int newPrice)
    {
        if (newPrice <= 0)
        {
            throw new InvalidPriceException("Invalid new Price");
        }
        var med=medicines.Values.SelectMany(list=>list).FirstOrDefault(m=>m.Id==id);
        if (med == null)
        {
            throw new MedicineNotFoundException("Medicine not found");
        }
        med.Price=newPrice;
    }

}

[Serializable]
internal class MedicineNotFoundException : Exception
{

    public MedicineNotFoundException(string? message) : base(message)
    {
    }

    
}

[Serializable]
internal class DuplicateMedicineException : Exception
{

    public DuplicateMedicineException(string? message) : base(message)
    {
    }

    
}

[Serializable]
internal class InvalidExpiryYearException : Exception
{
    

    public InvalidExpiryYearException(string? message) : base(message)
    {
    }

   
}

[Serializable]
internal class InvalidPriceException : Exception
{
    

    public InvalidPriceException(string? message) : base(message)
    {
    }
 
}