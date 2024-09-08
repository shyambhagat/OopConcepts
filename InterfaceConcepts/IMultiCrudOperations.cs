using System;
using System.Collections.Generic;

namespace InterfaceConcepts
{
    internal interface IMultiCrudOperations<T> where T : class
    {
        void AddAll(List<T> entries);
        void UpdateAll(List<T> entries);
    }
}