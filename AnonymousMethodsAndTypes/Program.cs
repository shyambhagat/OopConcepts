using AnonymousMethodsAndTypes;

// Create a list of products
List<Product> products = new List<Product>
{
    new Product { Id = 1, Name = "Laptop", Price = 1000, Category = "Electronics" },
    new Product { Id = 2, Name = "Smartphone", Price = 500, Category = "Electronics" },
    new Product { Id = 3, Name = "Tablet", Price = 300, Category = "Electronics" },
    new Product { Id = 4, Name = "Chair", Price = 100, Category = "Furniture" },
    new Product { Id = 5, Name = "Desk", Price = 200, Category = "Furniture" }
};

// Use an anonymous method to filter the products by category
List<Product> electronics = products.FindAll(delegate (Product p)
{
    return p.Category == "Electronics";
});

// Sort the filtered products by price using an anonymous method
electronics.Sort(delegate (Product p1, Product p2)
{
    return p1.Price.CompareTo(p2.Price);
});

// Display the filtered and sorted products
Console.WriteLine("Filtered and Sorted Electronics:");
foreach (var product in electronics)
{
    Console.WriteLine($"Product: {product.Name}, Price: {product.Price:C}");
}

// Use an anonymous type to project the results
var productSummaries = electronics.Select(p => new
{
    p.Name,
    p.Price
});

Console.WriteLine("\nProduct Summaries:");
foreach (var summary in productSummaries)
{
    Console.WriteLine($"Name: {summary.Name}, Price: {summary.Price:C}");
}