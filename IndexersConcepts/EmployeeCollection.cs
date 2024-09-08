using System;
using System.Collections.Generic;

namespace IndexersConcepts
{
    public class EmployeeCollection
    {
        // List to store Employee objects
        private List<Employee> employees = new List<Employee>();

        // Indexer to get or set Employee objects based on index
        public Employee this[int index]
        {
            get
            {
                if (index < 0 || index >= employees.Count)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
                return employees[index];
            }
            set
            {
                if (index < 0 || index >= employees.Count)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
                employees[index] = value;
            }
        }

        // Indexer to get Employee by their ID
        public Employee this[string id]
        {
            get
            {
                return employees.Find(e => e.Id.ToString() == id);
            }
        }

        // Method to add an Employee to the collection
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        // Method to get the number of Employees in the collection
        public int Count
        {
            get { return employees.Count; }
        }
    }
}