using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int[] conversor = new int[3] { 3600, 60, 1 };
            int[] resultado = new int[3];

            valor = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado[0] = valor / conversor[0];
            valor = valor % conversor[0];
            resultado[1] = valor / conversor[1];
            valor = valor % conversor[1];
            resultado[2] = valor / conversor[2];
            valor = valor % conversor[2];
            Console.WriteLine(resultado[0].ToString("F0") + ":" + resultado[1].ToString("F0") + ":" + resultado[2].ToString("F0"));
            Console.ReadKey();

        }
    }
}
