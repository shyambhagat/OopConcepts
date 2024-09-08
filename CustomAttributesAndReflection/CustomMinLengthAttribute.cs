namespace CustomAttributesAndReflection
{
    // Attribute to ensure that a string value has a minimum length
    [AttributeUsage(AttributeTargets.Property)]
    public class CustomMinLengthAttribute : Attribute
    {
        public int Length { get; }
        public string ErrorMessage { get; }

        public CustomMinLengthAttribute(int length, string errorMessage)
        {
            Length = length;
            ErrorMessage = errorMessage;
        }

        public bool IsValid(string value)
        {
            return value != null && value.Length >= Length;
        }
    }
}