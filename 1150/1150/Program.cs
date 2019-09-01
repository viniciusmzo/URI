using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z, soma = 0, cont = 0;

            x = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            while (z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }

            for (int i = x; i <= z; i++)
            {
                soma += i;
                cont++;
                if (soma > z) break;
            }
           

            Console.WriteLine(cont);
            Console.ReadKey();
        }
    }
}
