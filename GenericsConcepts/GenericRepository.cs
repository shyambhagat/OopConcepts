using System;
using System.Collections.Generic;

namespace GenericsConcepts
{
    // A generic repository class with a constraint to ensure the type is an Entity
    public class GenericRepository<T> where T : Entity
    {
        private List<T> _entities = new List<T>();

        // Method to add an entity to the repository
        public void Add(T entity)
        {
            _entities.Add(entity);
            Console.WriteLine($"Added {typeof(T).Name} with ID: {entity.Id}");
        }

        // Method to retrieve an entity by ID
        public T GetById(int id)
        {
            return _entities.Find(e => e.Id == id);
        }

        // Method to get all entities
        public List<T> GetAll()
        {
            return _entities;
        }

        // Method to remove an entity by ID
        public void Remove(int id)
        {
            var entityToRemove = GetById(id);
            if (entityToRemove != null)
            {
                _entities.Remove(entityToRemove);
                Console.WriteLine($"Removed {typeof(T).Name} with ID: {id}");
            }
        }
    }
}