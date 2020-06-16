using System;
using System.Globalization;

namespace _1181
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[12, 12];
            int linha;
            char opc;
            double resultadoSoma = 0;

            linha = int.Parse(Console.ReadLine());
            opc = char.Parse(Console.ReadLine().ToUpper());

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matriz[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (linha == i) { resultadoSoma += matriz[i, j]; }
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
