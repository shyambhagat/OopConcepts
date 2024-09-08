namespace CustomAttributesAndReflection
{
    // Attribute to ensure that a numeric value falls within a specified range
    [AttributeUsage(AttributeTargets.Property)]
    public class CustomRangeAttribute : Attribute
    {
        public double Minimum { get; }
        public double Maximum { get; }
        public string ErrorMessage { get; }

        public CustomRangeAttribute(double minimum, double maximum, string errorMessage)
        {
            Minimum = minimum;
            Maximum = maximum;
            ErrorMessage = errorMessage;
        }

        public bool IsValid(double value)
        {
            return value >= Minimum && value <= Maximum;
        }
    }
}