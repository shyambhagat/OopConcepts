using System;

namespace InheritanceConcepts
{
    // Branch class inherits from the Bank class.
    internal class Branch : Bank
    {
        public void PerformOperations()
        {
            var balance = GetBankBalance();
            Console.WriteLine($"Current Branch Bank Balance: {balance:C}");
        }
    }
}