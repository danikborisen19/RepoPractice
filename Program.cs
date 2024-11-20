using RepoPractice;

namespace RepoPractice
{
    using System;
    using System.Linq;

    public class TextHelper
    {
        private string Text;
        public TextHelper(string text)
        {
            Text = text;
        }
        public int CountWordsMoreThanFourLetters()
        {
            return Text.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Count(word => word.Length > 4);
        }
        public bool IsPalindrome()
        {
            var sanitizedText = new string(Text.Where(char.IsLetterOrDigit).ToArray())
                .ToLowerInvariant();
            return sanitizedText.SequenceEqual(sanitizedText.Reverse());
        }
        public int CountVowels()
        {
            return Text.Count(c => "aeiouAEIOU".Contains(c));
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        var helper = new TextHelper("My text");
        var result1 = helper.CountWordsMoreThanFourLetters();
        Console.WriteLine($"Words with more than four letters; {result1}");
        var result2 = helper.IsPalindrome();
        Console.WriteLine($"Is the text a palindrome? {result2}");
        var result3 = helper.CountVowels();
        Console.WriteLine($"Number of vowels: {result3}");
    }
}
