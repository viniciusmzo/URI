using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4;

            string[] vet = Console.ReadLine().Split(' ');

            nota1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            nota2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            nota3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            nota4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            var mediaP = ((nota1 * 2.0f) + (nota2 * 3.0f) + (nota3 * 4.0f) + (nota4 * 1.0f));
            var media = Math.Round(mediaP / 10, 1, MidpointRounding.ToEven);

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            if (media >= 7.00)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.00)
            {
                Console.WriteLine("Aluno em exame.");
                float notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));
                media = (media + notaExame) / 2.0f;
                if (media > 5.00)
                {
                    Console.WriteLine("Aluno aprovado.");

                }
                else
                {

                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.ReadKey();

        }
    }
}
