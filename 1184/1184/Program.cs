using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1184
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[12, 12];
            double resultadoSoma = 0;
            char opc;
            int contador = 0;

            opc = char.Parse(Console.ReadLine().ToUpper());


            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matriz[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (i != j && i > j)
                    {
                        resultadoSoma += matriz[i, j];
                        contador++;
                    }
                }
            }

            if (opc == 'S')
            {
                Console.WriteLine(resultadoSoma.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                resultadoSoma /= contador;
                Console.WriteLine(resultadoSoma.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
