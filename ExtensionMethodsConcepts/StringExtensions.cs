namespace ExtensionMethodsConcepts
{
    public static class StringExtensions
    {
        // Extension method to count the number of words in a string
        public static int WordCount(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        // Extension method to check if a string is a palindrome
        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            str = str.ToLower().Replace(" ", string.Empty); // Normalize the string
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);

            return str == reversedStr;
        }

        // Extension method to reverse a string
        public static string Reverse(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Extension method to truncate a string to a specified length
        public static string Truncate(this string str, int length)
        {
            if (string.IsNullOrEmpty(str) || str.Length <= length)
            {
                return str;
            }

            return str.Substring(0, length) + "...";
        }
    }
}