namespace ExceptionHandlingConcepts;

public class PaymentProcessor
{
    // Simulates payment processing
    public void ProcessPayment(Order order)
    {
        // Simulate a payment failure for demonstration purposes
        throw new PaymentFailedException("Insufficient funds.");
    }
}