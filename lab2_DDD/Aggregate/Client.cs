
namespace DDD.Aggregate;

public class Client
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string SecondName { get; set; }
    
    public string TypeOfPay { get; set; }
    
    public ICollection<Order> Orders { get; set; }
    
}

