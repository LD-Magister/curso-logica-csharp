using System;
using System.Globalization;

class beecrowd
{

    static void Main(string[] args)
    {

        int raio = int.Parse(Console.ReadLine());
        double pi = 3.14159;

        double volume = (4.0 / 3) * pi * (Math.Pow(raio, 3));

        Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));

    }
}