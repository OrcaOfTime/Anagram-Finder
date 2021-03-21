using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram_Finder
{
    public class AnagramPrinter
    {

        public void PrintAnagramsToConsole(string input_, List<string> anagramsList_)
        {
            if (anagramsList_ != null && anagramsList_.Count > 0)
            {
                Console.WriteLine("Anagrams for {0}: ", input_);
                foreach (string word in anagramsList_)
                {
                    Console.WriteLine(word);
                }
            }
            else
            {
                Console.WriteLine("No anagrams for {0} found :(", input_);
            }
        }
        }

}

