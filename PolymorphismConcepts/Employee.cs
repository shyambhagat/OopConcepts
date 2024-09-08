using System;

namespace PolymorphismConcepts
{
    // Sealed class representing an employee, inheriting from Person.
    internal sealed class Employee : Person
    {
        public string Designation { get; set; }
        public double Salary { get; set; }

        // Overrides the GetLoan method to provide a customized loan calculation based on salary.
        public override double GetLoan(double requestedAmount)
        {
            double maxLoan = Salary * 0.20; // 20% of the salary
            Console.WriteLine($"{FirstName} {LastName} requested a loan of {requestedAmount:C}. Eligible for: {maxLoan:C}");

            return requestedAmount > maxLoan ? maxLoan : requestedAmount;
        }

        // Hides the base class CalculateBonus method, returning a fixed bonus amount.
        public new double CalculateBonus()
        {
            return 5000; // Employee-specific bonus
        }

        // Overloaded methods to calculate a bonus based on different criteria.

        // Bonus based on a percentage of the salary.
        public double CalculateBonus(double percentage)
        {
            return Salary * (percentage / 100);
        }

        // Bonus based on a percentage of the salary plus an additional amount.
        public double CalculateBonus(double percentage, double additionalAmount)
        {
            return (Salary * (percentage / 100)) + additionalAmount;
        }

        // Bonus based on a fixed amount multiplied by years of service.
        public double CalculateBonus(double fixedAmount, int yearsOfService)
        {
            return fixedAmount * yearsOfService;
        }
    }
}