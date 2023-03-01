namespace BasicAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1: Compute the sum of the two given integer values.
            //If the two values are the same, then return triple their sum:

            Console.WriteLine("Problem 1:");

            Console.WriteLine(SumOfTheTwoValues(1, 2));
            Console.WriteLine(SumOfTheTwoValues(2, 2));
            Console.WriteLine(SumOfTheTwoValues(5, 2));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 2: Get the absolute difference between n and 51.
            //If n is greater than 51 return triple the absolute difference:

            Console.WriteLine("Problem 2:");
            Console.WriteLine(TakeDifference(47));
            Console.WriteLine(TakeDifference(51));
            Console.WriteLine(TakeDifference(55));
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 3:Check two given integers, and return true if one of them is 30 or if their sum is 30:

            Console.WriteLine("Problem 3:");

            Console.WriteLine(CheckIntegers(30, 2));
            Console.WriteLine(CheckIntegers(22, 2));
            Console.WriteLine(CheckIntegers(28, 2));
            Console.WriteLine(CheckIntegers(5, 30));
            Console.WriteLine(CheckIntegers(30, 30));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 4: Check a given integer and return true if it is within 10 of 100 or 200:

            Console.WriteLine("Problem 4:");
            Console.WriteLine(IntegerInRange(103));
            Console.WriteLine(IntegerInRange(90));
            Console.WriteLine(IntegerInRange(89));
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 5: Create a new string where 'if' is added to the front of a given string.
            //If the string already begins with 'if', return the string unchanged:

            Console.WriteLine("Problem 5:");

            Console.WriteLine(CreateString("if else"));
            Console.WriteLine(CreateString("if else else"));
            Console.WriteLine(CreateString("else"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 6: Remove the character in a given position of a given string.
            //The given position will be in the range 0.. string length -1 inclusive:

            Console.WriteLine("Problem 6:");

            Console.WriteLine(RemoveChar("Python", 1));
            Console.WriteLine(RemoveChar("Python", 0));
            Console.WriteLine(RemoveChar("Python", 4));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 7: Exchange the first and last characters in a given string and return the new string:

            Console.WriteLine("Problem 7:");

            Console.WriteLine(ReplaceChar("abcd"));
            Console.WriteLine(ReplaceChar("a"));
            Console.WriteLine(ReplaceChar("xy"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 8: Create a new string which is 4 copies of the 2 front characters of a given string.
            //If the given string length is less than 2 return the original string:

            Console.WriteLine("Problem 8:");

            //Solution A with  range indexer:

            Console.WriteLine(CreateWithRangeIndexer("C Sharp"));
            Console.WriteLine(CreateWithRangeIndexer("JS"));
            Console.WriteLine(CreateWithRangeIndexer("S"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Solution B with Substring:

            Console.WriteLine(CreateWithSubstring("C Sharp"));
            Console.WriteLine(CreateWithSubstring("JS"));
            Console.WriteLine(CreateWithSubstring("S"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();
        }

        private static string CreateWithSubstring(string text)
        {
            return text.Length < 2
                ? text
                : text.Substring(0, 2) + text.Substring(0, 2) + text.Substring(0, 2) + text.Substring(0, 2);
        }

        private static string CreateWithRangeIndexer(string text)
        {
            return text.Length < 2
                ? text
                : text[..2] + text[..2] + text[..2] + text[..2];
        }

        private static string ReplaceChar(string input)
        {
            return input.Length > 1
                ? input[^1..] + input.Substring(1, input.Length - 2) + input[..1]
                : input;
        }

        private static string RemoveChar(string item, int index)
        {
            var result = item.Remove(index, 1);

            return result;
        }

        private static string CreateString(string input)
        {
            var parts = input.Split(" ");

            return parts[0] != "if" ? input.Insert(0, "if ") : input;
        }

        private static bool IntegerInRange(int n)
        {
            return Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10;
        }

        private static bool CheckIntegers(int x, int y)
        {
            return x == 30 || y == 30 || (x + y == 30);
        }

        private static int TakeDifference(int n)
        {
            const int levelNum = 51;

            if (n > levelNum)
            {
                return (n - levelNum) * 3;
            }

            return levelNum - n;
        }

        private static int SumOfTheTwoValues(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}