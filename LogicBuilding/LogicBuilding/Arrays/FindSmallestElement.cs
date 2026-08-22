using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LogicBuilding.Arrays
{
    public class FindSmallestElement
    {
        int[] arr = { 5, 2, 9, 1, 5, 6 };
        public void FindSmallest() {
            int smallest = arr[0];

            for(int i= 1; i<arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }

            Console.WriteLine($"The smallest element in the array is: {smallest}");
        }
    }
}
