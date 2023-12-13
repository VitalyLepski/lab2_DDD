
using DDD.Aggregate;

namespace DDD.Factory;

public class ProductFactory
{
    private int _id = 0;
    public Product CreateProduct(string name, string details, decimal price)
    {
        
        var product = new Product()
        {
            Id = _id,
            Name = name,
            Detaills = details,
            Price = price
        };

        _id++;
        
        return product;
    }
}