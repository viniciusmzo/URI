using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] resI = new int[13];
            int[] resJ = new int[13];
            int valorI = 1;
            int valorJ = 60;
            

            for (int i = 0; i < 13; i++)
            {
                resI[i] = valorI;
                resJ[i] = valorJ;
                valorI += 3;
                valorJ -= 5;
            }
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("I="+ resI[i] +" J=" + resJ[i]);
            }

                Console.ReadKey();
        }
    }
}
