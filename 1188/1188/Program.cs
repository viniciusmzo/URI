using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1188
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[12, 12];
            char opc;
            double resultadoSoma = 0;
            int contSoma = 0, auxA = 6, auxB = 5;


            opc = char.Parse(Console.ReadLine().ToUpper());

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }
            }


            for (int i = 7 ; i < 12; i++)
            {
                for (int j = auxB; j <= auxA; j++)
                {
                    resultadoSoma += matriz[i, j];
                    contSoma++;
                }
                auxA++;
                auxB--;
            }

            if (opc == 'S')
            {
                Console.WriteLine(resultadoSoma.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                resultadoSoma /= contSoma;
                ;
                Console.WriteLine(resultadoSoma.ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
