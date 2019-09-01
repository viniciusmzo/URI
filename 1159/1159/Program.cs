using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma = 0;

            n = int.Parse(Console.ReadLine());

            if (n != 0)
            {
                if (n % 2 == 0)
                {
                    soma = n;
                    n++;
                }
                else if (n % 2 != 0)
                {
                    n++;
                    soma = n;
                }
            }

            while (n != 0)
            {


                for (int aux = 0; aux < 4;)
                {
                    if (n % 2 == 0)
                    {
                        soma += n;
                        aux++;
                        n++;
                    }
                    else if (n % 2 != 0)
                    {
                        n++;
                    }
                }


                Console.WriteLine(soma);
                n = int.Parse(Console.ReadLine());
                soma = 0;
                if (n == 0) break;
                else if (n != 0)
                {
                    if (n % 2 == 0)
                    {
                        soma = n;
                        n++;
                    }
                    else if (n % 2 != 0)
                    {
                        n++;
                        soma = n;
                        n++;
                    }
                }

            }


        }
    }
}

