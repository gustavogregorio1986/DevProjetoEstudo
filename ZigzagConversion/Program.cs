using System;

namespace ZigzagConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lista = "aviao";
            string invertida = "";

            for (int i = lista.Length - 1; i >= 0; i--)
            {
                invertida += lista[i];
            }

            Console.WriteLine("Invertida: " + invertida);
        }
    }
}
