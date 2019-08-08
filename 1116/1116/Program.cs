using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, y;
            double resultado, xd, yd;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    xd = Convert.ToDouble(x);
                    yd = Convert.ToDouble(y);
                    resultado = xd / yd;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            Console.ReadKey();
        }
    }
}
