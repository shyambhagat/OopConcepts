using System;

namespace CustomAttributesAndReflection
{
    // Attribute to ensure that a value is not null or empty
    [AttributeUsage(AttributeTargets.Property)]
    public class CustomRequiredAttribute : Attribute
    {
        public string ErrorMessage { get; }

        public CustomRequiredAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public bool IsValid(object value)
        {
            if (value is string strValue)
            {
                return !string.IsNullOrWhiteSpace(strValue);
            }
            return value != null;
        }
    }
}

using System;

using System;

using System;