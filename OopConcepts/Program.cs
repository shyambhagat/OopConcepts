using OopConcepts;

// Starting point of the application.
Console.WriteLine("Welcome to the Bank System!");

// Creating an instance of the Bank class for the Vashi branch of State Bank.
var vashiBranch = new Bank("State Bank", "Vashi");

// Creating two bank accounts with initial balances.
var account1 = new BankAccount("ACC12345", 1000.00m);
var account2 = new BankAccount("ACC67890", 500.00m);

// Adding the accounts to the Vashi branch.
vashiBranch.AddAccount(account1);
vashiBranch.AddAccount(account2);

// Displaying details of the bank and the accounts in the branch.
vashiBranch.ShowBankDetails();

// Performing some transactions on the accounts.
account1.Deposit(200.00m);
account2.Withdraw(100.00m);

// Displaying updated details of the bank and accounts after transactions.
vashiBranch.ShowBankDetails();