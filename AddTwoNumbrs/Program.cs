using AddTwoNumbrs.Control;
using AddTwoNumbrs.Dominio;
using System;

namespace AddTwoNumbrs
{
    public class Program
    {
        static void Main(string[] args)
        {
            ControlaValor controlaValor = new ControlaValor();
            Console.WriteLine("Calculo1: " + controlaValor.Listar());
            Console.WriteLine("Calculo2: " + controlaValor.Listar1());

            // Se quiser também exibir a soma:
            Console.WriteLine("Soma total: " + controlaValor.Somar(null));
        }
    }
}
