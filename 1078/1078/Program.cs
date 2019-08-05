using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] res = new int[10];
            int num;
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                res[i] = num * vet[i];
                Console.WriteLine(vet[i] + " x " + num +  " = " + res[i]);
            }

            Console.ReadKey();
        }
    }
}
