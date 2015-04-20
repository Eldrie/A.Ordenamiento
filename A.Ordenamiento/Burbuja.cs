using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Ordenamiento
{
    class Burbuja
    {
        public static void Aplicar(int[] numeros) 
        {
            for (int i = 1; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length -1 ; j++)
                {
                    if(numeros[j] > numeros[j + 1])
                    {
                        int auxiliar = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = auxiliar;
                    }
                }
            }
        }
    }
}
