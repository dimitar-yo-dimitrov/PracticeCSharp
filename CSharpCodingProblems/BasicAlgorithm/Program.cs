﻿namespace BasicAlgorithm
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

            //Problem 9: Create a new string with the last char added at the front and back of a given string of length 1 or more:

            Console.WriteLine("Problem 9:");

            Console.WriteLine(CreateNewString("C Sharp"));
            Console.WriteLine(CreateNewString("JS"));
            Console.WriteLine(CreateNewString("S"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 10: Check if a given positive number is a multiple of 3 or a multiple of 7:

            Console.WriteLine("Problem 10:");

            Console.WriteLine(CheckNumber(3));
            Console.WriteLine(CheckNumber(14));
            Console.WriteLine(CheckNumber(12));
            Console.WriteLine(CheckNumber(37));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 11: Check if a given string starts with 'C#' or not:

            Console.WriteLine("Problem 11:");

            Console.WriteLine(CheckIfStartWith("C# Sharp"));
            Console.WriteLine(CheckIfStartWith("C#"));
            Console.WriteLine(CheckIfStartWith("C"));
            Console.WriteLine(CheckIfStartWith(""));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();


            //Problem 12: Check if one given temperatures is less than 0 and the other is greater than 100:

            Console.WriteLine("Problem 12:");

            Console.WriteLine(CheckRangeTemperature(102, -1));
            Console.WriteLine(CheckRangeTemperature(-1, 120));
            Console.WriteLine(CheckRangeTemperature(2, 120));
            Console.WriteLine(CheckRangeTemperature(-2, 99));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 13: Check two given integers whether either of them is in the range 100..200 inclusive:

            Console.WriteLine("Problem 13:");

            Console.WriteLine(CheckRange(100, 199));
            Console.WriteLine(CheckRange(250, 300));
            Console.WriteLine(CheckRange(105, -190));
            Console.WriteLine(CheckRange(-105, 190));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 14: Check whether three given integer values are in the range 20..50 inclusive.
            //Return true if 1 or more of them are in the said range otherwise false:

            Console.WriteLine("Problem 14:");

            Console.WriteLine(CheckRangeOfTheNums(11, 20, 12));
            Console.WriteLine(CheckRangeOfTheNums(30, 30, 17));
            Console.WriteLine(CheckRangeOfTheNums(25, 35, 50));
            Console.WriteLine(CheckRangeOfTheNums(15, 12, 8));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 15: Check if a string 'yt' appears at index 1 in a given string.
            //If it appears return a string without 'yt' otherwise return the original string:

            Console.WriteLine("Problem 15:");

            Console.WriteLine(CheckString("Python"));
            Console.WriteLine(CheckString("ytade"));
            Console.WriteLine(CheckString("jsues"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 16: Check the largest number among three given integers.

            Console.WriteLine("Problem 16:");

            Console.WriteLine(CheckTheLargestNum(11, 20, 12));
            Console.WriteLine(CheckTheLargestNum(30, 30, 17));
            Console.WriteLine(CheckTheLargestNum(25, 35, 50));
            Console.WriteLine(CheckTheLargestNum(15, 12, 8));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();
        }

        private static int CheckTheLargestNum(int numA, int numB, int numC)
        {
            var result = new List<int> { numA, numB, numC };

            return result.Max();
        }

        private static string CheckString(string word)
            => word
                .Substring(1, 2)
                .Equals("yt")
                ? word.Remove(1, 2)
                : word;

        private static bool CheckRangeOfTheNums(int numA, int numB, int numC)
            => numA is >= 20 and <= 50 ||
               numB is >= 20 and <= 50 ||
               numC is >= 20 and <= 50;

        private static bool CheckRange(int numA, int numB)
            => numA is >= 100 and <= 200 ||
               numB is >= 100 and <= 200;

        private static bool CheckRangeTemperature(int t0, int t1)
            => t0 is < 0 or > 100 &&
               t1 is < 0 or > 100;

        private static bool CheckIfStartWith(string text)
            => text.StartsWith("C#");

        private static bool CheckNumber(int n)
            => (n / 3) * 3 == n ||
               (n / 7) * 7 == n;

        private static string CreateNewString(string text)
            => string.Format("{0}{1}{0}", text[^1..], text);
        // text[^1..] + text + text[^1..];
        // text.Substring(text.Length - 1) + text + text.Substring(text.Length - 1);

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

            return parts[0] != "if"
                ? input.Insert(0, "if ")
                : input;
        }

        private static bool IntegerInRange(int n)
            => Math.Abs(n - 100) <= 10 ||
               Math.Abs(n - 200) <= 10;

        private static bool CheckIntegers(int x, int y)
            => x == 30 ||
               y == 30 ||
               x + y == 30;

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
            => x == y
                ? (x + y) * 3
                : x + y;
    }
}