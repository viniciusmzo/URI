using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            num = int.Parse(Console.ReadLine());
            int[] vet = new int[num];
            string[] res = new string[num];

            for (int i = 0; i < num; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] == 0)
                {
                    res[i] = "NULL";
                }
                else
                {
                    if (vet[i] % 2 == 0)
                    {
                        if (vet[i] < 0)
                        {
                            res[i] = "EVEN NEGATIVE";
                        }
                        else if (vet[i] > 0)
                        {
                            res[i] = "EVEN POSITIVE";
                        }
                    }
                    if (vet[i] % 2 != 0)
                    {
                        if (vet[i] < 0)
                        {
                            res[i] = "ODD NEGATIVE";
                        }
                        else if (vet[i] > 0)
                        {
                            res[i] = "ODD POSITIVE";
                        }
                    }
                }   
            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(res[i]);
            }
                Console.ReadKey();
        }
    }
}
