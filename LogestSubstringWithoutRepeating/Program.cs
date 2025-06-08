using LogestSubstringWithoutRepeating.Dominio;
using System;

namespace LogestSubstringWithoutRepeating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            string input = "abcabcbb";
            int result = sol.LengthOfLongestSubstring(input);
            Console.WriteLine(result); // Deve imprimir 3

            Solution solution = new Solution();
            string inpt = "bbbbbbb";
            int result1 = solution.LengthOfLongestSubstring(inpt);
            Console.WriteLine(result1);
        }
    }
}
