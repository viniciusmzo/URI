using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, soma, cont = 0;
            string[] vet;

            n = int.Parse(Console.ReadLine());

            soma = 0;
            for (int i = 0; i < n; i++)
            {
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
                while (cont < y)
                {
                    {
                        if (x % 2 != 0)
                        {
                            soma += x;
                            cont++;
                        }
                        x++;
                    }
                }
                Console.WriteLine(soma);
                soma = 0;
                cont = 0;
            }

            Console.ReadKey();
        }
    }
}
