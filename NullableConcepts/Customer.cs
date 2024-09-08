namespace NullableConcepts
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; } // Nullable reference type
        public string? PhoneNumber { get; set; } // Nullable reference type
        public List<Order>? Orders { get; set; } // Nullable reference type

        public Customer(int id, string name, string? email = null, string? phoneNumber = null)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders ??= new List<Order>(); // Null-coalescing assignment
            Orders.Add(order);
        }
    }
}