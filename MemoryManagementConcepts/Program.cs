using System;
using MemoryManagementConcepts;

#region Main Logic

// Using 'using' statement to ensure resources are cleaned up
using (var manager = new ResourceManager())
{
    Console.WriteLine("Using ResourceManager.");
}

// After 'using' block, resources are disposed, and finalizer won't be called

// Manual disposal (if not using 'using' block)
var manager2 = new ResourceManager();
manager2.Dispose();

Console.WriteLine("ResourceManager manually disposed.");

#endregion