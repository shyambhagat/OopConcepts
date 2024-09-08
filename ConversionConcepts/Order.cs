namespace ConversionConcepts
{
    public class Order
    {
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice => Product.Price * Quantity;
    }
}