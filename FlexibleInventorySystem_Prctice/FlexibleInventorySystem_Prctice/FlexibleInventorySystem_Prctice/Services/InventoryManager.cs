using FlexibleInventorySystem_Practice.Interfaces;
using FlexibleInventorySystem_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleInventorySystem_Practice.Services
{  
    public class InventoryManager : IInventoryOperations, IReportGenerator
    {
        private readonly List<Product> _products;
        private readonly object _lockObject = new object();

        public InventoryManager()
        {
            _products = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            if (product == null)
            {
                return false;
                // throw new NullProductException("Product cannot be null");
            }
            if(product.Price<=0 || product.Quantity < 0)
            {
                return false;
            }
            if (_products.Any(p => p.Id == product.Id))
            {
                return false;
            }

            _products.Add(product);
            return true;
            // throw new NotImplementedException();
        }

        public Product FindProduct(string productId)
        {

            return _products.Find(p=>p.Id==productId);
            // throw new NotImplementedException();
        }

        public string GenerateCategorySummary()
        {
            throw new NotImplementedException();
        }

        public string GenerateExpiryReport(int daysThreshold)
        {
            var expiredProducts=_products.OfType<GroceryProduct>().Where(p=>p.DaysUntilExpiry()<daysThreshold).ToList();
            string res="";
            res+=string.Join("\n",expiredProducts.Select(p=>$"{p.Id}, {p.Name}, {p.DaysUntilExpiry()}"));
            return res;
            
            // throw new NotImplementedException();
        }

        public string GenerateInventoryReport()
        {
            string res="";
            res+="Inventory Report\n";
            res+=$"Total Products: {_products.Count}\n";
            res+=$"Total Value: {GetTotalInventoryValue()}\n";
            res+="Product List\n";
            foreach(var pd in _products)
            {
                res+=$"Id: {pd.Id}, Name: {pd.Name}, Category: {pd.Category}, Quantity: {pd.Quantity}, Value:{pd.CalculateValue()}\n";
            }
            return res;
            // throw new NotImplementedException();
        }

        public string GenerateValueReport()
        {
            var mostValuable=_products.OrderByDescending(p=>p.Price).First();
            var leastValuable=_products.OrderBy(p=>p.Price).First();
            var avgPrice=_products.Average(p=>p.Price);
            var aboveAvg=_products.Where(p=>p.Price>avgPrice);

            return $"Most valuable: {mostValuable}, Least valuable: {leastValuable}, Average price: {avgPrice}, Above avg price: {aboveAvg}";

            // throw new NotImplementedException();
        }

        public List<Product> GetLowStockProducts(int threshold)
        {
            return _products.Where(p=>p.Quantity<threshold).ToList();
            // throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            return _products.Where(p=>p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
            // throw new NotImplementedException();
        }

        public decimal GetTotalInventoryValue()
        {
            decimal total=0;
            foreach(var pd in _products)
            {
                total+=pd.CalculateValue();

            }
            return total;
            // throw new NotImplementedException();
        }

        public bool RemoveProduct(string productId)
        {
            var product = _products.Find(p=>p.Id==productId);
            if (product == null)
            {
                return false;
            }
            
            _products.Remove(product);
            return true;
           // throw new NotImplementedException();
        }

        // Implement all interface methods here

        // Additional methods for bonus features
        public IEnumerable<Product> SearchProducts(Func<Product, bool> predicate)
        {
            return _products.Where(predicate);
        }

        public bool UpdateQuantity(string productId, int newQuantity)
        {
            if (newQuantity < 0)
            {
                return false;
            }
            var product=_products.Find(p=>p.Id==productId);
            if (product == null)
            {
                return false;
            }
            product.Quantity=newQuantity;
            return true;
            // throw new NotImplementedException();
        }

        
    }    
}
