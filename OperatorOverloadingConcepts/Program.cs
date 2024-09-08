using OperatorOverloadingConcepts;

Console.WriteLine("Operator Overloading Example");

// Create two Customer instances.
var customer1 = new Customer() { FullName = "Sowmya Goli", Address = "Bangalore", Wealth = 100000 };
var customer2 = new Customer() { FullName = "Vanita Manian", Address = "Mumbai", Wealth = 200000 };

// Calculate total wealth using the + operator.
var totalWealth = customer1 + customer2;
Console.WriteLine($"Total Wealth of {customer1.FullName} and {customer2.FullName}: {totalWealth:C}");

// Subtract wealth between two customers.
var wealthDifference = customer2 - customer1;
Console.WriteLine($"Wealth difference between {customer2.FullName} and {customer1.FullName}: {wealthDifference:C}");

// Compare wealth between two customers.
if (customer1 > customer2)
{
    Console.WriteLine($"{customer1.FullName} is wealthier than {customer2.FullName}");
}
else if (customer1 < customer2)
{
    Console.WriteLine($"{customer2.FullName} is wealthier than {customer1.FullName}");
}

// Merge additional address details with a customer using the + operator.
var updatedCustomer1 = customer1 + "India";
Console.WriteLine("Updated Address for Customer 1:");
Console.WriteLine(updatedCustomer1);