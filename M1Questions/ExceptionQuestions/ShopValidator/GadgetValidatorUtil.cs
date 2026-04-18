using System;
using System.Text.RegularExpressions;

namespace ShopValidator;

public class GadgetValidatorUtil
{
    public bool ValidateGadgetId(string gadgetId)
    {
        string pattern=@"^[A-Z][0-9]{3}$";
        if(!Regex.IsMatch(gadgetId, pattern))
        {
            throw new InvalidGadgetException("Invalid Gadget ID");
            
        }
        return true;
    }
    public bool ValidateWarrantyPeriod(int period)
    {
        if(period<6 || period > 36)
        {
            throw new InvalidGadgetException("Invalid warranty period");
        }
        return true;
    }

}
