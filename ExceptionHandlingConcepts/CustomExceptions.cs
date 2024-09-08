namespace ExceptionHandlingConcepts
{
    // Custom exception for out-of-stock scenarios
    public class OutOfStockException : Exception
    {
        public OutOfStockException(string productName)
            : base($"The product '{productName}' is out of stock.")
        {
        }
    }

    // Custom exception for invalid order quantity
    public class InvalidOrderQuantityException : Exception
    {
        public InvalidOrderQuantityException(int quantity)
            : base($"The order quantity '{quantity}' is invalid.")
        {
        }
    }

    // Custom exception for failed payment processing
    public class PaymentFailedException : Exception
    {
        public PaymentFailedException(string reason)
            : base($"Payment processing failed: {reason}.")
        {
        }
    }
}