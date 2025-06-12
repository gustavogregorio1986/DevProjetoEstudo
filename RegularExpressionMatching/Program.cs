using RegularExpressionMatching.Dominio;
using System;

namespace RegularExpressionMatching
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();

            Console.WriteLine(sol.Ismatch("aa", "a"));    // false
            Console.WriteLine(sol.Ismatch("aa", "a*"));   // true
            Console.WriteLine(sol.Ismatch("ab", ".*"));   // true

        }
    }
}
