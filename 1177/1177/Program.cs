using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1177
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int[] vet = new int[1000];

            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                vet[i] = i % num;
                Console.WriteLine("N["+ i +"] = " + vet[i]);
            }

            Console.ReadKey();
        }
    }
}
