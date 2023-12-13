
using DDD.Aggregate;

namespace DDD.Repository;

public class OrderRepository
{
    private readonly List<Order> _db = new();
    
    public void AddOrder(Order order)
    {
        _db.Add(order);
    }

    public Order? GetOrder(int id)
    {
        return _db.FirstOrDefault(c => c.Id == id);
    }
    
    public IEnumerable<Order> GetOrders()
    {
        return _db;
    }
}