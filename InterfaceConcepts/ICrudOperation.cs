using System;
using System.Collections.Generic;

namespace InterfaceConcepts
{
    internal interface ICrudOperation<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entry);
        void Update(T entry);
        void Delete(T entry);
    }
}