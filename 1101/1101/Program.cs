using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, aux;
            string[] vet = Console.ReadLine().Split(' ');
            m = int.Parse(vet[0]);
            n = int.Parse(vet[1]);

            while (m > 0 && n > 0)
            {
                int soma = 0;
                if (m > n)
                {
                    aux = n;
                    n = m;
                    m = aux;
                }

                for (int i = m; i <= n; i++)
                {
                    Console.Write(i + " ");
                    soma += i;
                }
                Console.WriteLine("Sum=" + soma);
                soma = 0;

                vet = Console.ReadLine().Split(' ');
                m = int.Parse(vet[0]);
                n = int.Parse(vet[1]);
            }

            Console.ReadKey();
        }
    }
}
