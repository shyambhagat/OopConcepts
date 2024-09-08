using NullableConcepts;

// Create a few products
Product product1 = new Product(1, "Laptop", 1500m, "High-end gaming laptop");
Product product2 = new Product(2, "Smartphone", 800m);
Product product3 = new Product(3, "Tablet", 400m, "10-inch display tablet");

// Create a customer with no email or phone number
Customer customer = new Customer(1, "Alice Johnson");

// Create an order without specifying an order date
Order order1 = new Order(1, customer, new List<Product> { product1, product2 });

// Add the order to the customer's orders
customer.AddOrder(order1);

// Display the order details
order1.DisplayOrderDetails();

// Create another order with an order date
Order order2 = new Order(2, customer, new List<Product> { product3 }, DateTime.Now);
customer.AddOrder(order2);

// Display the second order details
order2.DisplayOrderDetails();

// Safe navigation operator usage (?.)
string? customerEmail = customer.Email?.ToUpper(); // Safe navigation to avoid null reference
Console.WriteLine($"Customer Email: {customerEmail ?? "No email provided"}"); // Null-coalescing operator
