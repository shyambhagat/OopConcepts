namespace ExceptionHandlingConcepts;

public class OrderProcessor
{
    private readonly PaymentProcessor _paymentProcessor;

    public OrderProcessor()
    {
        _paymentProcessor = new PaymentProcessor();
    }

    public void ProcessOrder(Order order)
    {
        try
        {
            // Validate order quantity
            if (order.Quantity <= 0)
            {
                throw new InvalidOrderQuantityException(order.Quantity);
            }

            // Check product stock
            if (order.Product.Stock < order.Quantity)
            {
                throw new OutOfStockException(order.Product.Name);
            }

            // Calculate total price
            order.TotalPrice = order.Product.Price * order.Quantity;

            // Process payment
            _paymentProcessor.ProcessPayment(order);

            // Deduct stock after successful payment
            order.Product.Stock -= order.Quantity;

            Console.WriteLine("Order processed successfully.");
        }
        catch (OutOfStockException ex)
        {
            // Log exception and rethrow
            LogException(ex);
            throw;
        }
        catch (InvalidOrderQuantityException ex)
        {
            // Handle and log invalid order quantity
            LogException(ex);
        }
        catch (PaymentFailedException ex)
        {
            // Handle payment failure
            LogException(ex);
        }
        finally
        {
            Console.WriteLine("Order processing completed.");
        }
    }

    private void LogException(Exception ex)
    {
        // Basic logging to the console
        Console.WriteLine($"Exception: {ex.Message}");
    }
}