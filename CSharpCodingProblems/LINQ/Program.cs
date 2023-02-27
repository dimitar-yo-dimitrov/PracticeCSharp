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

            //Problem 4: Display the number and frequency of number from giving array:

            //Solution without LINQ: 
            int[] numbers4 = { 3, 4, 5, 12, 18, 24, 5, 8, 3, 4, 4, 12, 18 };

            HashSet<int> uniqueNumber = new HashSet<int>();

            for (int i = 0; i < numbers4.Length; i++)
            {
                uniqueNumber.Add(numbers4[i]);
            }

            int countNum = 0;

            Console.WriteLine("The number and the Frequency are:");

            foreach (var numberA in uniqueNumber)
            {
                foreach (var numberB in numbers4)
                {
                    if (numberA == numberB)
                    {
                        countNum++;
                    }
                }

                Console.WriteLine($"Number {numberA} appears {countNum} times");

                countNum = 0;
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

            //Problem 5: Display the characters and frequency of character from giving string:

            //Solution without LINQ:

            string characters = "apple";

            HashSet<char> uniqueChars = new HashSet<char>();

            for (int i = 0; i < characters.Length; i++)
            {
                uniqueChars.Add(characters[i]);
            }

            int countChar = 0;

            Console.WriteLine("The frequency of the characters are:");

            foreach (var charA in uniqueChars)
            {
                foreach (var charB in characters)
                {
                    if (charA == charB)
                    {
                        countChar++;
                    }
                }

                Console.WriteLine($"Character {charA}: {countChar} times");

                countChar = 0;
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Solution with LINQ:

            string charactersForLinq = "apple";

            var charItems = from x in charactersForLinq
                            group x by x into y
                            select y;

            Console.WriteLine("The frequency of the characters are:");

            foreach (var item in charItems)
            {
                Console.WriteLine($"Character {item.Key}: {item.Count()} times");
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 6: Display the name of the days of a week:

            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            var days = from weekDay in daysOfWeek
                       select weekDay;

            foreach (var day in days)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 7: Display numbers, multiplication of number with frequency and frequency of a number of giving array:

            int[] numbers6 = { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            var numsFromArray = from x in numbers6
                                select x;

            Console.WriteLine("The numbers in the array are:");
            Console.Write(string.Join(", ", numsFromArray));
            Console.WriteLine();
            Console.WriteLine("\nNumber Number*Frequency Frequency");
            Console.WriteLine("-----------------------------------------------------------------");

            var nums = from x in numbers6
                       group x by x into y
                       select y;

            foreach (var num in nums)
            {
                Console.WriteLine($"{num.Key} {num.Key * num.Count()} {num.Count()}");
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 8: Find the string which starts and ends with a specific character:

            //Solution 1:

            string[] cities =
                { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            Console.WriteLine($"The cities are: {string.Join(", ", cities)}");
            Console.WriteLine("Input starting character for the string: A");
            Console.WriteLine("Input ending character for the string: M");
            Console.WriteLine();

            foreach (var city in cities)
            {
                var firstChar = city.First();
                var lastChar = city.Substring(city.Length - 1);

                if (firstChar == 'A' && char.Parse(lastChar) == 'M')
                {
                    Console.WriteLine($"The city starting with A and ending with M is: {city}");
                }
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Solution 2:

            char charStart, charEnd;

            charStart = 'A';
            charEnd = 'M';

            string[] towns =
                { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var _result = from t in towns
                          where t.StartsWith(charStart)
                          where t.EndsWith(charEnd)
                          select t;

            foreach (var town in _result)
            {
                Console.WriteLine($"The city starting with A and ending with M is: {town}");
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Problem 9: Create a list of numbers and display the numbers greater than 80 as output:

            //Solution 1:
            List<int> numbers7 = new List<int> { 55, 200, 740, 76, 230, 482, 95 };

            int levelNum = 80;

            Console.WriteLine("The numbers greater than 80 are:");
            Console.WriteLine();

            var numbersResult = numbers7.Where(n => n > levelNum);

            Console.WriteLine(string.Join("\n", numbersResult));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //Solution 2:

            levelNum = 59;

            Console.WriteLine("The numbers greater than 59 are:");
            Console.WriteLine();

            var resultNumbers = numbers7
                .Find(n => n > levelNum);

            Console.WriteLine(string.Join("\n", resultNumbers));

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}