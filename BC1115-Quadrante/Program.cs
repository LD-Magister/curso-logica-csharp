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

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }

                xy = Console.ReadLine().Split(' ');
                x = int.Parse(xy[0]);
                y = int.Parse(xy[1]);
            }
        }
    }
}