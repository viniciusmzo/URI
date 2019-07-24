using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            string[] vet = Console.ReadLine().Split(' ');


            a = int.Parse(vet[0], CultureInfo.InvariantCulture);
            b = int.Parse(vet[1], CultureInfo.InvariantCulture);
            c = int.Parse(vet[2], CultureInfo.InvariantCulture);
            d = int.Parse(vet[3], CultureInfo.InvariantCulture);
            if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

            Console.ReadKey();

        }
    }
}
