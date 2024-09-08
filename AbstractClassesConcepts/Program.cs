using AbstractClassesConcepts;

Console.WriteLine("Abstract Classes and Financial Products Example");

// Forward Contract Example
var forwardContract = new ForwardProduct { CustomerNumber = 1001, ProductDescription = "Forward Contract", TradedAmount = 10000, TradeDate = DateTime.Now };
forwardContract.PerformTrade(12000);
forwardContract.Terminate();
forwardContract.Settle();

// Non-Deliverable Forward Contract Example
var ndfContract = new NonDeliverableForwardProduct { CustomerNumber = 1002, ProductDescription = "Non-Deliverable Forward Contract", TradedAmount = 15000, TradeDate = DateTime.Now };
ndfContract.PerformTrade(18000);
ndfContract.Terminate();
ndfContract.Settle();

// Options Contract Example
var optionsContract = new OptionsProduct { CustomerNumber = 1003, ProductDescription = "Options Contract", TradedAmount = 20000, TradeDate = DateTime.Now };
optionsContract.Call();
optionsContract.Put();
optionsContract.Terminate();
optionsContract.Settle();