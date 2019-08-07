using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int maior = 0, index = 0;
            int[] vet = new int[100];

            for (int i = 0; i < 100; i++)
            {
                n = int.Parse(Console.ReadLine());
                vet[i] = n;
                if (n > maior)
                {
                    maior = n;
                    index = (Array.IndexOf(vet, maior) + 1);
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(index);
            Console.ReadKey();
        }
    }
}
