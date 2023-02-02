﻿namespace Functions
{
    internal class Program
    {
        public static void Main()
        {
            //Problem 1: Factorial of a Number using Recursion:

            int numFactorial = 5;

            Console.WriteLine($"The factorial of {numFactorial} is {Factorial(numFactorial)}");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 2: Print the first n natural number:

            int numNatural = 15;
            int startValue = 1;

            // Call recursive method with two parameters.	
            PrintNatural(startValue, numNatural);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 3: Print numbers from n to 1:

            int number = 10;

            PrintNumbers(number);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 4: Find the sum of first n natural numbers:

            int numberToSum = 10;

            Console.WriteLine($"The sum of {numberToSum} is {PrintNumSum(numberToSum)}");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 5: Display the individual digits of a given number:

            int num = 123;
            var reverseNum = string.Join("", Math.Abs(num).ToString().Reverse());

            PrintIndividualNum(int.Parse(reverseNum));
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();
        }

        //Problem 5:
        private static void PrintIndividualNum(int n)
        {
            if (n < 10)
            {
                Console.Write(" {0} ", n);
                return;
            }

            Console.Write(" {0} ", n % 10);

            PrintIndividualNum(n / 10);
        }

        //Problem 4:
        private static int PrintNumSum(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n + PrintNumSum(n - 1);
        }

        //Problem 3:
        private static void PrintNumbers(int n)
        {
            if (n != 0)
            {
                Console.Write(" {0} ", n);

                PrintNumbers(n - 1);
            }
        }

        //Problem 2:
        private static int PrintNatural(int startValue, int n)
        {
            if (n < 1)
            {
                return startValue;
            }

            n--;

            Console.Write(" {0} ", startValue);

            return PrintNatural(startValue + 1, n);
        }

        //Problem 1:
        private static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}