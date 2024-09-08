using System;

namespace StaticMembersConcepts
{
    public class BankAccount
    {
        // Static field to store the interest rate for all accounts
        private static double _interestRate = 0.05;

        // Static field to track the total number of accounts created
        private static int _accountCount = 0;

        // Static property to access the interest rate
        public static double InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value >= 0)
                    _interestRate = value;
            }
        }

        // Static property to access the total number of accounts
        public static int AccountCount
        {
            get { return _accountCount; }
        }

        // Instance properties
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        // Constructor to initialize an account
        public BankAccount(string accountHolder, double initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
            _accountCount++; // Increment account count each time an account is created
        }

        // Instance method to apply interest to the account balance
        public void ApplyInterest()
        {
            Balance += Balance * _interestRate;
        }

        // Instance method to deposit money into the account
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        // Instance method to withdraw money from the account
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
        }
    }
}