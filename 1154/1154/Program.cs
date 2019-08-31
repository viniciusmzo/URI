using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int idade;
            double media = 0.0;

            idade = int.Parse(Console.ReadLine());
            while (idade > 0)
            {
                if (idade < 0) break;
                else if (idade >= 0)
                {
                    media += idade;
                    cont++;
                }

                idade = int.Parse(Console.ReadLine());
            }

            Console.WriteLine((media / cont).ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
