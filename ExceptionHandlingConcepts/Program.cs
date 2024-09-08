using ExceptionHandlingConcepts;

// Create a product
var product = new Product { Name = "Laptop", Stock = 5, Price = 1000 };

// Create an order
var order = new Order { Product = product, Quantity = 2 };

// Create an order processor
var orderProcessor = new OrderProcessor();

try
{
    // Process the order
    orderProcessor.ProcessOrder(order);
}
catch (Exception ex) when (ex is OutOfStockException || ex is PaymentFailedException)
{
    Console.WriteLine($"Order processing failed: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}