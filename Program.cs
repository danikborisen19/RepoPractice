namespace RepoPractice
{
    using System;
    using System.Linq;

    public class WordCounter
    {
        private static readonly char[] separator = [' ', '.', ',', '!', '?'];

        public static int CountLongWords(string input)
        {
            string[] words = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Count(word => word.Length > 4);
            return words.Length;
        }
        static WordCounter()
        {
        }
        public static void Main()
        { 
            string text = "This is a simple example to count long words.";
            int result = CountLongWords(text);
            Console.WriteLine($"example: {result}");
        }
    }
}
