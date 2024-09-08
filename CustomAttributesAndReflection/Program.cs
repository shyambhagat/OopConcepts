using System;
using System.Reflection;
using CustomAttributesAndReflection;

#region Main Logic

var customer = new Customer { CustomerId = "C001", Name = "Al", Email = "aliceexample.com" };
var product = new Product { ProductName = "L", Price = -1200, Stock = 5 };
var order = new Order { Customer = customer, Product = product, Quantity = 0 };

ValidateObject(customer);
ValidateObject(product);
ValidateObject(order);

ReadPropertyValues(customer);
SetPropertyValue(customer, "Name", "Alice Smith");
ReadPropertyValues(customer);

#endregion

#region Reflection Methods

void ValidateObject(object obj)
{
    Console.WriteLine($"Validating {obj.GetType().Name}");

    var properties = obj.GetType().GetProperties();
    foreach (var prop in properties)
    {
        foreach (var attribute in prop.GetCustomAttributes())
        {
            bool isValid = true;
            string errorMessage = null;

            switch (attribute)
            {
                case CustomRequiredAttribute requiredAttr:
                    isValid = requiredAttr.IsValid(prop.GetValue(obj));
                    errorMessage = requiredAttr.ErrorMessage;
                    break;

                case CustomMinLengthAttribute minLengthAttr:
                    isValid = minLengthAttr.IsValid(prop.GetValue(obj) as string);
                    errorMessage = minLengthAttr.ErrorMessage;
                    break;

                case CustomRangeAttribute rangeAttr:
                    isValid = rangeAttr.IsValid(Convert.ToDouble(prop.GetValue(obj)));
                    errorMessage = rangeAttr.ErrorMessage;
                    break;

                case CustomEmailAttribute emailAttr:
                    isValid = emailAttr.IsValid(prop.GetValue(obj) as string);
                    errorMessage = emailAttr.ErrorMessage;
                    break;
            }

            if (!isValid)
            {
                Console.WriteLine($"Validation failed for {prop.Name}: {errorMessage}");
            }
            else
            {
                Console.WriteLine($"Validation passed for {prop.Name}");
            }
        }
    }

    Console.WriteLine();
}

void SetPropertyValue(object obj, string propertyName, object newValue)
{
    var prop = obj.GetType().GetProperty(propertyName);
    if (prop != null && prop.CanWrite)
    {
        prop.SetValue(obj, newValue);
        Console.WriteLine($"Set value of {propertyName} to {newValue}");
    }
    else
    {
        Console.WriteLine($"Property {propertyName} does not exist or cannot be written to.");
    }
}

void ReadPropertyValues(object obj)
{
    Console.WriteLine($"Reading properties of {obj.GetType().Name}");

    var properties = obj.GetType().GetProperties();
    foreach (var prop in properties)
    {
        var value = prop.GetValue(obj);
        Console.WriteLine($"{prop.Name}: {value}");
    }

    Console.WriteLine();
}

#endregion
