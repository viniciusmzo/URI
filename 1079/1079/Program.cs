using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] resultado;
            double x, y, z;

            n = int.Parse(Console.ReadLine());
            resultado = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
              

                x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                y = double.Parse(vet[1], CultureInfo.InvariantCulture);
                z = double.Parse(vet[2], CultureInfo.InvariantCulture);
                resultado[i] = ((x * 2) + (y * 3) + (z * 5)) / 10.0;
                
            }

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(resultado[j].ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadKey();
        }
    }
}
