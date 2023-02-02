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
        }

        private static int PrintNumSum(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n + PrintNumSum(n - 1);
        }

        private static void PrintNumbers(int n)
        {
            if (n != 0)
            {
                Console.Write(" {0} ", n);

                PrintNumbers(n - 1);
            }
        }

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