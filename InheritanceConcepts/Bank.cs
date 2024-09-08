using System;

namespace InheritanceConcepts
{
    // Abstract Bank class represents the base class for banks.
    internal abstract class Bank
    {
        private double BankBalance { get; set; } = 1000000; // Initial bank balance

        public string BankName { get; set; }

        // Method to display bank details.
        public void ShowBankDetails()
        {
            Console.WriteLine($"Bank Name: {BankName}");
        }

        // Protected method to access the bank balance, available to derived classes.
        protected double GetBankBalance()
        {
            return BankBalance;
        }
    }
}