using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, diferenca;

            a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            diferenca = ((a * b) - (c * d));

            Console.WriteLine("DIFERENCA = " + diferenca.ToString(CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
