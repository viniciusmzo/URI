using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double porC, porR, porS, quantidade, coelhos = 0, ratos = 0, sapos = 0;
            char tipo;
            n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                quantidade = int.Parse(vet[0]);
                tipo = char.Parse(vet[1].ToUpper());
                if (tipo == 'C')
                {
                    coelhos += quantidade;
                }
                else if (tipo == 'R')
                {
                    ratos += quantidade;
                }
                else if (tipo == 'S')
                {
                    sapos += quantidade;
                }
            }

            quantidade = coelhos + ratos + sapos;

            porC = (coelhos * 100) / quantidade;
            porR = (ratos * 100) / quantidade;
            porS = (sapos * 100) / quantidade;
            Console.WriteLine("Total: "+ quantidade +" cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + porC.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " +porR.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " +porS.ToString("F2", CultureInfo.InvariantCulture) + " %");

            Console.ReadKey();
        }
    }
}
