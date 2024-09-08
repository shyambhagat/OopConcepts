namespace ExtensionMethodsConcepts
{
    public static class DateTimeExtensions
    {
        // Extension method to check if a DateTime is a weekend
        public static bool IsWeekend(this DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;
        }

        // Extension method to get the start of the week for a DateTime
        public static DateTime StartOfWeek(this DateTime dateTime, DayOfWeek startOfWeek = DayOfWeek.Monday)
        {
            int diff = (7 + (dateTime.DayOfWeek - startOfWeek)) % 7;
            return dateTime.AddDays(-1 * diff).Date;
        }

        // Extension method to calculate the age in years based on a birthdate
        public static int CalculateAge(this DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        // Extension method to check if a DateTime is in the future
        public static bool IsFutureDate(this DateTime dateTime)
        {
            return dateTime > DateTime.Now;
        }
    }
}