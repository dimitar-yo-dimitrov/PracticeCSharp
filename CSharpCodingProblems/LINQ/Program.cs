namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1: Shows how the three parts of a query operation execute:

            int[] numbers = { 1, 2, 3, 4, 5, 12, 18, 24 }; //  The first part is Data source.

            var evenNumbers = numbers.Where(n => n % 2 == 0); // The second part is Query creation.

            Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are :\n");
            Console.Write(string.Join(" ", evenNumbers)); // The third part is Query execution.
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 2: Find the non-negative numbers from a list of numbers:

            int[] numbers2 = { 1, 2, -3, 4, -5, 12, -18, 24, 23 };

            var numbersInRange = numbers2.Where(n => n is >= 1 and <= 11);

            Console.Write("\nThe numbers within the range of 1 to 11 are : \n");
            Console.Write(string.Join(" ", numbersInRange));
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 3: Find the non-negative numbers from a list of numbers:

            int[] numbers3 = { 3, 4, 5, 12, 18, 24 };

            var sqrNumber = from int number in numbers3
                            let sqrNum = number * number
                            where sqrNum > 20
                            select new { number, sqrNum };

            foreach (var result in sqrNumber)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}