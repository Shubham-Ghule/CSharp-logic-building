using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuilding.Arrays
{
    public class FindArrayElementsSum
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int sum = 0;
        public FindArrayElementsSum() {
            for (int i = 0; i < arr.Length; i++)
            { 
                sum += arr[i];
            }

            Console.WriteLine("Sum of array elements is: " + sum);
        }

    }
}
