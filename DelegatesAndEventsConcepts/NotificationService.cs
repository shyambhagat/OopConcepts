using System;

namespace DelegatesAndEventsConcepts
{
    // NotificationService class that listens to bank account events
    public class NotificationService
    {
        // Method to handle the OnDeposit event
        public void OnDepositMade(object sender, BankOperationEventArgs e)
        {
            Console.WriteLine($"Notification: {e.Operation} of {e.Amount:C} made. New balance: {e.Balance:C}");
        }

        // Method to handle the OnWithdrawal event
        public void OnWithdrawalMade(object sender, BankOperationEventArgs e)
        {
            Console.WriteLine($"Notification: {e.Operation} of {e.Amount:C} made. New balance: {e.Balance:C}");
        }

        // Method to handle the stock price going above the threshold
        public void AlertPriceAboveThreshold()
        {
            Console.WriteLine("Alert: Stock price is above the upper threshold!");
        }

        // Method to handle the stock price going below the threshold
        public void AlertPriceBelowThreshold()
        {
            Console.WriteLine("Alert: Stock price is below the lower threshold!");
        }
    }
}