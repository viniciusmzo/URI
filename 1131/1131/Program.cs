using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int golI, golG, opc, vitI = 0 , vitG = 0, empate = 0;
            opc = 1;

            while(opc == 1)
            {
                if (opc == 2) break;
                else
                {
                    string[] vet = Console.ReadLine().Split(' ');
                    golI = int.Parse(vet[0]);
                    golG = int.Parse(vet[1]);

                    if (golI > golG)
                    {
                        vitI++;
                    }
                    else if (golG > golI)
                    {
                        vitG++;
                    }
                    else if (golG == golI)
                    {
                        empate++;
                    }

                }
                Console.WriteLine("Novo grenal(1 - sim 2 - nao)");
                opc = int.Parse(Console.ReadLine());
            }
            int total = vitG + vitI + empate;
            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter:" + vitI);
            Console.WriteLine("Gremio:" + vitG);
            Console.WriteLine("Empates:" + empate);

            if (vitI > vitG) { Console.WriteLine("Inter venceu mais"); }
            else if (vitG > vitI) { Console.WriteLine("Gremio venceu mais"); }
            else if (vitG == vitI) { Console.WriteLine("Nao houve vencedor"); }

            Console.ReadKey();
        }
    }
}
