using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuilding.Strings
{
    public class StringProgramm
    {
        /// <summary>
        /// Reverses the given input string and prints the reversed string to the console.
        /// input: Hello, World!
        /// output: Reversed string: !dlroW ,olleH
        /// </summary>
        /// <param name="input"></param>
        public void reverseString(string input)
        {
            string reversedString = string.Empty; 
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input string is null or empty.");
                return;
            }

            for (int i = input.Length-1; i >= 0; i--)
            {
                reversedString += input[i];
            }

            Console.WriteLine("Reversed string: " + reversedString);
        }

        /// <summary>
        /// Reverses the each word of given input string and prints the reversed string to the console.
        /// input: Hello, World!
        /// output: Reversed string: ,olleH !dlroW
        /// </summary>
        public void reverseEachWord(string input)
        {
            string reversedString = string.Empty;
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input string is null or empty.");
                return;
            }
            string[] words = input.Split(' ');
            foreach (string word in words)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedString += word[i];
                }
                reversedString += " "; // Add space after each reversed word
            }
            Console.WriteLine("Reversed string: " + reversedString.Trim());
        }
    }
}
