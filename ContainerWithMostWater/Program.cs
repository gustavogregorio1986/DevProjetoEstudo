using ContainerWithMostWater.Dominio;
using System;
using System.Collections.Generic;

namespace ContainerWithMostWater
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Solution solution = new Solution();
            Console.WriteLine(solution.MaxArea(height));  // Output: 49

            int[] height2 = new int[] { 1, 1 };
            Console.WriteLine(solution.MaxArea(height2)); 
        }
    }
}
