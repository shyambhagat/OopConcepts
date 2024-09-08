using OopConcepts;
using System;
using System.Collections.Generic;

namespace OopConcepts
{
    /// Represents a bank with a specific branch.
    internal class Bank
    {
        // Properties to store the bank and branch names.
        public string BankName { get; set; }
        public string BranchName { get; set; }

        // A list to store the accounts managed by the bank.
        private List<BankAccount> accounts;

        // Initializes a new instance of the Bank class with a specified bank name and branch name.
        public Bank(string bankName, string branchName)
        {
            BankName = bankName;
            BranchName = branchName;
            accounts = new List<BankAccount>();
        }

        // Adds a bank account to the branch.
        public void AddAccount(BankAccount account)
        {
            accounts.Add(account);
            Console.WriteLine($"Account {account.AccountNumber} added to {BranchName} branch of {BankName}.");
        }

        // Displays the details of the bank including all accounts in the branch.
        public void ShowBankDetails()
        {
            Console.WriteLine($"Bank: {BankName}, Branch: {BranchName}");
            Console.WriteLine("Accounts in this branch:");
            foreach (var account in accounts)
            {
                Console.WriteLine($"- Account Number: {account.AccountNumber}, Balance: {account.Balance:C}");
            }
        }
    }

    // Represents a bank account with basic operations like deposit and withdrawal.
}