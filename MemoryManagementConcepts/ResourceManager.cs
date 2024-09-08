using System;

namespace MemoryManagementConcepts
{
    public class ResourceManager : IDisposable
    {
        private UnmanagedResource _unmanagedResource;
        private bool _disposed = false;

        // Constructor
        public ResourceManager()
        {
            _unmanagedResource = new UnmanagedResource();
            Console.WriteLine("ResourceManager created.");
        }

        // Implementing IDisposable interface
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected virtual method for cleaning up resources
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources here
                    if (_unmanagedResource != null)
                    {
                        _unmanagedResource.Dispose();
                        _unmanagedResource = null;
                    }
                    Console.WriteLine("ResourceManager: Managed resources cleaned up.");
                }

                // Dispose unmanaged resources here if any

                _disposed = true;
            }
        }

        // Finalizer
        ~ResourceManager()
        {
            Dispose(false);
        }
    }
}