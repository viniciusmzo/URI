using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, minutoInicial, minutoFinal, difHora, difMinuto;
            string[] vet = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[2]);
            minutoInicial = int.Parse(vet[1]);
            minutoFinal = int.Parse(vet[3]);

            difHora = horaFinal - horaInicial;
            if (difHora < 0) { difHora += 24; }

            difMinuto = minutoFinal - minutoInicial;
            if (difMinuto < 0) {
                difMinuto += 60;
                difHora -= 1;
            }

            if (horaInicial == horaFinal && minutoInicial == minutoFinal) { Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)"); }
            else { Console.WriteLine("O JOGO DUROU " + difHora + " HORA(S) E " + difMinuto + " MINUTO(S)"); }
            Console.ReadKey();


        }
    }
}
