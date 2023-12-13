
namespace DDD.Aggregate;

public class Order
{
    public int Id { get; set; }
    
    public int ClientId { get; set; }
    
    public Address Address { get; set; }
    
    public string StatusOfOrder { get; set; }
    
    public ICollection<Product> OrderProducts { get; set; }
}



public class Address
{
    public string City { get; set; }
    
    public string Street { get; set; }
    
    public string PostalCode { get; set; }
}

