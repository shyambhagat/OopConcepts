using System;

namespace PolymorphismConcepts
{
    // Sealed class representing a contractor, inheriting from Person.
    internal sealed class Contractor : Person
    {
        public double DailyWages { get; set; }

        // Contractors generally don't get loans in this system, so using the base implementation.
        // The CalculateBonus method from the base class will also be used as-is.
    }
}