using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] xy;
            int x, y;

            xy = Console.ReadLine().Split(' ');
            x = int.Parse(xy[0]);
            y = int.Parse(xy[1]);

            while (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }

                xy = Console.ReadLine().Split(' ');
                x = int.Parse(xy[0]);
                y = int.Parse(xy[1]);
            }

        }
    }
}

