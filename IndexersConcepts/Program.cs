using IndexersConcepts;

// Create a collection of employees
EmployeeCollection employeeCollection = new EmployeeCollection();

// Add employees to the collection
employeeCollection.Add(new Employee(1, "John Doe", "Engineering"));
employeeCollection.Add(new Employee(2, "Jane Smith", "Marketing"));
employeeCollection.Add(new Employee(3, "Sam Brown", "HR"));

// Access employees by index
Employee emp1 = employeeCollection[0];
Console.WriteLine($"Employee at index 0: {emp1.Name}, {emp1.Department}");

// Access employee by ID
Employee empById = employeeCollection["2"];
Console.WriteLine($"Employee with ID 2: {empById.Name}, {empById.Department}");

// Modify employee at a specific index
employeeCollection[1] = new Employee(2, "Jane Doe", "Sales");
Employee modifiedEmp = employeeCollection[1];
Console.WriteLine($"Modified Employee at index 1: {modifiedEmp.Name}, {modifiedEmp.Department}");
