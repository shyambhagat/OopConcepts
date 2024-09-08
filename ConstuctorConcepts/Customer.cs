using System;

namespace ConstructorConcepts
{
    internal class Customer
    {
        // Default constructor
        public Customer()
        {
            CustomerId = "Unknown";
            LoyaltyLevel = "Basic";
        }

        // Parameterized constructor
        public Customer(string fullName, int age, string customerId, string loyaltyLevel)
        {
            FullName = fullName;
            Age = age;
            CustomerId = customerId;
            LoyaltyLevel = loyaltyLevel;
        }

        // Copy constructor
        public Customer(Customer origObj)
        {
            FullName = origObj.FullName;
            Age = origObj.Age;
            CustomerId = origObj.CustomerId;
            LoyaltyLevel = origObj.LoyaltyLevel;
        }

        // Properties
        public string FullName { get; set; }
        public int Age { get; set; }
        public string CustomerId { get; set; }
        public string LoyaltyLevel { get; set; }
    }
}