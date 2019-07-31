using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int dd1, hh1, mm1, ss1;
            int dd2, hh2, mm2, ss2;
            int difD, difH, difM, difS;

            
            string[] entradaA = Console.ReadLine().Split(' ');
            dd1 = int.Parse(entradaA[1]);
            string[] dia1 = Console.ReadLine().Trim().Split(':');
            hh1 = int.Parse(dia1[0]);
            mm1 = int.Parse(dia1[1]);
            ss1 = int.Parse(dia1[2]);

            string[] entradaB = Console.ReadLine().Split(' ');
            dd2 = int.Parse(entradaB[1]);
            string[] dia2 = Console.ReadLine().Trim().Split(':');
            hh2 = int.Parse(dia2[0]);
            mm2 = int.Parse(dia2[1]);
            ss2 = int.Parse(dia2[2]);

            difD = dd2 - dd1;

            difH = hh2 - hh1;
            if (difH < 0)
            {
                difH += 24;
                difD -= 1;
            }

            difM = mm2 - mm1;
            if (difM < 0)
            {
                difM += 60;
                difH -= 1;
            }

            difS = ss2 - ss1;
            if (difS < 0)
            {
                difS += 60;
                difM -= 1;
            }

            Console.WriteLine(difD + " dia(s)");
            Console.WriteLine(difH + " hora(s)");
            Console.WriteLine(difM + " minuto(s)");
            Console.WriteLine(difS + " segundo(s)");
            Console.ReadKey();
        }
    }
}
