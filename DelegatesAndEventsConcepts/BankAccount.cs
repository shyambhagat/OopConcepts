namespace DelegatesAndEventsConcepts
{

    // BankAccount class that triggers events on certain operations
    public class BankAccount
    {
        // Event for notifying when a deposit is made
        public event BankOperationEventHandler OnDeposit;

        // Event for notifying when a withdrawal is made
        public event BankOperationEventHandler OnWithdrawal;

        // Property to store the balance of the account
        public double Balance { get; private set; }

        // Constructor to initialize the account with an initial balance
        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            Balance += amount;
            // Trigger the OnDeposit event
            OnDeposit?.Invoke(this, new BankOperationEventArgs { Operation = "Deposit", Amount = amount, Balance = Balance });
        }

        // Method to withdraw money from the account
        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                // Trigger the OnWithdrawal event
                OnWithdrawal?.Invoke(this, new BankOperationEventArgs { Operation = "Withdrawal", Amount = amount, Balance = Balance });
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }
    }
}