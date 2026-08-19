using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuilding.Strings
{
    public class StringProgramm
    {
        public void reverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input string is null or empty.");
                return;
            }
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine($"Original String: {input}");
            Console.WriteLine($"Reversed String: {reversedString}");
        }
    }
}
