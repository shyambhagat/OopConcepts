using NewKeywordsConcepts;

// Create a customer
var customer = new Customer { Name = "Alice", Email = "alice@example.com" };

// Create a product
var product = new Product { Name = "Laptop", Price = 1000, Stock = 10 };

// Create an order
var order = new Order { Customer = customer, Product = product, Quantity = 2 };

// Using the is operator with pattern matching
if (order.Customer is Customer customerObj)
{
    Console.WriteLine($"Processing order for customer: {customerObj.Name}");
}

// Using the as operator for safe casting
var email = order.Customer.Email as string;
if (email != null)
{
    Console.WriteLine($"Customer email: {email}");
}

// Using the typeof operator
Type customerType = typeof(Customer);
Console.WriteLine($"Customer type: {customerType.FullName}");

// Using the nameof operator
Console.WriteLine($"Order is being processed for product: {nameof(order.Product)}");

// Using the sizeof operator
int size = sizeof(int);
Console.WriteLine($"Size of int: {size} bytes");

// Using the dynamic keyword
dynamic productInfo = order.Product.Name;
Console.WriteLine($"Product name (dynamic): {productInfo}");

// Using the default keyword
string defaultString = default;
int defaultInt = default;
Console.WriteLine($"Default string value: {defaultString}, Default int value: {defaultInt}");

// Using checked to handle overflow
try
{
    int totalStock = checked(order.Product.Stock + 1);
    Console.WriteLine($"Total stock after ordering: {totalStock}");
}
catch (OverflowException)
{
    Console.WriteLine("Overflow occurred during stock calculation.");
}

// Using the is not pattern
if (order.Product is not null)
{
    Console.WriteLine($"Product: {order.Product.Name} is available.");
}

// Using the in keyword for read-only reference
int quantity = 5;
CalculateTotalPrice(in quantity);

// Using the ?? operator
string customerName = order.Customer.Name ?? "Unknown Customer";
Console.WriteLine($"Customer name: {customerName}");

// Using the ?. operator
int? productNameLength = order.Product?.Name?.Length;
Console.WriteLine($"Length of product name: {productNameLength}");

// Local function to calculate total price with in parameter
static void CalculateTotalPrice(in int quantity)
{
    // The quantity parameter is read-only here
    Console.WriteLine($"Calculating total price for quantity: {quantity}");
}
