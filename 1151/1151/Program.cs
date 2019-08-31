using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] soma;
            
            n = int.Parse(Console.ReadLine());

            soma = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    soma[i] = 0;
                }
                else if (i == 1)
                {
                    soma[i] = 1;
                }
                else if (i > 1)
                {
                    soma[i] = soma[(i -2)] + soma[(i - 1)];
                }

            }

            for (int i = 0; i < n; i++)
            {
                if (i < (n - 1))
                {
                    Console.Write(soma[i] + " ");
                }
                else if (i == (n - 1))
                {
                    Console.WriteLine(soma[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
