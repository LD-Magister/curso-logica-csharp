using System;
using System.Globalization;

namespace beecrowd
{
    class iniciante
    {
        static void Main(string[] args)
        {
            int N, X, i, xIn, XOut;

            N = int.Parse(Console.ReadLine());
            xIn = 0;
            XOut = 0;


            for (i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                {
                    xIn++;
                }
                else
                {
                    XOut++;
                }
            }
            Console.WriteLine(xIn + " in");
            Console.WriteLine(XOut + " out");
        }
    }
}