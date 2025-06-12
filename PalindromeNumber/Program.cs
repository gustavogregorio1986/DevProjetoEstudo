using PalindromeNumber.Dominio;
using System;

namespace PalindromeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsPalindrome(121));
            Console.WriteLine(solution.IsPalindrome(-121));
            Console.WriteLine(solution.IsPalindrome(10));
        } 
    }
}
