using System;
using System.Collections.Generic;
using System.Text;

namespace LogicBuilding.Arrays
{
    public class FindAvargaeOfElements
    {
        public void CalculateAverage()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double average = (double)sum / arr.Length;
            Console.WriteLine($"The average of the array elements is: {average}");
        }
    }
}
