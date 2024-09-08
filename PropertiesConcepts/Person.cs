using System;

namespace PropertiesConcepts
{
    internal class Employee
    {
        // Backing field for the FirstName property.
        private string firstName;

        // Backing field for the LastName property.
        private string lastName;

        // Property with validation for FirstName.
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    firstName = value;
                }
                else
                {
                    Console.WriteLine("First name cannot be empty.");
                }
            }
        }

        // Property with validation for LastName.
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    lastName = value;
                }
                else
                {
                    Console.WriteLine("Last name cannot be empty.");
                }
            }
        }

        // Read-only property that combines FirstName and LastName to return the full name.
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        // Auto-implemented property for Department.
        public string Department { get; set; }

        // Auto-implemented property for Salary with validation.
        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary cannot be negative.");
                }
            }
        }

        // Write-only property for logging purposes.
        private string logMessage;

        public string LogMessage
        {
            set
            {
                logMessage = value;
                Console.WriteLine($"Log: {logMessage}");
            }
        }

        // Calculated property for annual bonus (10% of the salary).
        public double AnnualBonus
        {
            get { return Salary * 0.10; }
        }

        // Constructor to initialize the employee's first name, last name, and salary.
        public Employee(string firstName, string lastName, double initialSalary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = initialSalary;
        }

        // Method to display employee details.
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee: {FullName}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Salary: {Salary:C}");
            Console.WriteLine($"Annual Bonus: {AnnualBonus:C}");
        }
    }
}
