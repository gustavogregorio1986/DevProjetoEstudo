using System;

namespace LongestPalindromic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string letra = "babad";

            char[] caracteres = letra.ToCharArray();

            foreach (char c in caracteres)
            {
                Console.WriteLine(c);
            }
        }
    }
}
