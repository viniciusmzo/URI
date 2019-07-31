using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, contador;

            num = int.Parse(Console.ReadLine());
            contador = 0;

            while (contador < 6)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                    num += 1;
                    contador += 1;
                }
                else { num += 1; }
            }

           
            Console.ReadKey();
        }
    }
}
