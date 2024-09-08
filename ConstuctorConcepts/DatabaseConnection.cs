using System;

namespace ConstructorConcepts
{
    internal class DatabaseConnection
    {
        // Private static field to hold the single instance of the class
        private static DatabaseConnection _instance;

        // Lock object for thread safety
        private static readonly object _lock = new object();

        // Private constructor to prevent direct instantiation
        private DatabaseConnection()
        {
            ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            ConnectionEstablishedTime = DateTime.Now;
        }

        // Public static property to provide global access to the instance
        public static DatabaseConnection Instance
        {
            get
            {
                // Ensure thread safety for the singleton instance
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnection();
                    }
                    return _instance;
                }
            }
        }

        // Example properties
        public string ConnectionString { get; }
        public DateTime ConnectionEstablishedTime { get; }

        // Method to simulate a query to the database
        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing query: {query}");
        }

        // Method to demonstrate the Singleton instance details
        public void ShowConnectionDetails()
        {
            Console.WriteLine($"Database connection established at: {ConnectionEstablishedTime}");
            Console.WriteLine($"Connection string: {ConnectionString}");
        }
    }
}