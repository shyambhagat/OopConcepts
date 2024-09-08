using InheritanceConcepts;

Console.WriteLine("Welcome to the Bank System!");

// Create a Branch instance and set its name.
var branch = new Branch
{
    BankName = "Global Bank - Main Branch"
};

// Perform branch operations to display the balance.
branch.PerformOperations();

// Show the bank details.
branch.ShowBankDetails();

// Create an ATM instance to simulate deposit and withdrawal operations.
var atm = new ATM();

// Simulate depositing money into an account.
atm.Deposit(123456, 1500);

// Simulate withdrawing money from an account.
atm.Withdraw(123456, 500);

// Show the remaining cash in the ATM.
Console.WriteLine($"Remaining Cash in ATM: {atm.GetCash():C}");