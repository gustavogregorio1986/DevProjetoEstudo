using System;

namespace ReverseInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numero = 1234;
            int inverter = 0;

            Console.WriteLine("Inversão com for");
            for (; numero > 0; numero /= 10)
            {
                int digito = numero % 10;
                inverter = inverter * 10 + digito;
            }

            Console.WriteLine("Numero invertidos com for são: " + inverter);

            Console.WriteLine("Inversão com while");
            while (numero > 0)
            {
                int digito = numero % 10;
                inverter = inverter * 10 + digito;
                numero = numero / 10;
            }

            Console.WriteLine("Numero invertidos com while são: " + inverter);
        }
    }
}
