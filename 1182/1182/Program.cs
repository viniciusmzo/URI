using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1182
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[12, 12];
            int coluna;
            char opc;
            double resultadoSoma = 0;

            coluna = int.Parse(Console.ReadLine());
            opc = char.Parse(Console.ReadLine().ToUpper());

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matriz[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (coluna == j) { resultadoSoma += matriz[i, j]; }
                }
            }

            if (opc == 'S')
            {
                Console.WriteLine(resultadoSoma.ToString("F1", CultureInfo.InvariantCulture));
            }
            if (opc == 'M')
            {
                double resultadoMedia = resultadoSoma / 12;
                Console.WriteLine(resultadoMedia.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
