using System;

namespace AbstractClassesConcepts
{
    // Represents an options contract.
    internal class OptionsProduct : ForwardProduct, IOptionsTrade
    {
        public override void Terminate()
        {
            Console.WriteLine($"Terminating Options Contract for Customer {CustomerNumber}. Penalty applied: {Penalty:C}");
            Penalty = 200; // Higher penalty for options
        }

        public override double Settle()
        {
            double settlementAmount = TradedAmount - Penalty;
            Console.WriteLine($"Settling Options Contract for Customer {CustomerNumber}. Settlement Amount: {settlementAmount:C}");
            return settlementAmount;
        }

        // Implementing IOptionsTrade interface methods.
        public void Call()
        {
            Console.WriteLine($"Executing Call Option for Customer {CustomerNumber}.");
        }

        public void Put()
        {
            Console.WriteLine($"Executing Put Option for Customer {CustomerNumber}.");
        }
    }
}