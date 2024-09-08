using System;

namespace AbstractClassesConcepts
{
    // Represents a forward contract, a type of financial product.
    internal class ForwardProduct : BaseProduct, ITrade
    {
        public int CustomerNumber { get; set; }
        public double Penalty { get; set; }

        // Implementing the abstract method from BaseProduct.
        public override void Terminate()
        {
            Console.WriteLine($"Terminating Forward Contract for Customer {CustomerNumber}. Penalty applied: {Penalty:C}");
            Penalty = 100; // Example penalty
        }

        // Implementing the abstract method from BaseProduct.
        public override double Settle()
        {
            double settlementAmount = TradedAmount - Penalty;
            Console.WriteLine($"Settling Forward Contract for Customer {CustomerNumber}. Settlement Amount: {settlementAmount:C}");
            return settlementAmount;
        }

        // Implementing ITrade interface methods.
        public double PerformTrade(double tradeAmount)
        {
            TradedAmount = tradeAmount;
            Console.WriteLine($"Performed trade for Customer {CustomerNumber}. Trade Amount: {TradedAmount:C}");
            return TradedAmount;
        }

        public double Withdraw(double withdrawAmount)
        {
            Console.WriteLine($"Withdrawn {withdrawAmount:C} from Forward Contract of Customer {CustomerNumber}");
            return withdrawAmount;
        }
    }
}