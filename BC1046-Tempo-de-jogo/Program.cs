using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {

            string[] horas;
            int hora1, hora2, tempo;

            horas = Console.ReadLine().Split(' ');
            hora1 = int.Parse(horas[0]);
            hora2 = int.Parse(horas[1]);

            if (hora1 < hora2)
            {
                tempo = hora2 - hora1;
            }
            else
            {
                tempo = hora2 + 24 - hora1;
            }

            Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S)");
        }
    }
}