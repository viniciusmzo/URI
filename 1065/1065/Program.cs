using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];
            int contador = 0;

            for (int i = 0; i < 5; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] % 2 == 0)
                {
                    contador += 1;
                }
            }

            Console.WriteLine(contador +" valores pares");
            Console.ReadKey();
        }
    }
}
