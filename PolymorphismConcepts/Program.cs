using PolymorphismConcepts;

Console.WriteLine("Welcome to the Polymorphism Concepts Demo!");

// Create a Contractor instance and simulate actions.
var contractor = new Contractor { FirstName = "Shyam", LastName = "Bhagat", DailyWages = 300 };
contractor.PunchIn();
Console.WriteLine($"Contractor Bonus: {contractor.CalculateBonus():C}");
contractor.PunchOut();

// Create an Employee instance and simulate actions.
var employee = new Employee { FirstName = "Vanita", LastName = "Manian", Salary = 400000, Designation = "Software Engineer" };
employee.PunchIn();
Console.WriteLine($"Employee Loan Eligibility: {employee.GetLoan(100000):C}");
Console.WriteLine($"Employee Base Bonus: {employee.CalculateBonus():C}");
Console.WriteLine($"Employee Bonus (10% of Salary): {employee.CalculateBonus(10):C}");
Console.WriteLine($"Employee Bonus (10% of Salary + 2000): {employee.CalculateBonus(10, 2000):C}");
Console.WriteLine($"Employee Bonus (5000 per Year, 5 Years): {employee.CalculateBonus(5000, 5):C}");
employee.PunchOut();