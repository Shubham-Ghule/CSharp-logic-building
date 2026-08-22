using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuilding.Arrays
{
    public class CountOddEvenElements
    {
        public void CountOddEvenElementsInArray()
        {
            int[] arr = {1,2,3,4,5,6,7,8,8,9,10};

            int OddCount = 0;
            int EVenCount = 0;

            
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    EVenCount++;
                } 
                if (arr[i] % 2 == 0)
                {
                    EVenCount++;
                }
                else
                {
                    OddCount++;
                }
            }

            Console.WriteLine($"The number of even elements in the array is: {EVenCount}");
            Console.WriteLine($"The number of odd elements in the array is: {OddCount}");
        }
    }
}
