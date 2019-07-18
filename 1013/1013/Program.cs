using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, mx;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0], CultureInfo.InvariantCulture);
            b = int.Parse(vet[1], CultureInfo.InvariantCulture);
            c = int.Parse(vet[2], CultureInfo.InvariantCulture);

            mx = (a + b + Math.Abs(a - b)) / 2;
            mx = (c + mx + Math.Abs(c - mx)) / 2;

            Console.WriteLine(mx + " eh o maior");
            Console.ReadKey();
        }
    }
}
