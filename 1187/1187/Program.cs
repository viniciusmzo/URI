using System;
using System.Globalization;

namespace _1187
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[12, 12];
            char opc;
            double resultadoSoma = 0;
            int contador = 0;

            opc = char.Parse(Console.ReadLine().ToUpper());

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i <= 4; i++)
            {
                for (int j = i + 1; j <= 10 - i; j++)
                {
                    resultadoSoma += matriz[i, j];
                    contador++;
                }
            }


            if (opc == 'S')
            {
                Console.WriteLine(resultadoSoma.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                resultadoSoma /= contador;
                    ;
                Console.WriteLine(resultadoSoma.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();


        }
    }
}
