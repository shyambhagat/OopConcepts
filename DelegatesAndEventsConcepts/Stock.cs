using System;

namespace DelegatesAndEventsConcepts
{
    // Delegate for stock price events
    public delegate void StockPriceChangeHandler();

    // Stock class that monitors price changes
    public class Stock
    {
        private double _price;

        // Event triggered when the price goes above a threshold
        public event StockPriceChangeHandler OnPriceAboveThreshold;

        // Event triggered when the price goes below a threshold
        public event StockPriceChangeHandler OnPriceBelowThreshold;

        // Property to get or set the stock price
        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                // Trigger events based on the price
                if (_price > UpperThreshold)
                {
                    OnPriceAboveThreshold?.Invoke();
                }
                if (_price < LowerThreshold)
                {
                    OnPriceBelowThreshold?.Invoke();
                }
            }
        }

        // Property to set the upper threshold
        public double UpperThreshold { get; set; }

        // Property to set the lower threshold
        public double LowerThreshold { get; set; }
    }
}