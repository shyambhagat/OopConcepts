using ConstructorConcepts;

// Create a Customer using the default constructor
var customer1 = new Customer();

// Create a Customer using the parameterized constructor
var customer2 = new Customer("Alice Smith", 28, "C001", "Gold");

// Create a Customer using the copy constructor
var customer3 = new Customer(customer2);

// Output details for Customer 2 and Customer 3 (copy of Customer 2)
Console.WriteLine($"Customer 2: {customer2.FullName}, {customer2.Age}, {customer2.CustomerId}, {customer2.LoyaltyLevel}");
Console.WriteLine($"Customer 3 (Copy of Customer 2): {customer3.FullName}, {customer3.Age}, {customer3.CustomerId}, {customer3.LoyaltyLevel}");

// Create an Employee using the default constructor
var employee1 = new Employee();

// Create an Employee using the parameterized constructor
var employee2 = new Employee("Bob Johnson", 35, "E123", "IT");

// Create an Employee using the copy constructor
var employee3 = new Employee(employee2);

// Output details for Employee 2 and Employee 3 (copy of Employee 2)
Console.WriteLine($"Employee 2: {employee2.FullName}, {employee2.Age}, {employee2.EmployeeId}, {employee2.Department}");
Console.WriteLine($"Employee 3 (Copy of Employee 2): {employee3.FullName}, {employee3.Age}, {employee3.EmployeeId}, {employee3.Department}");

// Access and output the static property from Employee class
int totalEmployees = Employee.EmployeeCount;
Console.WriteLine($"Total number of employees: {totalEmployees}");

// Attempt to create two instances of the DatabaseConnection class
var dbConnection1 = DatabaseConnection.Instance;
var dbConnection2 = DatabaseConnection.Instance;

// Use the Singleton instance to execute a query
dbConnection1.ExecuteQuery("SELECT * FROM Users");

// Show connection details for both instances
dbConnection1.ShowConnectionDetails();
dbConnection2.ShowConnectionDetails();

// Check if both instances are the same
bool areSameInstance = ReferenceEquals(dbConnection1, dbConnection2);
Console.WriteLine($"Both instances are the same: {areSameInstance}");