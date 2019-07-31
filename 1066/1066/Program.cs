using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];
            int par, impar, pos, neg;
            par = 0;
            impar = 0;
            pos = 0;
            neg = 0;

            for (int i = 0; i < 5; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] % 2 == 0)
                {
                    par = par + 1;
                }
                else { impar = impar + 1; }

                if (vet[i] > 0)
                {
                    pos = pos + 1;
                }
                else if (vet[i] < 0) { neg = neg + 1; }
            }

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(pos + " valor(es) positivo(s)");
            Console.WriteLine(neg + " valor(es) negativo(s)");

            Console.ReadKey();
        }
    }
}
