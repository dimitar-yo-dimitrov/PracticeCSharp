namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example for Built-in C# Functions:

            int number = 25;
            double squareRoot = Math.Sqrt(number);

            Console.WriteLine($"Square Root of {number} is {squareRoot}");
            Console.ReadKey();

            // Example for User-Defined Function in C#:

            int x, y;
            x = 10;
            y = 20;

            int maxNumber = Max(x, y); // Function Call

            Console.WriteLine($"Max number is: {maxNumber}");
            Console.ReadKey();

            // 1.Functions with No Argument and No Return Type.

            Sum1();
            Console.ReadKey();

            // 2.Functions with Argument and No Return Type.

            int result = Sum2();

            Console.WriteLine($"Sum is {result}");
            Console.ReadKey();

            // 3.Functions with No Argument and with Return Type.

            int a = 10, b = 20;
            Sum3(a, b);

            Console.ReadKey();

            // 4.Functions with Argument and with Return Type.

            int numA = 10, numB = 20;
            int sum = Sum4(numA, numB);

            Console.WriteLine($"Sum is {sum}");
            Console.ReadKey();
        }

        private static int Sum4(int x, int y)
            => x + y;

        private static void Sum3(int x, int y)
        {
            int result = x + y;

            Console.WriteLine($"Sum is {result}");
        }

        private static int Sum2()
        {
            int x = 10;
            int y = 20;
            int sum = x + y;

            return sum;
        }

        private static void Sum1()
        {
            int x = 10;
            int y = 20;
            int sum = x + y;

            Console.WriteLine($"Sum of {x} and {y} is {sum}");
        }

        public static int Max(int x, int y) // Function Signature or Prototype
        {
            return x > y ? x : y; // Function Definition or Body
        }
    }
}
