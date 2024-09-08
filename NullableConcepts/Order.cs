namespace NullableConcepts
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public DateTime? OrderDate { get; set; } // Nullable value type

        public Order(int id, Customer customer, List<Product> products, DateTime? orderDate = null)
        {
            Id = id;
            Customer = customer;
            Products = products;
            OrderDate = orderDate;
        }

        public decimal CalculateTotalAmount()
        {
            return Products.Sum(p => p.Price);
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine($"Order ID: {Id}");
            Console.WriteLine($"Customer: {Customer.Name}");
            Console.WriteLine($"Order Date: {OrderDate?.ToShortDateString() ?? "Date not specified"}"); // Null-coalescing operator with safe navigation
            Console.WriteLine("Products:");
            foreach (var product in Products)
            {
                Console.WriteLine($"- {product.Name}: {product.Price:C}");
            }
            Console.WriteLine($"Total Amount: {CalculateTotalAmount():C}");
        }
    }
}