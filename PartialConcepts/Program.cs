using PartialConcepts;

// Create a new customer
var customer = new Customer(1, "Alice Smith", "alice@example.com");
Console.WriteLine($"Customer Created: {customer.Name}, Email: {customer.Email}");

// Update the customer's email
customer.UpdateEmail("alice.newemail@example.com");
Console.WriteLine($"Customer Email Updated: {customer.Name}, New Email: {customer.Email}");