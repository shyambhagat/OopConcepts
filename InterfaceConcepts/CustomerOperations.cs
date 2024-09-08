using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InterfaceConcepts
{
    internal class CustomerRepository : IReadCrudLogic<Customer>, ICrudOperation<Customer>, IMultiCrudOperations<Customer>
    {
        private readonly string _filePath = "customers.csv";

        public CustomerRepository()
        {
            // Initialize CSV file with headers if not present
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "Id,FullName,Address,City,Region,PostalCode,Country\n");
            }
        }

        public List<Customer> GetAll()
        {
            return File.ReadAllLines(_filePath)
                       .Skip(1) // Skip header
                       .Select(line => FromCsv(line))
                       .ToList();
        }

        public Customer GetById(int id)
        {
            return GetAll().FirstOrDefault(c => c.Id == id);
        }

        public void Add(Customer entry)
        {
            entry.Id = GetAll().Count + 1;
            File.AppendAllText(_filePath, entry + "\n");
        }

        public void Update(Customer entry)
        {
            var customers = GetAll();
            var index = customers.FindIndex(c => c.Id == entry.Id);
            if (index >= 0)
            {
                customers[index] = entry;
                SaveAll(customers);
            }
        }

        public void Delete(Customer entry)
        {
            var customers = GetAll();
            var updatedCustomers = customers.Where(c => c.Id != entry.Id).ToList();
            SaveAll(updatedCustomers);
        }

        public void AddAll(List<Customer> entries)
        {
            foreach (var entry in entries)
            {
                Add(entry);
            }
        }

        public void UpdateAll(List<Customer> entries)
        {
            foreach (var entry in entries)
            {
                Update(entry);
            }
        }

        // Helper method to convert a CSV line to a Customer object.
        private Customer FromCsv(string csvLine)
        {
            var values = csvLine.Split(',');
            return new Customer
            {
                Id = int.Parse(values[0]),
                FullName = values[1],
                Address = values[2],
                City = values[3],
                Region = values[4],
                PostalCode = values[5],
                Country = values[6]
            };
        }

        // Helper method to save all customers to the CSV file.
        private void SaveAll(List<Customer> customers)
        {
            var csvLines = new List<string> { "Id,FullName,Address,City,Region,PostalCode,Country" };
            csvLines.AddRange(customers.Select(c => c.ToString()));
            File.WriteAllLines(_filePath, csvLines);
        }
    }
}
