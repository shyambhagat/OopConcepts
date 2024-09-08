namespace GenericsConcepts
{
    // A class representing an Order, derived from Entity
    public class Order : Entity
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
    }
}