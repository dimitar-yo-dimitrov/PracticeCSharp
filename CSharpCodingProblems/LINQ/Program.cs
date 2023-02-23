namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1: Shows how the three parts of a query operation execute:

            int[] numbers = { 1, 2, 3, 4, 5, 12, 18, 24 }; //  The first part is Data source.

            var evenNumbers = numbers.Where(n => n % 2 == 0); // The second part is Query creation.

            Console.Write("The numbers which produce the remainder 0 after divided by 2 are:\n");
            Console.Write(string.Join(" ", evenNumbers)); // The third part is Query execution.
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 2: Find the non-negative numbers from a list of numbers:

            int[] numbers2 = { 1, 2, -3, 4, -5, 12, -18, 24, 23 };

            var numbersInRange = numbers2.Where(n => n is >= 1 and <= 11);

            Console.Write("The numbers within the range of 1 to 11 are:\n");
            Console.Write(string.Join(" ", numbersInRange));
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 3: Find the number of an array and the square of each number:

            int[] numbers3 = { 3, 4, 5, 12, 18, 24 };

            var sqrNumber = from int number in numbers3
                            let sqrNum = number * number
                            where sqrNum > 20
                            select new { number, sqrNum };

            Console.Write("Find the number and its square of an array which is more than 20:\n");

            foreach (var result in sqrNumber)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 3: Display the number and frequency of number from giving array:

            //Solution without LINQ: 
            int[] numbers4 = { 3, 4, 5, 12, 18, 24, 5, 8, 3, 4, 4, 12, 18 };

            HashSet<int> uniqueNumber = new HashSet<int>();

            for (int i = 0; i < numbers4.Length; i++)
            {
                uniqueNumber.Add(numbers4[i]);
            }

            int count = 0;

            Console.WriteLine("The number and the Frequency are:");

            foreach (var numberA in uniqueNumber)
            {
                foreach (var numberB in numbers4)
                {
                    if (numberA == numberB)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"Number {numberA} appears {count} times");

                count = 0;
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Solution with LINQ:

            int[] numbers5 = { 3, 4, 5, 12, 18, 24, 5, 8, 3, 4, 4, 12, 18 };

            var n = from x in numbers5
                    group x by x into y
                    select y;

            Console.WriteLine("The number and the Frequency are:");

            foreach (var number in n)
            {
                Console.WriteLine($"Number {number.Key} appears {number.Count()} times");
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}