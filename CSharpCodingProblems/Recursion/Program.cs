namespace Functions
{
    internal class Program
    {
        public static void Main()
        {
            int number;

            //Factorial of a Number using Recursion:
            number = 5;

            Console.WriteLine($"The factorial of {number} is {Factorial(number)}");
            Console.ReadKey();

            //Print the first n natural number:

            number = 15;
            int startValue = 1;

            // Call recursive method with two parameters.	
            PrintNatural(startValue, number);
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

        private static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}