using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());

            int horas = (tempo / 3600);
            int resto = (tempo % 3600);
            int minutos = resto / 60;
            int segundos = (resto % 60);

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}