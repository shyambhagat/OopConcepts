namespace CustomAttributesAndReflection
{
    public class Customer
    {
        [CustomRequired("Customer ID is required")]
        public string CustomerId { get; set; }

        [CustomMinLength(3, "Customer name must be at least 3 characters long")]
        public string Name { get; set; }

        [CustomEmail("Invalid email format")]
        public string Email { get; set; }
    }
}