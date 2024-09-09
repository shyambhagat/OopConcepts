using StaticMembersConcepts;

// Set a new interest rate for all accounts
BankAccount.InterestRate = 0.04;

// Create two bank accounts
var account1 = new BankAccount("Alice Johnson", 1000);
var account2 = new BankAccount("Bob Smith", 1500);

// Apply interest to both accounts
account1.ApplyInterest();
account2.ApplyInterest();

// Display account details
Console.WriteLine($"Account Holder: {account1.AccountHolder}, Balance: {account1.Balance:C}");
Console.WriteLine($"Account Holder: {account2.AccountHolder}, Balance: {account2.Balance:C}");

// Deposit money into account1
account1.Deposit(200);
Console.WriteLine($"After deposit, {account1.AccountHolder}'s Balance: {account1.Balance:C}");

// Withdraw money from account2
account2.Withdraw(300);
Console.WriteLine($"After withdrawal, {account2.AccountHolder}'s Balance: {account2.Balance:C}");

// Display the total number of accounts created
Console.WriteLine($"Total number of accounts created: {BankAccount.AccountCount}");
