// Create a repository for Customers
using GenericsConcepts;

var customerRepository = new GenericRepository<Customer>();

// Add customers to the repository
customerRepository.Add(new Customer { Id = 1, Name = "Alice", Email = "alice@example.com" });
customerRepository.Add(new Customer { Id = 2, Name = "Bob", Email = "bob@example.com" });

// Retrieve and display a customer by ID
var customer = customerRepository.GetById(1);
Console.WriteLine($"Retrieved Customer: {customer.Name}, {customer.Email}");

// Create a repository for Orders
var orderRepository = new GenericRepository<Order>();

// Add orders to the repository
orderRepository.Add(new Order { Id = 1, Product = "Laptop", Quantity = 2 });
orderRepository.Add(new Order { Id = 2, Product = "Phone", Quantity = 5 });

// Retrieve and display an order by ID
var order = orderRepository.GetById(2);
Console.WriteLine($"Retrieved Order: {order.Product}, Quantity: {order.Quantity}");

// Using the Utilities class
int a = 10, b = 20;
Utilities.Swap(ref a, ref b);
Console.WriteLine($"After swap: a = {a}, b = {b}");

int max = Utilities.Max(100, 200);
Console.WriteLine($"Max of 100 and 200 is: {max}");