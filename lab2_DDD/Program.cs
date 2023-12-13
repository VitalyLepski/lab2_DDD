
using DDD.Aggregate;
using DDD.Factory;
using DDD.Repository;

var productFactory = new ProductFactory();
var orderFactory = new OrderFactory();
var clientFactory = new ClientFactory();

var productRepository = new ProductRepository();
var orderRepository = new OrderRepository();
var clientRepository = new ClientRepository();


// Создание Пользователя
Client client = clientFactory.CreateClient(
    "Vit",
    "Lepsk",
    "visa"
);

clientRepository.AddClient(client);

Console.WriteLine("Пользователь создан");

// Создание продукта
Product product = productFactory.CreateProduct(
    "product_1",
    "this is first product",
    100
    );

productRepository.AddProduct(product);

var listProducts = new List<Product>() { product };

var address = new Address()
{
    City = "Moscow",
    PostalCode = "232323",
    Street = "lybyanka, 22"
};

// Создание заказа
Order order = orderFactory.CreateOrder(1, "1", address, listProducts);
orderRepository.AddOrder(order);

Console.WriteLine("Заказ создан");