using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1164
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, soma = 0;

            x = int.Parse(Console.ReadLine());

            for (int j = 0; j < x; j++)
            {

                n = int.Parse(Console.ReadLine());
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        soma += i;
                    }
                }
                if (soma == n) { Console.WriteLine(n + " eh perfeito"); }
                else if (soma != n) { Console.WriteLine(n + " nao eh perfeito"); }
                soma = 0;
            }
            Console.ReadKey();
        }
    }
}
