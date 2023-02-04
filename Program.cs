using System;
using System.Text.RegularExpressions;

class Program
{
    public static bool IsPalindrome(string phrase)
    {
        // remove spaces, punctuation, and make lowercase
        string cleanedPhrase = Regex.Replace(phrase.ToLower(), "[^a-z0-9]+", "");

        // compare the cleaned phrase with its reverse
        for (int i = 0; i < cleanedPhrase.Length / 2; i++)
        {
            if (cleanedPhrase[i] != cleanedPhrase[cleanedPhrase.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a phrase to check if it is a palindrome:");
        string phrase = Console.ReadLine();

        while (!IsPalindrome(phrase))
        {
            Console.WriteLine("The phrase is not a palindrome. Enter a new phrase:");
            phrase = Console.ReadLine();
        }
        Console.WriteLine("The phrase is a palindrome.");
    }
}
