using AddTwoNumbrs.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbrs.Control
{
    public class ControlaValor
    {
        public Valor Listar()
        {
            Valor valor = new Valor()
            {
                ListaNumeros = new List<int> { 1, 3, 5 },
            };
            return  valor;
        }

        //public Valor Listar() => Exemplo de metodo que tem a mesma função e faz a mesma coisa
        //{
        //    return new Valor
        //    {
        //        ListaNumeros = new List<int> { 1, 3, 5 }
        //    };
        //}

        public Valor Listar1()
        {
            return new Valor
            { 
                ListaNumeros = new List<int>{ 4, 5, 6 },
            };

        }

        public int Somar(Valor valor)
        {
            Valor v1 = Listar();
            Valor v2 = Listar1();

            return v1.ListaNumeros.Sum() + v2.ListaNumeros.Sum();
        }
    }
}
