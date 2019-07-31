using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[6];
            int contador = 0;
            double media, soma = 0;

            for (int i = 0; i < 6; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (vet[i] > 0)
                {
                    soma += vet[i];
                    contador += 1;
                }
            }
            media = soma / contador;
            Console.WriteLine(contador + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
