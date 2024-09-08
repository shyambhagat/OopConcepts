namespace EncapsulationConcepts
{
    internal class Branch : Bank
    {
        // Method to perform branch-specific operations.
        public void PerformOperations()
        {
            var balance = GetBankBalance(); // Accessing protected method from the base class
            Console.WriteLine($"Current Branch Bank Balance: {balance:C}");
        }
    }
}