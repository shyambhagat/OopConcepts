using System;

namespace PolymorphismConcepts
{
    // Abstract base class representing a generic person.
    internal abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to simulate punching in for work.
        public void PunchIn()
        {
            Console.WriteLine($"{FirstName} {LastName} punched in.");
        }

        // Method to simulate punching out from work.
        public void PunchOut()
        {
            Console.WriteLine($"{FirstName} {LastName} punched out.");
        }

        // Virtual method to calculate loan eligibility, which can be overridden by derived classes.
        public virtual double GetLoan(double requestedAmount)
        {
            Console.WriteLine($"{FirstName} {LastName} requested a loan of {requestedAmount:C}.");
            return requestedAmount;
        }

        // Base method for calculating a bonus, can be hidden by derived classes.
        public double CalculateBonus()
        {
            return 1000; // Base bonus amount
        }
    }
}