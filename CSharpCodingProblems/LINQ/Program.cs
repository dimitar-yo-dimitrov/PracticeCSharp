namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1: Shows how the three parts of a query operation execute:

            int[] numbers = { 1, 2, 3, 4, 5, 12, 18, 24 }; //  The first part is Data source.

            var evenNumbers = numbers.Where(n => n % 2 == 0); // The second part is Query creation.

            Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
            Console.Write(string.Join(" ", evenNumbers)); // The third part is Query execution.
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}