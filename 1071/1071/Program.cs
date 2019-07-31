using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma, aux;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            soma = 0;

            if (y < x)
            {
                aux = y;
                y = x;
                x = aux;
            }

            for (int i = (x + 1); i < y; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma.ToString());
            Console.ReadKey();
        }
    }
}
