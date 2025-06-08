using System;
using System.Collections.Generic;

namespace ListaSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>() { 2, 3, 5, 6, 4, 3 };

            foreach(var numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
