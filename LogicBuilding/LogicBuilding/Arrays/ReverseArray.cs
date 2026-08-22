using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuilding.Arrays
{
    public class ReverseArray
    {
        public void ReverseArrayElements()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] revarray = new int[arr.Length];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                revarray[arr.Length-1-i] = arr[i];
            }

            Console.WriteLine("The reversed array is: " + string.Join(", ", revarray));
        }
    }
}
