using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int N, X, i;

            N = int.Parse(Console.ReadLine());

            for (i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());

                if (X == 0)
                {
                    Console.WriteLine("NULL");
                }
                else
                {
                    if (X % 2 == 0)
                    {
                        Console.Write("EVEN ");

                    }
                    else
                    {
                        Console.Write("ODD ");
                    }

                    if (X > 0)
                    {
                        Console.WriteLine("POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("NEGATIVE");
                    }
                }
            }
        }
    }
}