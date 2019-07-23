using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double[] vetValores = new double[12] { 100.00, 50.00, 20.00, 10.00, 5.00, 2.00, 1.00, 0.50, 0.25, 0.10, 0.05, 0.01 };
            int[] res = new int[12];


            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < 12; i++)
            {

                var calc = Math.Truncate(valor / vetValores[i]);
                res[i] = (int)calc;
                valor = valor % vetValores[i];

            }

            Console.WriteLine("NOTAS:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i] + " nota(s) de R$ " + vetValores[i].ToString("F2", CultureInfo.InvariantCulture));

            }
            Console.WriteLine("MOEDAS:");
            for (int i = 6; i < 12; i++)
            {
                Console.WriteLine(res[i] + " moeda(s) de R$ " + vetValores[i].ToString("F2", CultureInfo.InvariantCulture));
            }



            Console.ReadKey();
        }
    }
}
