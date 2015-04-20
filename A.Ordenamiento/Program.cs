using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string n = Console.ReadLine();
            int tamano = Int32.Parse(n);
            int[] numeros = new int[tamano];

            for (int i = 0; i < tamano; i++)
            {
                numeros[i] = random.Next(0,100);
            }

            imprime(numeros);

            Burbuja.Aplicar(numeros);

            imprime(numeros);

            Console.Read();
        }

        static void imprime(int[] n) 
        {
            Console.WriteLine("___________________________");

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i].ToString() + " ");
            }
        }
    }
}
