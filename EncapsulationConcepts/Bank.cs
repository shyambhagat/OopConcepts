using BankOperations;

namespace EncapsulationConcepts
{
    internal class Bank
    {
        // Private property to store bank balance.
        private double BankBalance { get; set; } = 1000000; // Initial balance for demonstration

        // Public property to store the bank name.
        public string BankName { get; set; }

        // Private method to log the bank's internal operations.
        private void LogBankOperation(string operation)
        {
            Console.WriteLine($"Bank operation performed: {operation}");
        }

        // Public method to show bank details.
        public void ShowBankDetails()
        {
            var bankOperations = new AllBankOperations();
            double expenses = bankOperations.CalculateMonthlyExpenses(30000, 10000, 120000); // Sample expenses

            BankBalance -= expenses; // Deduct monthly expenses from the bank balance
            LogBankOperation("Monthly Expenses Deduction");

            Console.WriteLine($"Bank: {BankName}");
            Console.WriteLine($"Remaining Bank Balance: {BankBalance:C}");
        }

        // Protected method to get the bank balance, accessible in derived classes.
        protected double GetBankBalance()
        {
            return BankBalance;
        }
    }
}