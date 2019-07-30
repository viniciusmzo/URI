using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB;
            string[] vet = Console.ReadLine().Split(' ');


            valorA = int.Parse(vet[0]);
            valorB = int.Parse(vet[1]);

            if (valorA % valorB == 0 || valorB % valorA == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.ReadKey();
        }
    }
}
