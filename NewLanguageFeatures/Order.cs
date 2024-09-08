namespace NewLanguageFeatures
{
    public class Order
    {
        // Using Tuples and Null-Coalescing Assignment Operator
        private List<Product> _products;

        public List<Product> Products
        {
            get => _products ??= new List<Product>(); // Null-Coalescing Assignment
        }

        // Target-Typed new Expressions
        public void AddProduct(Product product) => Products.Add(product);

        // Mimicking With Expressions using a custom method
        public Order WithDiscount(decimal discountPercentage)
        {
            var discountedProducts = Products.Select(p => p.WithPrice(p.Price - (p.Price * discountPercentage / 100))).ToList();

            return new Order { _products = discountedProducts };
        }

        // Local Function to Calculate Total Price
        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }

            // Local Function to apply tax
            decimal ApplyTax(decimal subtotal) => subtotal * 1.15m;

            return ApplyTax(total);
        }

        // Overriding ToString to demonstrate Interpolated String Improvements
        public override string ToString() => $"Order with {Products.Count} products: {JsonSerializer.Serialize(Products, new JsonSerializerOptions { WriteIndented = true })}";
    }
}