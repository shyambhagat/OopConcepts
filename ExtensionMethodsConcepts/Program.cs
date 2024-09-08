using ExtensionMethodsConcepts;


// String Extensions Examples
string sentence = "Hello, how are you doing today?";
Console.WriteLine($"The sentence \"{sentence}\" has {sentence.WordCount()} words.");

string palindromeTest = "A man a plan a canal Panama";
Console.WriteLine($"Is \"{palindromeTest}\" a palindrome? {palindromeTest.IsPalindrome()}");

string reversedString = "Extension Methods".Reverse();
Console.WriteLine($"Reversed string: {reversedString}");

string longSentence = "This is a long sentence that needs to be truncated.";
Console.WriteLine($"Truncated sentence: {longSentence.Truncate(20)}");

// Integer Extensions Examples
int number = 5;
Console.WriteLine($"{number} is even: {number.IsEven()}");
Console.WriteLine($"Factorial of {number}: {number.Factorial()}");
Console.WriteLine($"{number} as an ordinal: {number.ToOrdinal()}");
Console.WriteLine($"{number} is prime: {number.IsPrime()}");

// DateTime Extensions Examples
DateTime today = DateTime.Now;
Console.WriteLine($"Is today a weekend? {today.IsWeekend()}");
Console.WriteLine($"Start of the week: {today.StartOfWeek():d}");

DateTime birthDate = new DateTime(1990, 1, 1);
Console.WriteLine($"Age calculated from {birthDate:d}: {birthDate.CalculateAge()} years old.");
Console.WriteLine($"Is tomorrow a future date? {DateTime.Now.AddDays(1).IsFutureDate()}");

// List Extensions Examples
List<string> names = new List<string> { "Alice", "Bob", "Charlie", "Alice", "Charlie", "Charlie" };
Console.WriteLine($"Most frequent name: {names.MostFrequent()}");

names.Shuffle();
Console.WriteLine("Shuffled names: " + string.Join(", ", names));

names.AddIfNotExists("David");
Console.WriteLine("Names after adding 'David' if not exists: " + string.Join(", ", names));
