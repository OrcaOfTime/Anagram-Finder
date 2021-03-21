using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anagram_Finder
{
    public class InputValidator
    {
        public bool InputValid(string input_)
        {
            char[] invalidChars = {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-'};
            bool inputIsValid = true;


            if (String.IsNullOrEmpty(input_))
            {
                Console.WriteLine("You can't make an anagram out of nothing.");
                inputIsValid = false;
            }
            else
            {
                if (input_.Any(char.IsDigit)) 
                { 
                    Console.WriteLine("Input string cannot contain any numeric values"); 
                    inputIsValid = false;
                }
                
                if (input_.IndexOfAny(invalidChars) >= 0) 
                { 
                    Console.WriteLine("No invalid characters allowed "); 
                    inputIsValid = false;
                }
            }
        
            return inputIsValid;
        }

    }
}
