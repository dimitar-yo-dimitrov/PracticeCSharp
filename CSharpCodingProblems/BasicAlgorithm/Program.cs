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

            //Problem 2: Get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference:

            Console.WriteLine(TakeDifference(47));
            Console.WriteLine(TakeDifference(51));
            Console.WriteLine(TakeDifference(55));
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();
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