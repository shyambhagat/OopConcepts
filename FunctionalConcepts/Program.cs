// Create a product repository
using FunctionalConcepts;

var productRepository = new ProductRepository();

// Add some products
productRepository.AddProduct(new Product { Id = 1, Name = "Laptop", Price = 1000, IsAvailable = true });
productRepository.AddProduct(new Product { Id = 2, Name = "Smartphone", Price = 500, IsAvailable = false });
productRepository.AddProduct(new Product { Id = 3, Name = "Tablet", Price = 300, IsAvailable = true });

// Use a functor to apply a 10% discount
var discountFunctor = new DiscountFunctor(price => price * 0.9);

var product = productRepository.FindById(1);
if (product != null)
{
    Console.WriteLine($"Original Price of {product.Name}: {product.Price:C}");
    product.Price = discountFunctor.Apply(product.Price);
    Console.WriteLine($"Discounted Price of {product.Name}: {product.Price:C}");
}

// Use a predicate to filter available products
Predicate<Product> isAvailable = p => p.IsAvailable;
List<Product> availableProducts = productRepository.FilterProducts(isAvailable);

Console.WriteLine("\nAvailable Products:");
availableProducts.ForEach(p => Console.WriteLine($"{p.Name} - {p.Price:C}"));

// Use an action to print details of each product
Action<Product> printProductDetails = p =>
{
    Console.WriteLine($"Product ID: {p.Id}, Name: {p.Name}, Price: {p.Price:C}, Available: {p.IsAvailable}");
};

Console.WriteLine("\nAll Products:");
productRepository.ForEachProduct(printProductDetails);

//static double ApplyDiscount(double price)
//{
//    return price * 0.9;
//}

//static bool IsProductAvailable(Product product)
//{
//    return product.IsAvailable;
//}

//static void PrintProduct(Product product)
//{
//    Console.WriteLine($"{product.Name} - {product.Price:C}");
//}

//static void PrintProductDetails(Product product)
//{
//    Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}, Price: {product.Price:C}, Available: {product.IsAvailable}");
//}