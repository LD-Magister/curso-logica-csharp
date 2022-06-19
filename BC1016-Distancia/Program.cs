using System;
using System.Globalization;

class beecrowd
{

    static void Main(string[] args)
    {
        int carroX = 60;
        int carroY = 90;

        double kmDif = Math.Abs(carroX - carroY);
        double minDif = 60 / kmDif;

        int distancia = int.Parse(Console.ReadLine());

        Console.WriteLine((distancia * minDif).ToString("F0") + " minutos");
    }
}