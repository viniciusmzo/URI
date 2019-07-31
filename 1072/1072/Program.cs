using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, contIn, contOut;
            num = int.Parse(Console.ReadLine());
            contIn = 0;
            contOut = 0;

            int[] vet = new int[num];

            for (int i = 0; i < num; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] >= 10 && vet[i] <= 20)
                {
                    contIn += 1;
                }
                else { contOut += 1; }
            }

            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");
            Console.ReadKey();
        }
    }
}


