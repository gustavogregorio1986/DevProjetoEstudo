using System;

namespace LongestPalindromic0
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "babad";
            string resultado = LongestPalindrome(s);

            Console.WriteLine("maior substring paslimic: " + resultado);
        }

        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length < 1) return "";

            int start = 0, end = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int len1 = ExpandirDoCentro(s, i, i);     // Palíndromo de tamanho ímpar
                int len2 = ExpandirDoCentro(s, i, i + 1); // Palíndromo de tamanho par
                int len = Math.Max(len1, len2);

                if (len > end - start)
                {
                    start = i - (len - 1) / 2;
                    end = i + len / 2;
                }
            }

            return s.Substring(start, end - start + 1);
        }

        private static int ExpandirDoCentro(string s, int esquerda, int direita)
        {
            while (esquerda >= 0 && direita < s.Length && s[esquerda] == s[direita])
            {
                esquerda--;
                direita++;
            }

            return direita - esquerda - 1;
        }

    }
}
