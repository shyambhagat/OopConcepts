using EncapsulationConcepts;

Console.WriteLine("Welcome to the Bank System!");

// Creating an instance of the Branch class.
var branch = new Branch
{
    BankName = "Global Bank"
};

// Performing branch-specific operations.
branch.PerformOperations();

// Displaying bank details, including the updated balance after expenses.
branch.ShowBankDetails();