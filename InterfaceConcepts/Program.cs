using InterfaceConcepts;

Console.WriteLine("Customer Management System");

// Initialize the repository
var repository = new CustomerRepository();

// Add new customers
var customer1 = new Customer { FullName = "John Doe", Address = "123 Main St", City = "New York", Region = "NY", PostalCode = "10001", Country = "USA" };
var customer2 = new Customer { FullName = "Jane Smith", Address = "456 Elm St", City = "Los Angeles", Region = "CA", PostalCode = "90001", Country = "USA" };

repository.Add(customer1);
repository.Add(customer2);

// Retrieve and display all customers
Console.WriteLine("All Customers:");
foreach (var customer in repository.GetAll())
{
    Console.WriteLine($"{customer.Id}: {customer.FullName} - {customer.City}, {customer.Country}");
}

// Update a customer
customer1.City = "Brooklyn";
repository.Update(customer1);

// Retrieve and display updated customer
var updatedCustomer = repository.GetById(1);
Console.WriteLine($"\nUpdated Customer 1: {updatedCustomer.FullName} - {updatedCustomer.City}, {updatedCustomer.Country}");

// Delete a customer
repository.Delete(customer2);

// Display remaining customers
Console.WriteLine("\nRemaining Customers:");
foreach (var customer in repository.GetAll())
{
    Console.WriteLine($"{customer.Id}: {customer.FullName} - {customer.City}, {customer.Country}");
}