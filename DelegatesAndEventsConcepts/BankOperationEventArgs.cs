namespace DelegatesAndEventsConcepts
{
    // Custom EventArgs to pass additional data with the event
    public class BankOperationEventArgs : EventArgs
    {
        public string Operation { get; set; }
        public double Amount { get; set; }
        public double Balance { get; set; }
    }
}