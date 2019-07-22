using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int[] tempo = new int[3] { 365, 30, 1 };
            int[] resultado = new int[3];

            idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < 3; i++)
            {
                resultado[i] = idade / tempo[i];
                idade = idade % tempo[i];
            }


            Console.WriteLine(resultado[0] + " ano(s)\n" + resultado[1] + " mes(es)\n" + resultado[2] + " dia(s)");
            Console.ReadKey();
        }
    }
}
