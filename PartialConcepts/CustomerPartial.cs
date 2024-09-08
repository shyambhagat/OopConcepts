namespace PartialConcepts
{
    // Partial class Customer: manages customer operations
    public partial class Customer
    {
        // Method to update customer email
        public void UpdateEmail(string newEmail)
        {
            Email = newEmail;

            // Call the partial method (if implemented)
            OnEmailUpdated();
        }

        // Partial method: can be implemented in another part of the class
        partial void OnEmailUpdated();

        // Implementing the partial method from the first file
        partial void OnCustomerCreated()
        {
            // Logic to run when a customer is created, e.g., logging or validation
            Console.WriteLine($"Customer {Name} with ID {Id} has been created.");
        }

        // Implementing the partial method to handle email updates
        partial void OnEmailUpdated()
        {
            // Logic to run when a customer's email is updated, e.g., sending a notification
            Console.WriteLine($"Customer {Name} has updated their email to {Email}.");
        }
    }
}