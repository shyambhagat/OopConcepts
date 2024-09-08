namespace CustomAttributesAndReflection
{
    public class Order
    {
        [CustomRequired("Customer is required")]
        public Customer Customer { get; set; }

        [CustomRequired("Product is required")]
        public Product Product { get; set; }

        [CustomRange(1, int.MaxValue, "Quantity must be greater than zero")]
        public int Quantity { get; set; }

        public double TotalPrice => Product.Price * Quantity;
    }
}