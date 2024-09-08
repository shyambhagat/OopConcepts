namespace ExtensionMethodsConcepts
{
    public static class IntExtensions
    {
        // Extension method to check if an integer is even
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        // Extension method to calculate the factorial of an integer
        public static int Factorial(this int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }
            if (number == 0 || number == 1)
            {
                return 1;
            }

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        // Extension method to convert an integer to its ordinal string representation
        public static string ToOrdinal(this int number)
        {
            if (number < 0) return number.ToString();

            switch (number % 100)
            {
                case 11:
                case 12:
                case 13:
                    return number + "th";
            }

            switch (number % 10)
            {
                case 1:
                    return number + "st";
                case 2:
                    return number + "nd";
                case 3:
                    return number + "rd";
                default:
                    return number + "th";
            }
        }

        // Extension method to check if an integer is a prime number
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
