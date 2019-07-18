using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, produto;

            valor1 = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            valor2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            produto = valor1 * valor2;
            Console.WriteLine("PROD = " + produto.ToString(CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
