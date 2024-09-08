namespace OopConcepts;

internal class BankAccount
{
    // Properties to store the account number and balance.
    public string AccountNumber { get; set; }
    public decimal Balance { get; private set; }

    // Initializes a new instance of the BankAccount class with a specified account number and initial balance.
    public BankAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Deposits a specified amount into the account.
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C} to account {AccountNumber}. New balance is {Balance:C}.");
    }

    // Withdraws a specified amount from the account, if sufficient balance is available.
    public void Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C} from account {AccountNumber}. New balance is {Balance:C}.");
        }
        else
        {
            Console.WriteLine($"Insufficient funds in account {AccountNumber}. Withdrawal of {amount:C} failed.");
        }
    }
}