namespace AbstractClassesConcepts
{
    internal interface ITrade
    {
        int CustomerNumber { get; set; }
        double PerformTrade(double tradeAmount);
        double Withdraw(double withdrawAmount);
    }
}