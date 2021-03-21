using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Anagram_Finder
{
    public class AnagramFinder
    {
        /// <summary>
        /// Searches 'English.txt' words for any anagrams of the input string
        /// </summary>
        /// <param name="input_"></param>
        /// <returns> strings which are anagrams of the input string </returns>
        public List<string> findAnagrams(string input_)
        {
            List<string> anagramStrings = new List<string>();

            try
            {
                string a = String.Concat(input_.OrderBy(c => c));

                using (StreamReader sr = new StreamReader(@"C:\Users\sean.williams\source\repos\Anagram Finder\Anagram Finder\English\english.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string b = String.Concat(line.OrderBy(c => c));

                        if( a == b) anagramStrings.Add(line);
                    }
                }

                return anagramStrings;
            }
            catch (Exception e)
            {
                Console.Write("File can't be read");
                Console.WriteLine(e.Message);
                throw;
            }
        }

    }
}
