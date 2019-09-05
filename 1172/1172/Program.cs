using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1172
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vet = new int[10];

            for (int i = 0; i < 10; i++)
            {
                n = int.Parse(Console.ReadLine());
                vet[i] = n;
            }

            for (int i = 0; i < 10; i++)
            {
                if (vet[i] <= 0)
                {
                    vet[i] = 1;
                    Console.WriteLine("X[" + i + "] = " + vet[i]);
                }
                else if (vet[i] > 0)
                {
                    Console.WriteLine("X[" + i + "] = " + vet[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
