namespace BasicAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1: Compute the sum of the two given integer values. If the two values are the same, then return triple their sum:

            Console.WriteLine(SumOfTheTwoValues(1, 2));
            Console.WriteLine(SumOfTheTwoValues(2, 2));
            Console.WriteLine(SumOfTheTwoValues(5, 2));
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();
        }

        private static int SumOfTheTwoValues(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}