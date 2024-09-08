using System;
using System.Collections.Generic;

namespace FunctionalConcepts
{
    public class ProductRepository
    {
        private List<Product> _products = new List<Product>();

        // Add a product to the repository
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        // Use a Predicate to filter products
        public List<Product> FilterProducts(Predicate<Product> condition)
        {
            return _products.FindAll(condition);
        }

        // Execute an action on each product in the repository
        public void ForEachProduct(Action<Product> action)
        {
            _products.ForEach(action);
        }

        // Find a product by ID
        public Product FindById(int id)
        {
            return _products.Find(p => p.Id == id);
        }
    }
}