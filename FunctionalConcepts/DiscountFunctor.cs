using System;

namespace FunctionalConcepts
{
    // Functor to apply discounts to a product's price
    public class DiscountFunctor
    {
        private Func<double, double> _discountStrategy;

        public DiscountFunctor(Func<double, double> discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        // Apply the discount strategy to the product's price
        public double Apply(double price)
        {
            return _discountStrategy(price);
        }
    }
}