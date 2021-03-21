using System;

namespace Anagram_Finder
{
    class Program
    {

        static readonly AnagramFinder finder = new AnagramFinder();
        static readonly AnagramPrinter printer = new AnagramPrinter();
        static readonly InputValidator validator = new InputValidator();

        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Enter word or random assortment of letters");

            input = Console.ReadLine();

            while (!validator.InputValid(input))
            {
                Console.WriteLine("Please enter a valid word or random assortment of letters");
                input = Console.ReadLine();
            }

            printer.PrintAnagramsToConsole(input, finder.findAnagrams(input));

        }
    }
}
