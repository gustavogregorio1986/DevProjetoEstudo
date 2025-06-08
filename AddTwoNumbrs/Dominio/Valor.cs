using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbrs.Dominio
{
    public class Valor
    {
        public List<int> ListaNumeros { get; set; }

        public override string ToString()
        {
            return $"[{string.Join(", ", ListaNumeros)}]";
        }
    }
}
