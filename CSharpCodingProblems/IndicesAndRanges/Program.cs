namespace IndicesAndRanges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ranges and indices provide a succinct syntax for accessing single elements or ranges in a sequence.

            string[] words = {
                // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumps",    // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            Console.WriteLine("Example:");
            Console.WriteLine();
            Console.WriteLine($"The last word is < {words[^1]} >");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            string[] quickBrownFox = words[1..4];
            foreach (var word in quickBrownFox)
                Console.Write($"< {word} >");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            //words[1..4] == words[^8..^5];

            string[] quick_Brown_Fox = words[^8..^5];
            foreach (var word in quick_Brown_Fox)
                Console.Write($"< {word} >");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

            string[] lazyDog = words[^2..^0];
            foreach (var word in lazyDog)
                Console.Write($"< {word} >");
            Console.WriteLine();
        }
    }
}