using System;

namespace ConstructorConcepts
{
    internal class Employee
    {
        // Static constructor - initializes static members of the class
        static Employee()
        {
            EmployeeCount = 0;
        }

        // Default constructor
        public Employee()
        {
            EmployeeId = "Unknown";
            Department = "Unknown";
            EmployeeCount++;
        }

        // Parameterized constructor
        public Employee(string fullName, int age, string employeeId, string department)
        {
            FullName = fullName;
            Age = age;
            EmployeeId = employeeId;
            Department = department;
            EmployeeCount++;
        }

        // Copy constructor
        public Employee(Employee origObj)
        {
            FullName = origObj.FullName;
            Age = origObj.Age;
            EmployeeId = origObj.EmployeeId;
            Department = origObj.Department;
            EmployeeCount++;
        }

        // Properties
        public string FullName { get; set; }
        public int Age { get; set; }
        public string EmployeeId { get; set; }
        public string Department { get; set; }

        // Static property to keep track of the number of employees
        public static int EmployeeCount { get; private set; }
    }
}