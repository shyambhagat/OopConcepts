namespace InheritanceConcepts
{
    // Interface for withdrawal operations.
    internal interface IWithdrawal
    {
        void Withdraw(int accountId, double amount);
        void CompleteWithdraw(int accountId, double amount);
    }
}