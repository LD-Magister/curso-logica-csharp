using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            string[] xy;
            int i, j, x, y;

            xy = Console.ReadLine().Split(' ');
            x = int.Parse(xy[0]);
            y = int.Parse(xy[1]);

            j = 1;

            for (i = 1; j <= y; i++)
            {
                if (j == y)
                {
                    Console.WriteLine(j);
                }
                else
                {
                    if (i == x)
                    {
                        Console.WriteLine(j);
                        i = 0;
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }
                }

                j += 1;

            }
        }
    }
}