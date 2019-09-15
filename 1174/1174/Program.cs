using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1174
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet = new double[100];
            double num;

            for (int i = 0; i < 100; i++)
            {
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = num;
            }

            for (int i = 0; i < 100; i++)
            {
                if (vet[i] <= 10)
                {
                    Console.WriteLine("A["+ i +"] = " + vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }


            Console.ReadKey();
        }
    }
}
