using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[6];
            int contador = 0;
            for (int i = 0; i < 6; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (vet[i] > 0)
                {
                    contador = contador + 1;
                }
            }
            Console.WriteLine(contador + " valores positivos");
            Console.ReadKey();

        }
    }
}
