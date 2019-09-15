using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1175
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[20];
            int num, x = 19, aux;

            for (int i = 0; i < 20; i++)
            {
                num = int.Parse(Console.ReadLine());
                vet[i] = num;
            }

            for (int i = 0; i < 10; i++)
            {
                aux = vet[i];
                vet[i] = vet[x];
                vet[x] = aux;
                x--;
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("N[" + i + "] = " + vet[i]);
            }

                Console.ReadKey();
        }
    }
}
