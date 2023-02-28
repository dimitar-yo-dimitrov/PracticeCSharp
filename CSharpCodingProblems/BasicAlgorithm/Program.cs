﻿namespace BasicAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1: Compute the sum of the two given integer values. If the two values are the same, then return triple their sum:

            Console.WriteLine("Problem 1:");
            Console.WriteLine(SumOfTheTwoValues(1, 2));
            Console.WriteLine(SumOfTheTwoValues(2, 2));
            Console.WriteLine(SumOfTheTwoValues(5, 2));
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 2: Get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference:

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
            Console.WriteLine(IntegerInRange(7));
            Console.WriteLine(IntegerInRange(51));
            Console.WriteLine(IntegerInRange(55));
            Console.WriteLine(IntegerInRange(200));
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();
        }

        private static bool IntegerInRange(int n)
        {
            return n is > 10 and < 100 or 200;
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