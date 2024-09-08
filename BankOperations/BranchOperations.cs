namespace BankOperations
{
    public class BranchOperations : AllBankOperations
    {
        // Method to perform operations specific to a branch, such as generating reports.
        public void PerformBranchOperations()
        {
            // Example: Salary calculation with base salary and deductions
            double salary = CalculateSalary(50000, 5000);

            // Example: Calculate total monthly expenses
            double expenses = CalculateMonthlyExpenses(20000, 5000, salary);

            // Example: Calculate interest on an account balance
            double interest = CalculateInterest(150000, 0.05);
            Console.WriteLine($"Interest earned: {interest:C}");

            // Example: Calculate total assets and generate a financial report
            double totalAssets = CalculateTotalAssets(new List<double> { 100000, 200000, 150000 + interest });
            string report = GenerateFinancialReport("Downtown Branch", totalAssets, expenses);

            // Output the financial report
            Console.WriteLine(report);
        }
    }
}