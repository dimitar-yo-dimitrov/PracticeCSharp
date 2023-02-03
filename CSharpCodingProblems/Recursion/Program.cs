namespace Functions
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

            //Problem 6: Count the number of digits in a number:

            int numForCount = 123567;
            int count = 0;

            Console.WriteLine($"Count the number of {numForCount} is {Count(numForCount, count)}");

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 7: Print even or odd numbers in a given range:

            int n = 20;

            Console.WriteLine($"All even numbers from 1 to {n} are :");
            EvenAndOddNumbers(2, n);

            Console.WriteLine();

            Console.WriteLine($"All odd numbers from 1 to {n} are :");
            EvenAndOddNumbers(1, n);

            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 6: Check whether a number is prime:

            int numPrime = 96;

            PrimeNumber(numPrime);

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();
        }

        //Problem 8:
        private static void PrimeNumber(int n)
        {
            Console.WriteLine(
                n % 2 == 1
                    ? $"The number {n} is a Prime number"
                    : $"The number {n} is not a Prime number");
        }

        //Problem 7:
        private static void EvenAndOddNumbers(int startValue, int n)
        {
            if (startValue > n)
            {
                return;
            }

            Console.Write(" {0} ", startValue);

            EvenAndOddNumbers(startValue + 2, n);
        }

        //Problem 6:
        private static int Count(int n, int count)
        {
            if (n == 0)
            {
                return count;
            }

            return Count(n / 10, ++count);
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