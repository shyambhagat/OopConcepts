namespace NewLanguageFeatures
{
    public class Product
    {
        // Read-Only Property
        public int Id { get; }

        // Init-Only Setter
        public string Name { get; init; }

        // Underscore in Numeric Literals
        public decimal Price { get; init; } = 1_000m;

        // Constructor using init-only setters
        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // Method demonstrating Switch Expressions
        public string GetProductCategory()
        {
            return Name switch
            {
                "Laptop" => "Electronics",
                "Table" => "Furniture",
                _ => "Miscellaneous"
            };
        }

        // Method to create a copy of the product with a modified price (mimicking 'with' behavior)
        public Product WithPrice(decimal newPrice)
        {
            return new Product(Id, Name) { Price = newPrice };
        }
    }
}