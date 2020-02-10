using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1179
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] par = new int[5];
            int[] impar = new int[5];
            int posImpar = 0, posPar = 0, contDigitado = 0;
            int numero;
            bool txP = false;
            bool txI = false;

            while (contDigitado < 15)
            {
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    par[posPar] = numero;
                    posPar++;
                }
                if (numero % 2 != 0)
                {
                    impar[posImpar] = numero;
                    posImpar++;
                }

                if (posImpar == 5 && txI == false) 
                {
                    for (int i = 0; i < 5; i++) 
                    {
                        Console.WriteLine("impar[" + i + "] = " + impar[i]);
                        impar[i] = 0;
                    }
                }
                if (posPar == 5 && txP == false)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("par["+ i +"] = " + par[i]);
                        par[i] = 0;
                    }
                }
                if (contDigitado == 14) 
                {
                    if (txI == true)
                    {
                        for (int i = 0; i < impar.Length; i++)
                        {
                            if (impar[i].ToString() != "0")
                            {
                                Console.WriteLine("impar[" + i + "] = " + impar[i]);
                            }
                        }
                    }
                    if (txP == true)
                    {
                        for (int i = 0; i < par.Length; i++)
                        {
                            if (par[i].ToString() != "0")
                            {
                                Console.WriteLine("par[" + i + "] = " + par[i]);
                            }
                        }
                    }
                }



                if (posImpar == 5) { posImpar = 0; txI = true; }
                if (posPar == 5) { posPar = 0; txP = true; }

                contDigitado++;
            }

            Console.ReadKey();
        }
    }
}
