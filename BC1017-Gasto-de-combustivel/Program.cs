using System;
using System.Globalization;

class beecrowd
{

    static void Main(string[] args)
    {

        int tempoHoras = int.Parse(Console.ReadLine());
        int velocidadeKm = int.Parse(Console.ReadLine());

        double consumo = 12;

        double litros = (velocidadeKm * tempoHoras) / consumo;

        Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
    }
}