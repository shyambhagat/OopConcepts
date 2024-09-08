using ConversionConcepts;
using System;
using System.Collections.Generic;
using System.Linq;

#region Conversion Concepts

// 1. is Operator with Type Patterns
var person = new Person { Name = "John Doe", Age = 30 };
if (person is Customer customer)
{
    Console.WriteLine($"Customer found: {customer.Name}, Email: {customer.Email}");
}
else
{
    Console.WriteLine($"Person is not a Customer.");
}

// 2. Convert Class
string strNumber = "123";
int number = Convert.ToInt32(strNumber);
Console.WriteLine($"Converted number: {number}");

// 3. TryParse Methods
if (int.TryParse("456", out int result))
{
    Console.WriteLine($"TryParse succeeded: {result}");
}
else
{
    Console.WriteLine("TryParse failed.");
}

// 4. Boxing and Unboxing
object boxedValue = 42; // Boxing
int unboxedValue = (int)boxedValue; // Unboxing
Console.WriteLine($"Boxed value: {boxedValue}, Unboxed value: {unboxedValue}");

// 5. System.Convert and IConvertible Interface
double pi = 3.14;
int roundedPi = Convert.ToInt32(pi);
Console.WriteLine($"Rounded Pi: {roundedPi}");

// 6. Type Conversion in LINQ Queries
IEnumerable<object> objects = new List<object> { "Hello", 123, "World" };
var strings = objects.OfType<string>(); // Filters and casts to string
Console.WriteLine("Strings from objects:");
foreach (var str in strings)
{
    Console.WriteLine(str);
}

// 7. Downcasting and Upcasting
Person employeeAsPerson = new Employee { Name = "Alice", EmployeeId = "E001", Salary = 60000 };
if (employeeAsPerson is Employee downcastedEmployee)
{
    Console.WriteLine($"Downcasted Employee: {downcastedEmployee.Name}, Salary: {downcastedEmployee.Salary}");
}

// 8. Nullable Types Conversion
int? nullableInt = null;
int nonNullableInt = nullableInt ?? 0; // Coalescing operator used for conversion
Console.WriteLine($"Nullable to non-nullable conversion: {nonNullableInt}");

#endregion
