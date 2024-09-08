using System;

namespace MemoryManagementConcepts
{
    public class UnmanagedResource : IDisposable
    {
        private bool _disposed = false;

        // Constructor to allocate the unmanaged resource
        public UnmanagedResource()
        {
            Console.WriteLine("UnmanagedResource acquired.");
        }

        // Implementing IDisposable interface
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Suppress finalization as cleanup is done
        }

        // Protected virtual method for cleaning up resources
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Clean up managed resources here, if any
                    Console.WriteLine("Cleaning up managed resources.");
                }

                // Clean up unmanaged resources here
                Console.WriteLine("Cleaning up unmanaged resources.");

                _disposed = true;
            }
        }

        // Finalizer (destructor) for this class
        ~UnmanagedResource()
        {
            Dispose(false);
            Console.WriteLine("Finalizer called.");
        }
    }
}