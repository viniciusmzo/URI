using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y, aux, dif, soma;

            n = int.Parse(Console.ReadLine());
            soma = 0;
            int[] resultado = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (y < x)
                {
                    aux = y;
                    y = x;
                    x = aux;
                }
                dif = y - x;

                for (int j = 0; j < y; j++)
                {
                    if (dif == 0)
                    {
                        resultado[i] = 0;
                    }
                    else if (dif != 0)
                    {
                        if (j > x && j < y)
                        {
                            if (j % 2 != 0)
                            {
                                soma += j;
                                resultado[i] = soma;
                            }
                        }
                    }
                }

                soma = 0;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(resultado[i]);
            }

            Console.ReadKey();
        }
    }
}
