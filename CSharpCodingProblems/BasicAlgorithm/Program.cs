﻿using System.Text;

namespace BasicAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Problem 1: Compute the sum of the two given integer values.
            If the two values are the same, then return triple their sum:*/

            Console.WriteLine("Problem 1:");

            Console.WriteLine(SumOfTheTwoValues(1, 2));
            Console.WriteLine(SumOfTheTwoValues(2, 2));
            Console.WriteLine(SumOfTheTwoValues(5, 2));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            /*Problem 2: Get the absolute difference between n and 51.
            If n is greater than 51 return triple the absolute difference:*/

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

            /*Problem 5: Create a new string where 'if' is added to the front of a given string.
            If the string already begins with 'if', return the string unchanged:*/

            Console.WriteLine("Problem 5:");

            Console.WriteLine(CreateString("if else"));
            Console.WriteLine(CreateString("if else else"));
            Console.WriteLine(CreateString("else"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            /*Problem 6: Remove the character in a given position of a given string.
            The given position will be in the range 0..string length - 1 inclusive:*/

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

            /*Problem 8: Create a new string which is 4 copies of the 2 front characters of a given string.
            If the given string length is less than 2 return the original string:*/

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

            /*Problem 14: Check whether three given integer values are in the range 20..50 inclusive.
            Return true if 1 or more of them are in the said range otherwise false:*/

            Console.WriteLine("Problem 14:");

            Console.WriteLine(CheckRangeOfTheNums(11, 20, 12));
            Console.WriteLine(CheckRangeOfTheNums(30, 30, 17));
            Console.WriteLine(CheckRangeOfTheNums(25, 35, 50));
            Console.WriteLine(CheckRangeOfTheNums(15, 12, 8));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            /*Problem 15: Check if a string 'yt' appears at index 1 in a given string.
            If it appears return a string without 'yt' otherwise return the original string:*/

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

            /*Problem 17: Check which number nearest to the value 100 among two given integers.
            Return 0 if the two numbers are equal:*/

            Console.WriteLine("Problem 17:");

            Console.WriteLine(CheckNearestValue(78, 95));
            Console.WriteLine(CheckNearestValue(95, 95));
            Console.WriteLine(CheckNearestValue(99, 90));
            Console.WriteLine(CheckNearestValue(199, 190));
            Console.WriteLine(CheckNearestValue(190, 190));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            /*Problem 18: Check whether two given integers are in the range 40..50 inclusive,
            or they are both in the range 50..60 inclusive:*/

            Console.WriteLine("Problem 18:");

            Console.WriteLine(CheckRangeBtwTwoInteger(78, 95));
            Console.WriteLine(CheckRangeBtwTwoInteger(22, 35));
            Console.WriteLine(CheckRangeBtwTwoInteger(40, 50));
            Console.WriteLine(CheckRangeBtwTwoInteger(55, 60));
            Console.WriteLine(CheckRangeBtwTwoInteger(50, 60));
            Console.WriteLine(CheckRangeBtwTwoInteger(60, 65));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            /*Problem 19: Find the larger value from two positive integer values that is in the range 20..30 inclusive,
            or return 0 if neither is in that range:*/

            Console.WriteLine("Problem 19:");

            Console.WriteLine(FindLargerNumInRange(78, 95));
            Console.WriteLine(FindLargerNumInRange(22, 30));
            Console.WriteLine(FindLargerNumInRange(21, 25));
            Console.WriteLine(FindLargerNumInRange(27, 27));
            Console.WriteLine(FindLargerNumInRange(27, 33));
            Console.WriteLine(FindLargerNumInRange(33, 27));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 20: Check if a given string contains between indexes 2 and 4 'z' character:

            Console.WriteLine("Problem 20:");

            Console.WriteLine(CheckStringBtwTwoIndexes("frizz"));
            Console.WriteLine(CheckStringBtwTwoIndexes("zane"));
            Console.WriteLine(CheckStringBtwTwoIndexes("Zazz"));
            Console.WriteLine(CheckStringBtwTwoIndexes("false"));
            Console.WriteLine(CheckStringBtwTwoIndexes("zzzz"));
            Console.WriteLine(CheckStringBtwTwoIndexes("ZZZZ"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 21: Check whether a given string contain the character 'z' from 2 to 4 times:

            Console.WriteLine("Problem 21:");

            Console.WriteLine(CheckForExistCharacter("frizz"));
            Console.WriteLine(CheckForExistCharacter("zane"));
            Console.WriteLine(CheckForExistCharacter("Zazz"));
            Console.WriteLine(CheckForExistCharacter("false"));
            Console.WriteLine(CheckForExistCharacter("zzzz"));
            Console.WriteLine(CheckForExistCharacter("ZZZZ"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 22: Check if two given non-negative integers have the same last digit:

            Console.WriteLine("Problem 22:");

            Console.WriteLine(CheckLastDigit(78, 958));
            Console.WriteLine(CheckLastDigit(22, 30));
            Console.WriteLine(CheckLastDigit(215, 25));
            Console.WriteLine(CheckLastDigit(27, 27));
            Console.WriteLine(CheckLastDigit(27, 33));
            Console.WriteLine(CheckLastDigit(337, 27));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            /*Problem 23: Convert the last 3 characters of a given string in upper case.
            If the length of the string has less than 3 then uppercase all the character:*/

            Console.WriteLine("Problem 23:");

            Console.WriteLine(ConvertLastThreeChars("CSharp"));
            Console.WriteLine(ConvertLastThreeChars("Python"));
            Console.WriteLine(ConvertLastThreeChars("Javascript"));
            Console.WriteLine(ConvertLastThreeChars("js"));
            Console.WriteLine(ConvertLastThreeChars("PHP"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 24: Create a new string which is n (non-negative integer) copies of a given string:

            Console.WriteLine("Problem 24:");

            CopyOfString("CSharp", 2);
            CopyOfString("Python", 3);
            CopyOfString("JavaScript", 1);

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            /*Problem 25: Create a new string which is n(non - negative integer) copies of the the first 3 characters of a given string.
            If the length of the given string is less than 3 then return n copies of the string:*/

            Console.WriteLine("Problem 25:");

            CutAndCopyTheString("CSharp", 2);
            CutAndCopyTheString("Python", 3);
            CutAndCopyTheString("JavaScript", 1);
            CutAndCopyTheString("JS", 3);

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 26: Count the number of times the string "aa" appears in a given string and assume that "aaa" contains two "aa":

            Console.WriteLine("Problem 26:");

            Console.WriteLine(CountTheString("bbaaccaag"));
            Console.WriteLine(CountTheString("jjkiaaasew"));
            Console.WriteLine(CountTheString("JSaaakoiaa"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 27: Check if the first appearance of 'a' in a given string is immediately followed by another 'a':

            Console.WriteLine("Problem 27:");

            Console.WriteLine(CheckTheString("bbaaccaag"));
            Console.WriteLine(CheckTheString("jajkiaaasew"));
            Console.WriteLine(CheckTheString("JSaaakoiaa"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 28: Create a new string made of every other character starting with the first from a given string:

            Console.WriteLine("Problem 28:");

            Console.WriteLine(MadeNewString("CSharp"));
            Console.WriteLine(MadeNewString("Python"));
            Console.WriteLine(MadeNewString("JS"));
            Console.WriteLine(MadeNewString("PHP"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 29: Create a string like "aababcabcd" from a given string "abcd":

            Console.WriteLine("Problem 29:");

            Console.WriteLine(CreatingNewString("abcd"));
            Console.WriteLine(CreatingNewString("abc"));
            Console.WriteLine(CreatingNewString("a"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            /*Problem 30: Count a substring of length 2 appears in a given string and also as the last 2 characters of the string.
            Do not count the end substring:*/

            Console.WriteLine("Problem 30:");

            Console.WriteLine(CountString("abcdsab"));
            Console.WriteLine(CountString("abcdabab"));
            Console.WriteLine(CountString("abcabdabab"));
            Console.WriteLine(CountString("abcabd"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 31: Check a specified number is present in a given array of integers.

            Console.WriteLine("Problem 31:");

            Console.WriteLine(CheckForExistingElementInArray(new[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(CheckForExistingElementInArray(new[] { 1, 2, 2, 3 }, 2));
            Console.WriteLine(CheckForExistingElementInArray(new[] { 1, 2, 2, 3 }, 9));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 32: Check if one of the first 4 elements in an array of integers is equal to a given element.

            Console.WriteLine("Problem 32:");

            Console.WriteLine(CheckForEqualElementInArray(new[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(CheckForEqualElementInArray(new[] { 1, 2, 3, 4, 5, 6 }, 2));
            Console.WriteLine(CheckForEqualElementInArray(new[] { 1, 2, 2, 3 }, 9));
            Console.WriteLine(CheckForEqualElementInArray(new[] { 1, 2, 2 }, 1));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 33: Check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.

            Console.WriteLine("Problem 33:");

            Console.WriteLine(CheckForSequenceOfNumInArray(new[] { 1, 1, 2, 3, 1 }));
            Console.WriteLine(CheckForSequenceOfNumInArray(new[] { 1, 1, 2, 4, 1 }));
            Console.WriteLine(CheckForSequenceOfNumInArray(new[] { 1, 1, 2, 1, 2, 3 }));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 34: Compare two given strings and return the number of the positions where they contain the same length 2 substring:

            Console.WriteLine("Problem 34:");

            Console.WriteLine(CountOfEqualSubstring("abcdefgh", "abijsklm"));
            Console.WriteLine(CountOfEqualSubstring("abcde", "osuefrcd"));
            Console.WriteLine(CountOfEqualSubstring("pqrstuvwx", "pqkdiewx"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            /*Problem 35: Create a new string from a give string where a specified character have been removed except starting
            and ending position of the given string:*/

            Console.WriteLine("Problem 35:");

            Console.WriteLine(RemoveCharOfString("xxHxix", "x"));
            Console.WriteLine(RemoveCharOfString("abxdddca", "a"));
            Console.WriteLine(RemoveCharOfString("xabjbhtrb", "b"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 36: Create a new string with the given indexes 0, 1, 4, 5, 8, 9:

            Console.WriteLine("Problem 36:");

            Console.WriteLine(CreateStringWithTheGivenIndexes("Python"));
            Console.WriteLine(CreateStringWithTheGivenIndexes("JavaScript"));
            Console.WriteLine(CreateStringWithTheGivenIndexes("HTML"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 37: Create a new string of the characters at indexes 0,1,  4,5,  8,9 ... from a given string:

            Console.WriteLine("Problem 37:");

            Console.WriteLine(CreateStringWithTheGivenSequencesOfIndexes("Python"));
            Console.WriteLine(CreateStringWithTheGivenSequencesOfIndexes("JavaScript"));
            Console.WriteLine(CreateStringWithTheGivenSequencesOfIndexes("HTML"));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            /*Problem 38: Count the number of two 5's are next to each other in an array of integers.
            Also count the situation where the second 5 is actually a 6:*/

            Console.WriteLine("Problem 38:");

            Console.WriteLine(CountTheNumberOfTwoFives(new[] { 5, 5, 2 }));
            Console.WriteLine(CountTheNumberOfTwoFives(new[] { 5, 5, 2, 5, 5 }));
            Console.WriteLine(CountTheNumberOfTwoFives(new[] { 5, 6, 2, 9 }));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            /*Problem 39: Check if a triple is presents in an array of integers or not.
             If a value appears three times in a row in an array it is called a triple:*/

            Console.WriteLine("Problem 39:");

            Console.WriteLine(CheckForSequenceOfThreeElements(new[] { 1, 1, 2, 2, 1 }));
            Console.WriteLine(CheckForSequenceOfThreeElements(new[] { 1, 1, 2, 2, 2 }));
            Console.WriteLine(CheckForSequenceOfThreeElements(new[] { 1, 1, 2, 1, 2, 3 }));
            Console.WriteLine(CheckForSequenceOfThreeElements(new[] { 1, 1, 1, 2, 2, 2, 1 }));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 40: Compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30:

            Console.WriteLine("Problem 40:");

            Console.WriteLine(SumOfTwoNumbers(new[] { 12, 17 }));
            Console.WriteLine(SumOfTwoNumbers(new[] { 2, 17 }));
            Console.WriteLine(SumOfTwoNumbers(new[] { 22, 17 }));
            Console.WriteLine(SumOfTwoNumbers(new[] { 20, 0 }));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 41: Accept two integers and return true if either one is 5 or their sum or difference is 5:

            Console.WriteLine("Problem 41:");

            Console.WriteLine(FindTheNumber5(5, 4));
            Console.WriteLine(FindTheNumber5(1, 4));
            Console.WriteLine(FindTheNumber5(4, 3));
            Console.WriteLine(FindTheNumber5(9, 14));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 42: Test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13:

            Console.WriteLine("Problem 42:");

            Console.WriteLine(CheckForMultipleNumber(13));
            Console.WriteLine(CheckForMultipleNumber(14));
            Console.WriteLine(CheckForMultipleNumber(27));
            Console.WriteLine(CheckForMultipleNumber(41));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 43: Check if a non-negative given number is a multiple of 3 or 7, but not both:

            Console.WriteLine("Problem 43:");

            Console.WriteLine(MultipleNumberOf_3_Or_7(3));
            Console.WriteLine(MultipleNumberOf_3_Or_7(7));
            Console.WriteLine(MultipleNumberOf_3_Or_7(21));
            Console.WriteLine(MultipleNumberOf_3_Or_7(22));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 44: Check if a given number is within 2 of a multiple of 10:

            Console.WriteLine("Problem 44:");

            Console.WriteLine(MultipleNumberOf_10_Within_2(3));
            Console.WriteLine(MultipleNumberOf_10_Within_2(7));
            Console.WriteLine(MultipleNumberOf_10_Within_2(8));
            Console.WriteLine(MultipleNumberOf_10_Within_2(21));
            Console.WriteLine(MultipleNumberOf_10_Within_2(22));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();
        }

        private static bool MultipleNumberOf_10_Within_2(int number)
            => number % 10 <= 2 || number % 10 >= 8;

        private static bool MultipleNumberOf_3_Or_7(int number)
            => number % 3 == 0 ^ number % 7 == 0;

        private static bool CheckForMultipleNumber(int number)
            => number % 13 == 0 || number % 13 == 1;

        private static bool FindTheNumber5(int numA, int numB)
        {
            var resultA = Math.Abs(numA - numB);
            var resultB = numA + numB;

            return numA == 5 || numB == 5 || resultA == 5 || resultB == 5;
        }

        private static int SumOfTwoNumbers(int[] numbers)
        {
            if (numbers.Sum() >= 10 && numbers.Sum() <= 20)
            {
                return 30;
            }

            return numbers.Sum();
        }

        private static bool CheckForSequenceOfThreeElements(IReadOnlyList<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 2; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i + 1] == numbers[i + 2])
                {
                    return true;
                }
            }

            return false;
        }

        private static int CountTheNumberOfTwoFives(IReadOnlyList<int> numbers)
        {
            var count = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == 5 && (numbers[i + 1] == 5 || numbers[i + 1] == 6))
                {
                    count++;
                }
            }

            return count;
        }

        private static string CreateStringWithTheGivenSequencesOfIndexes(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i += 4)
            {
                var c = i + 2;
                var n = 0;

                n += c > text.Length ? 1 : 2;

                sb.Append(text.Substring(i, n));
            }

            return sb.ToString().TrimEnd();
        }

        private static string CreateStringWithTheGivenIndexes(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (var i = 0; i < text.Length; i++)
            {
                var letter = text[i];

                switch (i)
                {
                    case 0:
                    case 1:
                    case 4:
                    case 5:
                    case 8:
                    case 9:
                        sb.Append(letter);
                        break;
                }
            }

            return sb.ToString().TrimEnd();
        }

        private static string RemoveCharOfString(string text, string character)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(text[0]);

            for (int i = 1; i < text.Length - 1; i++)
            {
                if (text[i].ToString() == character)
                {
                    continue;
                }

                sb.Append(text[i]);
            }

            sb.Append(text[^1]);

            return sb.ToString().TrimEnd();
        }

        private static int CountOfEqualSubstring(string textA, string textB)
        {
            var count = 0;

            for (int i = 0; i < textA.Length - 1; i++)
            {
                var substrA = textA.Substring(i, 2);

                for (int j = 0; j < textB.Length - 1; j++)
                {
                    var substrB = textB.Substring(j, 2);

                    if (substrA == substrB)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private static bool CheckForSequenceOfNumInArray(IReadOnlyList<int> numbers)
        {
            const int numA = 1;
            const int numB = 2;
            const int numC = 3;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numA &&
                    numbers[i + 1] == numB &&
                    numbers[i + 2] == numC)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool CheckForEqualElementInArray(IEnumerable<int> numbers, int num)
            => numbers.Take(4).Contains(num);

        private static bool CheckForExistingElementInArray(IEnumerable<int> numbers, int num)
            => numbers.Contains(num);

        private static int CountString(string text)
        {
            var count = 0;

            var lastTwoChar = text[^2..];

            for (int i = 0; i < text.Length - 2; i++)
            {
                if (text.Substring(i, 2).Equals(lastTwoChar))
                {
                    count++;
                }
            }

            return count;
        }

        private static string CreatingNewString(string text)
        {
            var result = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                result += text[..(i + 1)];
            }

            return result;
        }

        private static string MadeNewString(string text)
        {
            var result = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += text[i];
                }
            }

            return result;

            //StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < text.Length; i += 2)
            //{
            //    sb.Append(text[i]);
            //}

            //return sb.ToString().TrimEnd();
        }

        private static bool CheckTheString(string text)
        {
            var count = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i].Equals('a'))
                {
                    count++;
                }

                if (text.Substring(i, 2) == "aa" && count < 2)
                {
                    return true;
                }
            }

            return false;

            //bool flag = false;

            //for (int i = 0; i < text.Length - 1; i++)
            //{
            //    if (text.Substring(i, 2) == "aa")
            //    {
            //        flag = true;
            //        break;
            //    }

            //    if (text[i] == 'a')
            //    {
            //        break;
            //    }
            //}

            //return flag;
        }

        private static int CountTheString(string text)
        {
            var count = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text.Substring(i, 2) == "aa")
                {
                    count++;
                }
            }

            return count;
        }

        private static void CutAndCopyTheString(string text, int n)
        {
            StringBuilder sb = new StringBuilder();

            var lengthOfText = 3;

            if (text.Length < lengthOfText)
            {
                lengthOfText = text.Length;
            }

            var result = text[..lengthOfText];

            for (int i = 0; i < n; i++)
            {
                sb.Append(result);
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static void CopyOfString(string text, int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(text);
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        private static string ConvertLastThreeChars(string text)
        {
            if (text.Length <= 3)
            {
                return text.ToUpper();
            }

            string lastThreeChars = text[^3..];

            var result = text.Replace(lastThreeChars, lastThreeChars.ToUpper());

            return result;
        }

        private static bool CheckLastDigit(int numA, int numB)
        {
            return numA % 10 == numB % 10;
        }

        private static bool CheckForExistCharacter(string text)
        {
            var count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'z')
                {
                    count++;
                }

            }

            return count is >= 2 and <= 4;
        }

        private static bool CheckStringBtwTwoIndexes(string text)
        {
            return text.Substring(2, 2).Contains('z');
        }

        private static int FindLargerNumInRange(int numA, int numB)
        {
            if (numA is >= 20 and <= 30 &&
                numB is >= 20 and <= 30)
            {
                return numA >= numB ? numA : numB;
            }

            if (numA is >= 20 and <= 30)
            {
                return numA;
            }

            if (numB is >= 20 and <= 30)
            {
                return numB;
            }

            return 0;
        }

        private static bool CheckRangeBtwTwoInteger(int numA, int numB)
        {
            if (numA is >= 40 and <= 50 ||
                numB is >= 40 and <= 50)
            {
                return true;
            }

            if (numA is >= 50 and <= 60 &&
                numB is >= 50 and <= 60)
            {
                return true;
            }

            return false;
        }

        private static int CheckNearestValue(int numA, int numB)
        {
            var resultA = Math.Abs(numA - 100);
            var resultB = Math.Abs(numB - 100);

            return resultA < resultB ? numA : resultA > resultB ? numB : 0;
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