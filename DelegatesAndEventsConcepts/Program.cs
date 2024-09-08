// Create a notification service

using DelegatesAndEventsConcepts;

var notificationService = new NotificationService();

// Set up the BankAccount
var account = new BankAccount(1000);
account.OnDeposit += notificationService.OnDepositMade;
account.OnWithdrawal += notificationService.OnWithdrawalMade;

// Perform some banking operations
account.Deposit(200);   // Deposit event triggered
account.Withdraw(150);  // Withdrawal event triggered
account.Withdraw(1200); // Insufficient funds, no event triggered

// Set up the Stock
var stock = new Stock { Price = 100, UpperThreshold = 120, LowerThreshold = 80 };
stock.OnPriceAboveThreshold += notificationService.AlertPriceAboveThreshold;
stock.OnPriceBelowThreshold += notificationService.AlertPriceBelowThreshold;

// Simulate stock price changes
Console.WriteLine("Changing stock price...");
stock.Price = 125; // Above upper threshold, triggers OnPriceAboveThreshold event
stock.Price = 75;  // Below lower threshold, triggers OnPriceBelowThreshold event
stock.Price = 110; // No event triggered, within thresholds

