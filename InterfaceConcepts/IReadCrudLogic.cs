using System;
using System.Collections.Generic;

namespace InterfaceConcepts
{
    internal interface IReadCrudLogic<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
    }
}