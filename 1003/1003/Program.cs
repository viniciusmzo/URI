using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            a = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = a + b;
            Console.WriteLine("SOMA = " + soma.ToString(CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
