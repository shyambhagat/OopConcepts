namespace CustomAttributesAndReflection
{
    // Attribute to ensure that a string is a valid email format
    [AttributeUsage(AttributeTargets.Property)]
    public class CustomEmailAttribute : Attribute
    {
        public string ErrorMessage { get; }

        public CustomEmailAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public bool IsValid(string value)
        {
            return value != null && value.Contains("@");
        }
    }
}