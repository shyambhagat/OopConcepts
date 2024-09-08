namespace CustomAttributesAndReflection
{
    public class Product
    {
        [CustomMinLength(2, "Product name must be at least 2 characters long")]
        public string ProductName { get; set; }

        [CustomRange(0.01, double.MaxValue, "Price must be greater than zero")]
        public double Price { get; set; }

        [CustomRange(0, int.MaxValue, "Stock must be non-negative")]
        public int Stock { get; set; }
    }
}