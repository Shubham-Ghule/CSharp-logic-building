using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuilding.Arrays
{
    public class FindLargestElement
    {
        int[] arr = { 10, 83, 45, 92, 34, 15 };
        public void FindLargest()
        {
            int largest = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }

            Console.WriteLine($"The largest element in the array is: {largest}");

        }
    }
}
