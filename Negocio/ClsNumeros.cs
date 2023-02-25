using numerosparess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosparess.Negocio
{
    public class ClsNumeros
    {
        public void Imprimirnumeros(Numeros numeros)
        {
            for(int i = numeros.num1; 1 <= numeros.num2; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
