using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, cont = 0;

            x = int.Parse(Console.ReadLine());

            for (int j = 0; j < x; j++)
            {
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont > 2) { Console.WriteLine(n + " nao eh primo"); }
                else if (cont <= 2) { Console.WriteLine(n + " eh primo"); }
                cont = 0;
            }

            Console.ReadKey();
        }
    }
}
