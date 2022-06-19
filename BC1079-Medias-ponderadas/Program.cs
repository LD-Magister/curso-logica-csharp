using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] xyz;
            int N;
            double media, x, y, z;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                xyz = Console.ReadLine().Split(' ');
                x = double.Parse(xyz[0], CultureInfo.InvariantCulture);
                y = double.Parse(xyz[1], CultureInfo.InvariantCulture);
                z = double.Parse(xyz[2], CultureInfo.InvariantCulture);

                media = ((x * 2) + (y * 3) + (z * 5)) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}