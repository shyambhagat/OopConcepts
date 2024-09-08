namespace NullableConcepts
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; } // Nullable reference type

        public Product(int id, string name, decimal price, string? description = null)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }
    }
}