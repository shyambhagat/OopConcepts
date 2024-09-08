using System;

namespace InheritanceConcepts
{
    // ATM class implements both IDeposit and IWithdrawal interfaces.
    internal sealed class ATM : IDeposit, IWithdrawal
    {
        private double _cashAvailable = 50000; // Simulated cash available in ATM

        // Method to get the available cash in the ATM.
        public int GetCash()
        {
            return (int)_cashAvailable;
        }

        // Method to deposit a specified amount into an account.
        public void Deposit(int accountId, double amount)
        {
            Console.WriteLine($"Depositing {amount:C} to Account ID: {accountId}");
            _cashAvailable += amount;
        }

        // Method to complete a withdrawal from an account.
        public void CompleteWithdraw(int accountId, double amount)
        {
            if (amount <= _cashAvailable)
            {
                Console.WriteLine($"Withdrawal of {amount:C} from Account ID: {accountId} completed.");
                _cashAvailable -= amount;
            }
            else
            {
                Console.WriteLine($"Insufficient funds in ATM to withdraw {amount:C}.");
            }
        }

        // Method to initiate a withdrawal from an account.
        public void Withdraw(int accountId, double amount)
        {
            Console.WriteLine($"Attempting to withdraw {amount:C} from Account ID: {accountId}.");
            CompleteWithdraw(accountId, amount);
        }
    }
}