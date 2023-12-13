
using DDD.Aggregate;
namespace DDD.Factory;

public class ClientFactory
{
    private int _id = 0;
    public Client CreateClient(string name, string secondName, string typeOfPay)
    {
        var client = new Client()
        {
            Id = _id,
            Name = name,
            SecondName = secondName,
            TypeOfPay = typeOfPay
        };
        
        _id++;
        
        return client;
    }
}