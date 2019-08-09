using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1145
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            for (int i = 1; i <= y; i++)
            {

                if (i % x != 0)
                {
                    Console.Write(i + " ");
                }
                else if (i % x == 0)
                {
                    Console.Write(i);
                    Console.WriteLine();
                }

            }

            Console.ReadKey();
        }
    }
}
