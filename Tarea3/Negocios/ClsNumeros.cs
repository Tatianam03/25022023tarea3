using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Entidades;

namespace Tarea3.Negocios
{
    public class ClsNumeros
    {
        public void ImprimirPares(Numeros numeros)
        {
            for(int i = numeros.numeroMinimo; i <= numeros.numeroMaximo; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
