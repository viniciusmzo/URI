using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, n, cont, soma = 0;
            string[] vet;

            cont = 2;
            vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            n = int.Parse(vet[1]);
            while (n <= 0)
            {
                n = int.Parse(vet[cont++]);
            }

            for (int i = 0; i < n; i++)
            {
                soma += (a + i);
            }

            Console.WriteLine(soma);
            Console.ReadKey();

        }
    }
}
