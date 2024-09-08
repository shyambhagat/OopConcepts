namespace BankOperations
{
    public class AllBankOperations
    {
        // Private method to log transactions, used internally within the class.
        private void LogTransaction(string transactionType, double amount)
        {
            Console.WriteLine($"{transactionType} of {amount:C} recorded in the system.");
        }

        // Internal method to calculate the total assets, accessible within the same assembly.
        internal double CalculateTotalAssets(List<double> assets)
        {
            double total = 0;
            foreach (var asset in assets)
            {
                total += asset;
            }
            LogTransaction("Total Assets Calculation", total);
            return total;
        }

        // Internal method to calculate an employee's salary after deductions.
        internal double CalculateSalary(double baseSalary, double deductions)
        {
            if (deductions > baseSalary)
            {
                throw new ArgumentException("Deductions cannot exceed the base salary.");
            }
            double netSalary = baseSalary - deductions;
            LogTransaction("Salary Calculation", netSalary);
            return netSalary;
        }

        // Protected method to calculate the interest on an account, accessible in derived classes.
        protected double CalculateInterest(double accountBalance, double interestRate)
        {
            if (interestRate < 0 || interestRate > 1)
            {
                throw new ArgumentException("Interest rate must be between 0 and 1.");
            }
            double interest = accountBalance * interestRate;
            LogTransaction("Interest Calculation", interest);
            return interest;
        }

        // Public method to calculate the monthly expenses of a branch.
        public double CalculateMonthlyExpenses(double rent, double utilities, double salaries)
        {
            double expenses = rent + utilities + salaries;
            LogTransaction("Monthly Expenses Calculation", expenses);
            return expenses;
        }

        // Public method to generate a financial report for the branch.
        public string GenerateFinancialReport(string branchName, double totalAssets, double expenses)
        {
            double netAssets = totalAssets - expenses;
            LogTransaction("Financial Report Generation", netAssets);
            return $"Financial Report for {branchName}\n" +
                   $"Total Assets: {totalAssets:C}\n" +
                   $"Total Expenses: {expenses:C}\n" +
                   $"Net Assets: {netAssets:C}";
        }
    }
}
