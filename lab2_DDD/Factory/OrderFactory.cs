
using DDD.Aggregate;

namespace DDD.Factory;

public class OrderFactory
{
    private int _id = 0;
    public Order CreateOrder(int clientId, string statusOfOrder, Address address, List<Product> products)
    {
        var order = new Order()
        {
            Id = _id,
            ClientId = clientId,
            StatusOfOrder = statusOfOrder,
            Address = address,
            OrderProducts = products
        };
        
        _id++;
        
        return order;
    }
}