using System;

namespace InterfaceConcepts
{
    internal class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        // Overrides ToString for easy CSV conversion.
        public override string ToString()
        {
            return $"{Id},{FullName},{Address},{City},{Region},{PostalCode},{Country}";
        }
    }
}