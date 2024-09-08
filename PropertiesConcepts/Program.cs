using PropertiesConcepts;

Console.WriteLine("Welcome to the Employee Management System!");

// Create an Employee instance with initial details.
var employee = new Employee("Shyam", "Bhagat", 50000)
{
    Department = "Software Development"
};

// Display the employee's information.
employee.DisplayEmployeeInfo();

// Log a message using the write-only property.
employee.LogMessage = "Employee bonus calculated for the year.";