using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] horamin;
            int horaIn, minIn, horaFin, minFin, totalMin, tempoHora, tempoMin;

            horamin = Console.ReadLine().Split(' ');
            horaIn = int.Parse(horamin[0]);
            minIn = int.Parse(horamin[1]);
            horaFin = int.Parse(horamin[2]);
            minFin = int.Parse(horamin[3]);

            if (horaFin <= horaIn && minFin <= minIn)
            {
                horaFin = horaFin + 24;
            }

            totalMin = ((horaFin - horaIn) * 60) + (minFin - minIn);
            tempoHora = (totalMin / 60);
            tempoMin = (totalMin % 60);

            Console.WriteLine("O JOGO DUROU " + tempoHora + " HORA(S) E " + tempoMin + " MINUTO(S)");
        }
    }
}