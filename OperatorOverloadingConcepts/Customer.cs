using System;

namespace OperatorOverloadingConcepts
{
    internal class Customer
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public double Wealth { get; set; }

        // Operator overloading for adding wealth of two customers.
        public static double operator +(Customer c1, Customer c2)
        {
            return c1.Wealth + c2.Wealth;
        }

        // Operator overloading for subtracting wealth between two customers.
        public static double operator -(Customer c1, Customer c2)
        {
            return c1.Wealth - c2.Wealth;
        }

        // Operator overloading for comparing the wealth of two customers.
        public static bool operator >(Customer c1, Customer c2)
        {
            return c1.Wealth > c2.Wealth;
        }

        public static bool operator <(Customer c1, Customer c2)
        {
            return c1.Wealth < c2.Wealth;
        }

        // Operator overloading for merging customer details.
        public static Customer operator +(Customer c1, string additionalAddress)
        {
            return new Customer
            {
                FullName = c1.FullName,
                Address = $"{c1.Address}, {additionalAddress}",
                Wealth = c1.Wealth
            };
        }

        // Overriding ToString to provide meaningful output.
        public override string ToString()
        {
            return $"Customer: {FullName}, Address: {Address}, Wealth: {Wealth:C}";
        }
    }
}