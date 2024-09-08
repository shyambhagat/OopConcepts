using System;

namespace AbstractClassesConcepts
{
    // Abstract base class representing a financial product.
    public abstract class BaseProduct
    {
        public string ProductDescription { get; set; }
        public DateTime TradeDate { get; set; }
        public DateTime ValueDate { get; set; }
        public double TradedAmount { get; set; }

        // Abstract methods to be implemented by derived classes.
        public abstract void Terminate();
        public abstract double Settle();
    }
}