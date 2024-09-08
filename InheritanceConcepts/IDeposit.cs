namespace InheritanceConcepts
{
    // Interface for deposit operations.
    internal interface IDeposit
    {
        void Deposit(int accountId, double amount);
    }
}