using System;

namespace AbstractClassesConcepts
{
    // Represents a non-deliverable forward (NDF) contract.
    internal class NonDeliverableForwardProduct : BaseProduct, ITrade
    {
        public int CustomerNumber { get; set; }
        public double Penalty { get; set; }

        public override void Terminate()
        {
            Console.WriteLine($"Terminating NDF Contract for Customer {CustomerNumber}. Penalty applied: {Penalty:C}");
            Penalty = 150; // Example penalty for NDF
        }

        public override double Settle()
        {
            double settlementAmount = TradedAmount - Penalty;
            Console.WriteLine($"Settling NDF Contract for Customer {CustomerNumber}. Settlement Amount: {settlementAmount:C}");
            return settlementAmount;
        }

        public double PerformTrade(double tradeAmount)
        {
            TradedAmount = tradeAmount;
            Console.WriteLine($"Performed NDF trade for Customer {CustomerNumber}. Trade Amount: {TradedAmount:C}");
            return TradedAmount;
        }

        public double Withdraw(double withdrawAmount)
        {
            Console.WriteLine($"Withdrawn {withdrawAmount:C} from NDF Contract of Customer {CustomerNumber}");
            return withdrawAmount;
        }
    }
}