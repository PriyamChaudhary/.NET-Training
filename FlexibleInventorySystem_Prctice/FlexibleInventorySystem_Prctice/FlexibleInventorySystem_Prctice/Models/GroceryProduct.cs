using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleInventorySystem_Practice.Models
{
        /// <summary>
        /// TODO: Implement grocery product class
        /// </summary>
        public class GroceryProduct : Product
        {
            // TODO: Add these properties
            // - ExpiryDate (DateTime)
            // - IsPerishable (bool)
            // - Weight (double)
            // - StorageTemperature (string) - e.g., "Room temperature", "Refrigerated", "Frozen"
            public DateTime ExpiryDate{get;set;}
            public bool IsPerishable{get;set;}
            public double Weight{get;set;}
            public string StorageTemperature{get; set;}

            /// <summary>
            /// TODO: Override GetProductDetails for grocery items
            /// Include expiry information
            /// </summary>
            public override string GetProductDetails()
            {
                // TODO: Implement
                return $"{Id}, {Name}, {Price}, {Quantity}, {ExpiryDate}";
                // throw new NotImplementedException();
            }

            /// <summary>
            /// TODO: Check if product is expired
            /// </summary>
            public bool IsExpired()
            {
            // TODO: Compare ExpiryDate with current date
            if (ExpiryDate < DateTime.Now)
            {
                return false;
            }
            return true;
                // throw new NotImplementedException();
            }

            /// <summary>
            /// TODO: Calculate days until expiry
            /// Return negative if expired
            /// </summary>
            public int DaysUntilExpiry()
            {
                // TODO: Calculate days difference
                return (ExpiryDate-DateTime.Now).Days;
                // throw new NotImplementedException();
            }

            /// <summary>
            /// TODO: Override CalculateValue to apply discount for near-expiry items
            /// Apply 20% discount if within 3 days of expiry
            /// </summary>
            public override decimal CalculateValue()
            {
                // TODO: Apply discount logic if near expiry
                int daysUntilExpiry=DaysUntilExpiry();
                
                if (daysUntilExpiry < 3)
                {
                    Price=(0.8m)*Price;
                }
                return Price;

                // throw new NotImplementedException();
            }
        }
    }

