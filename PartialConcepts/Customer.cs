namespace PartialConcepts
{
    // Partial class Customer: manages customer data
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Partial method: can be implemented in another part of the class
        partial void OnCustomerCreated();

        // Constructor
        public Customer(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;

            // Call the partial method (if implemented)
            OnCustomerCreated();
        }
    }
}