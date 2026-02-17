// Base product interface
public interface IProduct
{
    int Id { get; }
    string Name { get; }
    decimal Price { get; set;}
    Category Category { get; }
}

public enum Category { Electronics, Clothing, Books, Groceries }

// 1. Create a generic repository for products
public class ProductRepository<T> where T : class, IProduct
{
    private List<T> _products = new List<T>();
    
    // TODO: Implement method to add product with validation
    public void AddProduct(T product)
    {
        // Rule: Product ID must be unique
        if (_products.Any(p => p.Id == product.Id))
        {
            throw new ArgumentException("Duplicate Id");
        }
        // Rule: Price must be positive
        if (product.Price < 0)
        {
            throw new ArgumentException("Price cannot be negative");
        }
        // Rule: Name cannot be null or empty
        if (string.IsNullOrEmpty(product.Name))
        {
            throw new ArgumentException("Name cannot be empty");
        }
        // Add to collection if validation passes
        _products.Add(product);
    }
    
    // TODO: Create method to find products by predicate
    public IEnumerable<T> FindProducts(Func<T, bool> predicate)
    {
        // Should return filtered products
        return _products.Where(predicate);
    }
    
    // TODO: Calculate total inventory value
    public decimal CalculateTotalValue()
    {
        // Return sum of all product prices
        return _products.Sum(p=>p.Price);
    }
}

// 2. Specialized electronic product
public class ElectronicProduct : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Category Category => Category.Electronics;
    public int WarrantyMonths { get; set; }
    public string Brand { get; set; }
}

// 3. Create a discounted product wrapper
public class DiscountedProduct<T> where T : IProduct
{
    private T _product;
    private decimal _discountPercentage;
    
    public DiscountedProduct(T product, decimal discountPercentage)
    {
        // TODO: Initialize with validation
        // Discount must be between 0 and 100
        if (product == null)
        {
            throw new ArgumentNullException("Argument Cannot be Null");
        }
        if(discountPercentage<0 || discountPercentage > 100)
        {
            throw new Exception("Discount percentage must be between 0 to 100");
        }
        _product=product;
        _discountPercentage=discountPercentage;
    }
    
    // TODO: Implement calculated price with discount
    public decimal DiscountedPrice => _product.Price * (1 - _discountPercentage / 100);

    // TODO: Override ToString to show discount details
    public override string ToString()
    {
        return $"Discount Percentage : {_discountPercentage} , Discounted Price : {DiscountedPrice} ";
    }
}

// 4. Inventory manager with constraints
public class InventoryManager
{
    // TODO: Create method that accepts any IProduct collection
    public void ProcessProducts<T>(IEnumerable<T> products) where T : IProduct
    {
        // a) Print all product names and prices
        foreach(var item in products)
        {
            Console.WriteLine($"Product name: {item.Name}, Product Price: {item.Price}");
        }
        // b) Find the most expensive product
        var expensive=products.OrderByDescending(p=>p.Price).FirstOrDefault();
        Console.WriteLine($"Most Expensive Product: {expensive.Name}");
        // c) Group products by category
        var groups=products.GroupBy(p=>p.Category);
        foreach(var grp in groups)
        {
            Console.WriteLine($"Category: {grp.Key}");
            foreach(var item in grp){
            Console.Write($"{item.Name}");
            }
            
        }

        // d) Apply 10% discount to Electronics over $500
        foreach(var p in products.Where(p=>p.Category==Category.Electronics && p.Price>500))
        {
            Console.WriteLine(new DiscountedProduct<T>(p,10));
        }
    }
    
    // TODO: Implement bulk price update with delegate
    public void UpdatePrices<T>(List<T> products, Func<T, decimal> priceAdjuster) 
        where T : IProduct
    {
        // Apply priceAdjuster to each product
        foreach(var p in products)
        {
            try
            {
                var newPrice=priceAdjuster(p);
                if (newPrice <= 0)
                {
                    throw new Exception("Invalid Updated Price");
                }
                p.Price=newPrice;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // Handle exceptions gracefully
    }
}

// 5. TEST SCENARIO: Your tasks:
// a) Implement all TODO methods with proper error handling
// b) Create a sample inventory with at least 5 products
// c) Demonstrate:
//    - Adding products with validation
//    - Finding products by brand (for electronics)
//    - Applying discounts
//    - Calculating total value before/after discount
//    - Handling a mixed collection of different product types