using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int[] notas = new int[7] { 100, 50, 20, 10, 5, 2, 1};
            int[] res = new int[7];
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine(valor1);

            for (int i = 0; i < 7; i++) {
                res[i] = valor1 / notas[i];
                valor1 = valor1 % notas[i];
            }
           
            for (int i = 0; i < 7; i++) {
                Console.WriteLine(res[i] + " nota(s) de R$ " + notas[i] + ",00");
            }

            Console.ReadKey();

        }
    }
}
