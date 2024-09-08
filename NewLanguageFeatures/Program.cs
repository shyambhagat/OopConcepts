using NewLanguageFeatures;

// Creating a new product with target-typed new expression
Product laptop = new(1, "Laptop");

// Demonstrating custom 'with' behavior by creating a modified copy
Product discountedLaptop = laptop.WithPrice(900m);

// Create an order and add products
Order order = new();
order.AddProduct(laptop);
order.AddProduct(new Product(2, "Table") { Price = 150m });

// Calculate total price including tax
Console.WriteLine($"Total Price (with Tax): {order.CalculateTotal():C}");

// Output the order details
Console.WriteLine(order);

// Applying discount and creating a new order with discounted prices
Order discountedOrder = order.WithDiscount(10);
Console.WriteLine($"Total Price after Discount (with Tax): {discountedOrder.CalculateTotal():C}");

// Output the discounted order details
Console.WriteLine(discountedOrder);